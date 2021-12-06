using Core.Common.Enums;
using Core.Common.Extensions;
using Core.Common.Helpers;
using Core.Common.Helpers.PermissionHelpers;
using Core.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Web.PermissionHandler
{
    public class PermissionHandler : AuthorizationHandler<PermissionRequirement>, IDisposable
    {
        private AppDbContext _context;

        public PermissionHandler(AppDbContext context)
        {
            _context = context;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionRequirement requirement)
        {

            var claims = context.User.Claims;
            if (claims.Count() == 0)
            {
                return Task.CompletedTask;
            }

            var userId = Convert.ToInt64(claims.Where(a => a.Type == ClaimTypes.NameIdentifier).SingleOrDefault()?.Value);
            var associatedRoleIds = _context.user_role_map.Where(a => a.user_id == userId).Select(a=>a.role_id).ToList();
            var associatedMenusIds = _context.role_menu_map.Where(a => associatedRoleIds.Contains(a.role_id)).Select(a=>a.menu_id).ToList();
            var associatedMenus = _context.menu.Where(a => associatedMenusIds.Contains(a.Id));

            var associatedMenusUrls = associatedMenus.Select(a => a.web_url.ToLower()).ToList();


            if (context.Resource is RouteEndpoint endpoint)
            {
                endpoint.RoutePattern.RequiredValues.TryGetValue("area", out var _area);
                endpoint.RoutePattern.RequiredValues.TryGetValue("controller", out var _controller);
                endpoint.RoutePattern.RequiredValues.TryGetValue("action", out var _action);

                SlugifyParameterTransformer transformer = new SlugifyParameterTransformer();
                
                var url = $"/{_area}/{transformer.TransformOutbound(_controller)}/{transformer.TransformOutbound(_action)}".ToLower();

                var currentUrlMenu = associatedMenus.Where(a => a.web_url.ToLower() == url).SingleOrDefault();

                
                
                if (currentUrlMenu == null)
                {
                    return Task.CompletedTask;
                }

                List<Permissions> currentUrlPermissions =currentUrlMenu.MenuPermissionMap.getPermissions().ToList();
                string name = Enum.GetName(typeof(Permissions),currentUrlPermissions[0]);


                //modules to organization
                var organizationId = _context.organization.FirstOrDefault().Id;

                var modulesAssignedToOrganization = _context.organization_module_map.Where(a => a.organization_id == organizationId).ToList();


                string packedPermissions = CalcPermissionsForUser(claims, userId);

                if (packedPermissions.ThisPermissionIsAllowed(name) && associatedMenusUrls.Contains(url))
                    context.Succeed(requirement);

               // if (packedPermissions.ThisPermissionIsAllowed(requirement.PermissionName))
                 //   context.Succeed(requirement);

            }
            return Task.CompletedTask;
        }

        /// <summary>
        /// This is called if the Permissions that a user needs calculating.
        /// </summary>
        /// 
        public string CalcPermissionsForUser(IEnumerable<Claim> claims, long userId)
        {

            var dbContext = _context;
            //This gets all the permissions, with a distinct to remove duplicates
            var roleId = _context.user_role_map.Where(a => a.user_id == userId).SingleOrDefault().role_id;
            var rolePermissionMaps = dbContext.role_permission_map.Where(x => x.role_id == roleId).ToList();


            List<Permissions> permissions = rolePermissionMaps.SelectMany(a => a.getPermissions()).ToList();



            //Now we remove permissions that are linked to modules that the user has no access top
            var filteredPermissions =
                from permission in permissions
                select permission;

            return filteredPermissions.PackPermissionsIntoString();
        }

        #region IDisposable Support

        protected virtual void Dispose(bool disposing)
        {
            if (_context != null)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.
                _context = null;
            }
        }
        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
