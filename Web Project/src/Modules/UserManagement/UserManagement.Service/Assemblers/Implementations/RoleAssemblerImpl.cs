using System;
using System.Collections.Generic;
using System.Text;
using UserManagement.Entities;
using UserManagement.Service.Assemblers.Interface;
using UserManagement.Service.Dto;

namespace UserManagement.Service.Assemblers.Implementations
{
    public class RoleAssemblerImpl : RoleAssembler
    {
        public void copy(Role role, RoleDto roleDto)
        {
            role.name = roleDto.name;
            role.Id = roleDto.Id;
        }
    }
}
