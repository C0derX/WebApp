using Core.Common.Repository.Implementations;
using Core.Context;
using System.Linq;
using UserManagement.Entities;
using UserManagement.Service.Repository.Interface;

namespace UserManagement.Context.Repository.Implementations
{
    public class UserLoggedInStatusRepositoryImpl:BaseRepositoryImpl<UserLoggedInStatus>,UserLoggedInStatusRepository
    {
        private readonly AppDbContext _appDbContext;
        public UserLoggedInStatusRepositoryImpl(AppDbContext appDbContext):base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public UserLoggedInStatus getByUserId(long Id)
        {
            return _appDbContext.user_loggedin_status_setup.Where(a => a.user_id == Id).SingleOrDefault();
        }
    }
}
