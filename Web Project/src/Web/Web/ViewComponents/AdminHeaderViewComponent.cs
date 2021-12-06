using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using UserManagement.Entities;
using UserManagement.Service.Repository.Interface;

namespace Web.ViewComponents
{
    [ViewComponent(Name = "AdminHeaderView")]
    public class AdminHeaderViewComponent : ViewComponent
    {
        private readonly OrganizationModuleMapRepository _organizationModuleMapRepository;
        private readonly OrganizationRepository _organizationRepository;
        private readonly UserRoleMapRepository _userRoleMapRepository;
        private readonly RoleMenuMapRepository _roleMenuMapRepository;
        private readonly UserRepository _userRepository;

        public AdminHeaderViewComponent(OrganizationModuleMapRepository organizationModuleMapRepository,OrganizationRepository organizationRepository,UserRoleMapRepository userRoleMapRepository,RoleMenuMapRepository roleMenuMapRepository,UserRepository userRepository)
        {
            _organizationModuleMapRepository = organizationModuleMapRepository;
            _organizationRepository = organizationRepository;
            _userRoleMapRepository = userRoleMapRepository;
            _roleMenuMapRepository = roleMenuMapRepository;
            _userRepository = userRepository;
        }

         public async Task<IViewComponentResult> InvokeAsync()
        {
            long loggedInUserId =Convert.ToInt32(Request.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

            var organization = _organizationRepository.getAll().SingleOrDefault();
            List<OrganizationModuleMap> modulesAssignedToOrganization=null;
            if (organization != null)
            {
               
                 modulesAssignedToOrganization = _organizationModuleMapRepository.getQueryable().Where(a => a.organization_id == organization.Id).ToList();

                var userRoles = _userRoleMapRepository.getByUser(loggedInUserId);
            }


            //   var menuAssignedToRoles=_roleMenuMapRepository.get
            var userDetails = _userRepository.getById(loggedInUserId);

            ViewBag.modules = modulesAssignedToOrganization;
            ViewBag.organization = organization;
            ViewBag.user = userDetails;
             return  View();
            
        }

    }
}
