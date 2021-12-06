using System.Collections.Generic;
using System.Linq;
using UserManagement.Entities;

namespace UserManagement.Service.Repository.Interface
{
    public interface RolePermissionMapRepository
    {
        void insert(RolePermissionMap map);
        void update(RolePermissionMap map);
        void delete(RolePermissionMap map);
        List<RolePermissionMap> getAll();
        List<RolePermissionMap> getByRoleId(long role_id);
        RolePermissionMap getById(long map_id);
        IQueryable<RolePermissionMap> getQueryable();
    }
}
