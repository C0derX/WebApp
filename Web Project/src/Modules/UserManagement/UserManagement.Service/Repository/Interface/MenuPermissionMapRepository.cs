using System.Collections.Generic;
using System.Linq;
using UserManagement.Entities;

namespace UserManagement.Service.Repository.Interface
{
    public interface MenuPermissionMapRepository
    {
        void insert(MenuPermissionMap map);
        void update(MenuPermissionMap map);
        void delete(MenuPermissionMap map);
        List<MenuPermissionMap> getAll();
        List<MenuPermissionMap> getByMenuId(long menu_id);
        MenuPermissionMap getById(long map_id);
        IQueryable<MenuPermissionMap> getQueryable();
    }
}
