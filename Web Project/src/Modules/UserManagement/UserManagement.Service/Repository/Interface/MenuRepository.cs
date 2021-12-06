using System.Collections.Generic;
using System.Linq;
using UserManagement.Entities;

namespace UserManagement.Service.Repository.Interface
{
    public interface MenuRepository
    {
        void insert(Menu menu);
        void insert(List<Menu> menus);
        void update(Menu menu);
        void delete(Menu menu);
        Menu getById(long menu_id);
        List<Menu> getAll();
        List<Menu> getMenusAssignedToUser(long user_id);
        List<Menu> getByModule(long module_id);
        List<Menu> getByParentId(long parent_id);
        Menu getByModuleAndMenuName(long module_id, string menu_name);
        IQueryable<Menu> getQueryable();
    }
}
