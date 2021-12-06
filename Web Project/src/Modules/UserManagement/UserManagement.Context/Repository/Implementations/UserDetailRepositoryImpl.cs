using Core.Common.Repository.Implementations;
using Core.Context;
using System.Linq;
using UserManagement.Entities;
using UserManagement.Service.Repository.Interface;

namespace UserManagement.Context.Repository.Implementations
{
    public class UserDetailRepositoryImpl:BaseRepositoryImpl<UserDetails>,UserDetailRepository
    {
        private readonly AppDbContext _appDbContext;
        public UserDetailRepositoryImpl(AppDbContext appDbContext):base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public UserDetails getByUserId(long user_id)
        {
            return _appDbContext.user_details.Where(a => !a.User.is_deleted && a.user_id == user_id).SingleOrDefault();
        }
    }
}
