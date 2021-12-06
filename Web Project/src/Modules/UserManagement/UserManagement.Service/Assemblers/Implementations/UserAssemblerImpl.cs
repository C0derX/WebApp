using UserManagement.Entities;
using UserManagement.Service.Assemblers.Interface;
using UserManagement.Service.Dto;

namespace UserManagement.Service.Assemblers.Implementations
{
    public class UserAssemblerImpl : UserAssembler
    {
        public void copy(User user, UserDto userDto)
        {
            user.Id = userDto.Id;
            user.email = userDto.email;
            user.username = userDto.username;
            user.is_active = userDto.is_active;
        }
    }
}
