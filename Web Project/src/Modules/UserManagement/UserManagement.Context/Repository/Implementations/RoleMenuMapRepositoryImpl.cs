using Core.Common.Repository.Implementations;
using Core.Context;
using System.Collections.Generic;
using System.Linq;
using UserManagement.Entities;
using UserManagement.Service.Repository.Interface;

namespace UserManagement.Context.Repository.Implementations
{
    public class RoleMenuMapRepositoryImpl:BaseRepositoryImpl<RoleMenuMap>,RoleMenuMapRepository
    {
        private readonly AppDbContext _appDbContext;
        public RoleMenuMapRepositoryImpl(AppDbContext appDbContext):base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<RoleMenuMap> getByMenuId(long menu_id)
        {
            return _appDbContext.role_menu_map.Where(a => !a.is_deleted && a.menu_id == menu_id).ToList();
        }

        public List<RoleMenuMap> getByRole(long role_id)
        {
            return _appDbContext.role_menu_map.Where(a => !a.is_deleted && a.role_id == role_id).ToList();
        }

        public RoleMenuMap getByRoleAndMenu(long role_id, long menu_id)
        {
            return _appDbContext.role_menu_map.Where(a => !a.is_deleted && a.role_id == role_id && a.menu_id == menu_id).SingleOrDefault();
        }
    }
}
