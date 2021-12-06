using Core.Common.Dto;
using Core.Common.Helpers;
using Core.Common.Library.Interface;
using Core.Library.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Project.Exceptions;
using System;
using UserManagement.Entities;
using UserManagement.Service.Assemblers.Interface;
using UserManagement.Service.Dto;
using UserManagement.Service.Repository.Interface;
using UserManagement.Service.Services.Interface;

namespace UserManagement.Service.Services.Implementations
{
    public class UserServiceImpl : UserService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly UserRepository _userRepository;
        private readonly PasswordHash _passwordHash;
        private readonly MailFormatService _mailFormatService;
        private readonly EmailSenderService _emailSenderService;
        private readonly Cryptography _cryptography;
        private readonly RandomKeyGeneratorService _randomKeyGeneratorService;
        private readonly UserAssembler _userAssembler;
        private readonly UserDetailAssembler _userDetailAssembler;
        private readonly UserDetailService _userDetailService;
        private readonly UserRoleMapService _userRoleMapService;

        public UserServiceImpl(UnitOfWork unitOfWork, UserRepository userRepository, PasswordHash passwordHash, MailFormatService mailFormatService, EmailSenderService emailSenderService, Cryptography cryptography, RandomKeyGeneratorService randomKeyGeneratorService, UserAssembler userAssembler, UserDetailAssembler userDetailAssembler, UserDetailService userDetailService ,UserRoleMapService userRoleMapService)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
            _passwordHash = passwordHash;
            _mailFormatService = mailFormatService;
            _emailSenderService = emailSenderService;
            _cryptography = cryptography;
            _randomKeyGeneratorService = randomKeyGeneratorService;
            _userAssembler = userAssembler;
            _userDetailAssembler = userDetailAssembler;
            _userDetailService = userDetailService;
            _userRoleMapService = userRoleMapService;
        }
        public void changePassword(ChangePasswordDto change_password_dto)
        {
            try
            {
                _unitOfWork.begin();
                var user = _userRepository.getById(change_password_dto.user_id) ?? throw new ItemNotFoundException($"User with the id {change_password_dto.user_id} doesnot exist.");

                bool isOldPasswordCorrect = _passwordHash.ValidatePassword(change_password_dto.old_password, user.password);
                if (!isOldPasswordCorrect)
                    throw new InvalidValueException($"Old password is incorrect.");
                user.password = _passwordHash.CreateHash(change_password_dto.new_password);
                user.modified_by = change_password_dto.modified_by;
                user.modified_date = DateTime.Now;
                user.increasePasswordChangeCount();
                sendFirstTimeLoginEmail(user.email, change_password_dto.new_password);

                _unitOfWork.GetRepository<User>().update(user);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void delete(DeleteDto dto)
        {
            try
            {
                _unitOfWork.begin();
                var user = _userRepository.getById(dto.Id) ?? throw new ItemNotFoundException($"User with Id {dto.Id} doesnot exist.");
                if (user.is_email_confirmed)
                {
                    user.delete();
                    user.modified_by = dto.modified_by;
                    user.modified_date = DateTime.Now;
                    _unitOfWork.GetRepository<User>().update(user);
                }
                else
                {
                    _unitOfWork.GetRepository<User>().delete(user);
                }
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void disable(ModificationDto dto)
        {
            try
            {
                _unitOfWork.begin();
                var user = _userRepository.getById(dto.Id) ?? throw new ItemNotFoundException($"User with Id {dto.Id} doesnot exist.");
                user.setInactive();
                user.modified_by = dto.modified_by;
                user.modified_date = DateTime.Now;
                _unitOfWork.GetRepository<User>().update(user);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void enable(ModificationDto dto)
        {
            try
            {
                _unitOfWork.begin();
                var user = _userRepository.getById(dto.Id) ?? throw new ItemNotFoundException($"User with Id {dto.Id} doesnot exist.");
                user.setActive();
                user.modified_by = dto.modified_by;
                user.modified_date = DateTime.Now;
                _unitOfWork.GetRepository<User>().update(user);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void markEmailRegistered(string token)
        {
            try
            {
                _unitOfWork.begin();
                var encryptedToken = _cryptography.Encrypt(token);
                var user = _userRepository.getByToken(encryptedToken) ?? throw new ItemNotFoundException($"Token didnot match.");
                if (user.is_email_confirmed)
                {
                    return;
                }
                else
                {
                    bool isTokenOutOfDate = isTokenExpired(user);
                    if (isTokenOutOfDate)
                        throw new InvalidStateTransitionException("Token is expired.");
                }
                user.markEmailAsConfirmed();
                _unitOfWork.GetRepository<User>().update(user);
                _unitOfWork.commit();
            }
            catch (Exception ex)
            {
                _unitOfWork.rollback();
                throw ex;
            }
        }

        public void register(RegisterDto register_dto)
        {
            try
            {
                _unitOfWork.begin();
                var token = _randomKeyGeneratorService.getRandomAlphanumericKey(200);
                var userDto = new UserDto()
                {
                    email = register_dto.email,
                    password = register_dto.password,
                };
                deleteOldDataIfPreviousTokenIsExpired(register_dto);
                bool isUsernameValid = checkNameValidity(userDto);
                if (!isUsernameValid)
                    throw new DuplicateItemException("Email address is already used.");
                User user = new User();
                _userAssembler.copy(user, userDto);
                user.password = _passwordHash.CreateHash(userDto.password);
                user.created_date = DateTime.Now;
                user.created_by = register_dto.created_by;
                var encryptedToken = _cryptography.Encrypt(token);
                user.registration_token = encryptedToken;
                var fullUrl = $"{register_dto.base_url}/email-confirm?token={token}";
                sendEmail(register_dto, fullUrl);
                _unitOfWork.GetRepository<User>().insert(user);
                _unitOfWork.commit();
            }
            catch (Exception ex)
            {
                _unitOfWork.rollback();
                throw ex;
            }
        }

        public void resetPassword(ChangePasswordDto change_password_dto)
        {
            try
            {
                _unitOfWork.begin();
                var user = _userRepository.getById(change_password_dto.user_id) ?? throw new ItemNotFoundException($"User with the id {change_password_dto.user_id} doesnot exist.");
                user.password = _passwordHash.CreateHash(change_password_dto.new_password);
                user.modified_by = change_password_dto.modified_by;
                user.modified_date = DateTime.Now;
                user.increasePasswordChangeCount();
                sendFirstTimeLoginEmail(user.email, change_password_dto.new_password);
                _unitOfWork.GetRepository<User>().update(user);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void save(UserDto user_dto)
        {
            try
            {
                _unitOfWork.begin();
                bool isUsernameValid = checkNameValidity(user_dto);
                if (!isUsernameValid)
                    throw new DuplicateItemException("User with same name already exists.");
                User user = new User();
                if (!string.IsNullOrWhiteSpace(user_dto.registration_token))
                    user.registration_token = user_dto.registration_token;
                _userAssembler.copy(user, user_dto);
                user.created_date = DateTime.Now;
                user.created_by = user_dto.created_by;
                user.markEmailAsConfirmed();
                user.password = _passwordHash.CreateHash(user_dto.password);
                _unitOfWork.GetRepository<User>().insert(user);
                UserDetails userDetails = new UserDetails();
                user_dto.user_detail_dto.user_id = user.Id;
                _userDetailAssembler.copy(userDetails, user_dto.user_detail_dto);
                _unitOfWork.GetRepository<UserDetails>().insert(userDetails);

                UserRoleMapDto dto = new UserRoleMapDto();
                dto.user_id = user.Id;
                dto.role_id = user_dto.role_id;
                dto.created_by = user_dto.created_by;
                _userRoleMapService.save(dto);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void sendPasswordRecoveryEmail(RecoverPasswordDto recover_password_dto)
        {
            try
            {
                var user = _userRepository.getByUserEmail(recover_password_dto.email) ?? throw new ItemNotFoundException($"User with the email {recover_password_dto.email} doesnot exist.");
                var fullUrl = $"{recover_password_dto.base_url}/reset-password/{user.Id}";
                sendRecoveryEmail(recover_password_dto, fullUrl);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void update(UserDto user_dto,IFormFile file)
        {
            try
            {
                _unitOfWork.begin();
                User user = _userRepository.getById(user_dto.Id) ?? throw new ItemNotFoundException($"User with the id {user_dto.Id} doesnot exist.");
                bool isUsernameValid = checkNameValidity(user_dto);
                if (!isUsernameValid)
                    throw new DuplicateItemException("User with same name already exists.");
                _userAssembler.copy(user, user_dto);
                user.modified_by = user_dto.modified_by;
                user.modified_date = DateTime.Now;
                _unitOfWork.GetRepository<User>().update(user);
                UserDetailDto userDetailDto = new UserDetailDto();
                _userDetailAssembler.copy(userDetailDto, user_dto);
                _userDetailService.saveOrUpdate(userDetailDto, file);


                UserRoleMapDto dto = new UserRoleMapDto();
                dto.user_id = user.Id;
                dto.role_id = user_dto.role_id;
                dto.modified_by = user_dto.modified_by;
                _userRoleMapService.update(dto);

                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        private async void sendFirstTimeLoginEmail(string to_email, string new_pass)
        {
            string htmlMessage = _mailFormatService.getChangePasswordMailFormat(to_email, new_pass);
            await _emailSenderService.SendEmailAsync(to_email, "Password Changed !!", htmlMessage);
        }

        private bool isTokenExpired(User isUserRegisteredBefore)
        {
            var registeredDate = isUserRegisteredBefore.created_date;
            var hoursDifference = (DateTime.Now - registeredDate).Hours;
            return hoursDifference > 24;
        }

        private void deleteOldDataIfPreviousTokenIsExpired(RegisterDto register_dto)
        {
            var isUserRegisteredBefore = _userRepository.getByUsername(register_dto.email);
            if (isUserRegisteredBefore != null && !isUserRegisteredBefore.is_email_confirmed)
            {
                bool isTokenOutOfDate = isTokenExpired(isUserRegisteredBefore);
                if (isTokenOutOfDate)
                {
                    _userRepository.delete(isUserRegisteredBefore);
                }
            }
        }

        private bool checkNameValidity(UserDto user_dto)
        {
            var userWithSameEmail = _userRepository.getByUsername(user_dto.email);
            return userWithSameEmail == null || userWithSameEmail.Id == user_dto.Id;
        }

        private async void sendEmail(RegisterDto register_dto, string full_url)
        {
            string htmlMessage = _mailFormatService.getRegisterMailFormat(register_dto, full_url);
            await _emailSenderService.SendEmailAsync(register_dto.email, "Confirm your account !!", htmlMessage);
        }

        private async void sendRecoveryEmail(RecoverPasswordDto dto, string full_url)
        {
            string htmlMessage = _mailFormatService.getRecoverPasswordMailFormat(dto, full_url);
            await _emailSenderService.SendEmailAsync(dto.email, "Recover Password!!", htmlMessage);
        }
    }
}
