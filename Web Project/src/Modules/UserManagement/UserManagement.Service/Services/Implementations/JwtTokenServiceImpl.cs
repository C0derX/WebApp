using Core.Library.UnitOfWork;
using Project.Exceptions;
using System;
using System.Linq;
using UserManagement.Entities;
using UserManagement.Service.Repository.Interface;
using UserManagement.Service.Services.Interface;

namespace UserManagement.Service.Services.Implementations
{
    public class JwtTokenServiceImpl:JwtTokenService
    {
        private readonly JwtTokenRepository _jwtTokenRepo;
        private readonly UserRepository _userRepo;
        private readonly UnitOfWork _unitOfWork;

        public JwtTokenServiceImpl(JwtTokenRepository jwtTokenRepo, UserRepository userRepo, UnitOfWork unitOfWork)
        {
            _jwtTokenRepo = jwtTokenRepo;
            _userRepo = userRepo;
            _unitOfWork = unitOfWork;
        }

        public void saveOrUpdate(long user_id, string previous_refresh_token, string new_refresh_token)
        {
            try
            {
                _unitOfWork.begin();

                var token = _jwtTokenRepo.getQueryable().Where(a => a.user_id == user_id && a.old_token == previous_refresh_token).SingleOrDefault();

                if (token == null)
                {
                    save(user_id, previous_refresh_token, new_refresh_token);
                }
                else
                {
                    update(token, new_refresh_token);
                }
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        private void update(JwtToken token, string new_refresh_token)
        {
            token.new_token = new_refresh_token;
            _unitOfWork.GetRepository<JwtToken>().update(token);
        }

        private void save(long user_id, string old_refresh_token, string new_refresh_token)
        {
            JwtToken token = new JwtToken();
            token.user_id = user_id;
            token.old_token = old_refresh_token;
            token.new_token = new_refresh_token;
            token.User = _userRepo.getById(user_id) ?? throw new InvalidValueException($"User with id {user_id} doesnot exist.");

            _unitOfWork.GetRepository<JwtToken>().insert(token);
        }
    }
}
