using Core.Common.Repository.Implementations;
using Core.Context;
using System.Collections.Generic;
using System.Linq;
using UserManagement.Entities;
using UserManagement.Service.Repository.Interface;

namespace UserManagement.Context.Repository.Implementations
{
    public class MenuPermissionMapRepositoryImpl:BaseRepositoryImpl<MenuPermissionMap>,MenuPermissionMapRepository
    {
        private readonly AppDbContext _appDbContext;
        public MenuPermissionMapRepositoryImpl(AppDbContext appDbContext):base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<MenuPermissionMap> getByMenuId(long menu_id)
        {
            return _appDbContext.menu_permission_map.Where(a => !a.is_deleted && a.menu_id == menu_id).ToList();
        }
    }
}
