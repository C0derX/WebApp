using Core.Common.Repository.Implementations;
using Core.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using UserManagement.Entities;
using UserManagement.Service.Repository.Interface;

namespace UserManagement.Context.Repository.Implementations
{
    public class MenuRepositoryImpl:BaseRepositoryImpl<Menu>,MenuRepository
    {
        private readonly AppDbContext _appDbContext;
        public MenuRepositoryImpl(AppDbContext appDbContext):base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<Menu> getByModule(long module_id)
        {
            return _appDbContext.menu.Where(a => a.module_id == module_id).ToList();
        }

        public Menu getByModuleAndMenuName(long module_id, string menu_name)
        {
            string trimmedMenuName = menu_name.Trim().Replace(" ", string.Empty).ToLower();

            return _appDbContext.menu.Where(a => a.module_id == module_id && !a.is_deleted && (a.name.Trim().Replace(" ", string.Empty).ToLower()).Equals(trimmedMenuName)).SingleOrDefault();
        }

        public List<Menu> getByParentId(long parent_id)
        {
            return _appDbContext.menu.Where(a => !a.is_deleted && a.parent_menu_id == parent_id).ToList();
        }

        public List<Menu> getMenusAssignedToUser(long user_id)
        {
            return _appDbContext.menu.FromSqlRaw($@" SELECT * FROM menu WHERE Id IN
            (SELECT Id FROM role_menu_map WHERE Id IN
               (SELECT Id FROM user_role_map WHERE Id = {user_id})
            )").ToList();
        }

        public void insert(List<Menu> menus)
        {
            _appDbContext.menu.AddRange(menus);
            _appDbContext.SaveChanges();
        }
    }
}
