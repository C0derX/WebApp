using Core.Common.Helpers;
using Core.Library.UnitOfWork;
using System;
using UserManagement.Entities;
using UserManagement.Service.Repository.Interface;
using UserManagement.Service.Services.Interface;

namespace UserManagement.Service.Services.Implementations
{
    public class AuthenticationServiceImpl : AuthenticationService
    {
        private readonly UserRepository _userRepository;
        private readonly PasswordHash _passwordHash;
        private readonly UnitOfWork _unitOfWork;

        public AuthenticationServiceImpl(UserRepository userRepository, PasswordHash passwordHash,UnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _passwordHash = passwordHash;
            _unitOfWork = unitOfWork;
        }

        public User validate(string username, string password)
        {
            try
            {
                var passwords = _passwordHash.CreateHash("password");
                var user = _userRepository.getByUsername(username);
                if (user == null)
                {
                    return null;
                }
                if (user.access_failed_count > 3)
                    throw new Exception("User has been blocked due to invalid login attemps. Please Contact administrator.");
                if (!_passwordHash.ValidatePassword(password, user.password))
                {
                    user.increaseAccessFailedCount();
                    _unitOfWork.GetRepository<User>().update(user);
                    return null;
                }

                return user;
            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }
}
