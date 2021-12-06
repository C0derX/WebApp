using Core.Common.Repository.Implementations;
using Core.Context;
using System.Linq;
using UserManagement.Entities;
using UserManagement.Service.Repository.Interface;

namespace UserManagement.Context.Repository.Implementations
{
    public class UserRepositoryImpl:BaseRepositoryImpl<User>,UserRepository
    {
        private readonly AppDbContext _appDbContext;
        public UserRepositoryImpl(AppDbContext appDbContext):base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public User getByToken(string token)
        {
            return _appDbContext.user.Where(a => a.registration_token == token).SingleOrDefault();
        }

        public User getByUserEmail(string email)
        {
            return _appDbContext.user.Where(a => !a.is_deleted && a.email == email).SingleOrDefault();
        }

        public User getByUsername(string username)
        {
            return _appDbContext.user.Where(a => !a.is_deleted && a.username == username).SingleOrDefault();
        }
    }
}
