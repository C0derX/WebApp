using System.Collections.Generic;
using UserManagement.Service.Dto;

namespace UserManagement.Service.Services.Interface
{
    public interface RolePermissionMapService
    {
        void saveOrUpdate(RolePermissionMapDto rolePermissionMapDto);
    }
}
