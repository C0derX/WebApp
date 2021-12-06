using Core.Common.Enums;
using Microsoft.AspNetCore.Authorization;
using System;

namespace Web.PermissionHandler
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = false)]
    public class HasPermissionAttribute : AuthorizeAttribute
    {
        public HasPermissionAttribute(Permissions permission) : base(permission.ToString())
        { }
    }
}
