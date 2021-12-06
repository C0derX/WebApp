using Core.Common.Repository.Implementations;
using Core.Context;
using System.Collections.Generic;
using System.Linq;
using UserManagement.Entities;
using UserManagement.Service.Repository.Interface;

namespace UserManagement.Context.Repository.Implementations
{
   public class UserRoleMapRepositoryImpl:BaseRepositoryImpl<UserRoleMap>,UserRoleMapRepository
    {
        private readonly AppDbContext _appDbContext;
        public UserRoleMapRepositoryImpl(AppDbContext appDbContext):base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<UserRoleMap> getByRole(long role_id)
        {
            return _appDbContext.user_role_map.Where(a => a.role_id == role_id).ToList();
        }

        public UserRoleMap getByRoleAndUser(long role_id, long user_id)
        {
            return _appDbContext.user_role_map.Where(a => a.role_id == role_id && a.user_id == user_id).SingleOrDefault();
        }

        public List<UserRoleMap> getByUser(long user_id)
        {
            return _appDbContext.user_role_map.Where(a => a.user_id == user_id).ToList();
        }
    }
}
