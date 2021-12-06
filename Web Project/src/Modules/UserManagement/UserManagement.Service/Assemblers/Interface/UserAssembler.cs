using UserManagement.Entities;
using UserManagement.Service.Dto;

namespace UserManagement.Service.Assemblers.Interface
{
    public interface UserAssembler
    {
        void copy(User user, UserDto userDto);
    }
}
