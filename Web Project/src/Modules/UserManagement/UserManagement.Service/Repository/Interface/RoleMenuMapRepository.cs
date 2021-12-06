using System.Collections.Generic;
using System.Linq;
using UserManagement.Entities;

namespace UserManagement.Service.Repository.Interface
{
    public interface RoleMenuMapRepository
    {
        void insert(RoleMenuMap map);
        void update(RoleMenuMap map);
        void delete(RoleMenuMap map);
        List<RoleMenuMap> getAll();
        List<RoleMenuMap> getByRole(long role_id);
        List<RoleMenuMap> getByMenuId(long menu_id);
        RoleMenuMap getByRoleAndMenu(long role_id, long menu_id);
        RoleMenuMap getById(long map_id);
        IQueryable<RoleMenuMap> getQueryable();
    }
}
