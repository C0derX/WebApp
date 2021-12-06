using UserManagement.Entities;
using UserManagement.Service.Dto;

namespace UserManagement.Service.Assemblers.Interface
{
    public interface RoleAssembler
    {
        void copy(Role role, RoleDto roleDto);
    }
}
