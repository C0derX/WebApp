using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using UserManagement.Entities;
using UserManagement.Service.Repository.Interface;

namespace UserManagement.Web.Areas.Administator.Controllers
{
    public class BaseController : Controller
    {
        public UserDetailRepository _userDetailRepository { get; set; }
        public UserRoleMapRepository _userRoleMapRepository { get; set; }
        public RoleMenuMapRepository _roleMenuMapRepository { get; set; }
        public MenuRepository _menuRepository { get; set; }
        public ModuleRepository _moduleRepository { get; set; }
        public UserRepository _userRepository { get; set; }

        protected long getLoggedInUserId()
        {
            return Convert.ToInt64(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        }

        
        protected UserDetails getLoggedInUserDetail()
        {
            var userId = getLoggedInUserId();

            return _userDetailRepository.getByUserId(userId);
        }

        protected List<UserRoleMap> getRolesOfLoggedInUser()
        {
            var loggedInUserId = getLoggedInUserId();

            var maps = _userRoleMapRepository.getByUser(loggedInUserId);
            return maps;
        }
    }
}
