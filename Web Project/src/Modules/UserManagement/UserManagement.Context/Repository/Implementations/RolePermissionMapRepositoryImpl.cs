using Core.Common.Repository.Implementations;
using Core.Context;
using System.Collections.Generic;
using System.Linq;
using UserManagement.Entities;
using UserManagement.Service.Repository.Interface;

namespace UserManagement.Context.Repository.Implementations
{
    public class RolePermissionMapRepositoryImpl:BaseRepositoryImpl<RolePermissionMap>,RolePermissionMapRepository
    {
        private readonly AppDbContext _appDbContext;
        public RolePermissionMapRepositoryImpl(AppDbContext appDbContext):base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<RolePermissionMap> getByRoleId(long role_id)
        {
            return _appDbContext.role_permission_map.Where(a => !a.is_deleted && a.role_id == role_id).ToList();
        }
    }
}
