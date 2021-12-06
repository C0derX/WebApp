using UserManagement.Entities;
using UserManagement.Service.Dto;

namespace UserManagement.Service.Assemblers.Interface
{
    public interface UserDetailAssembler
    {
        void copy(UserDetails userDetails, UserDetailDto userDetailDto);
        void copy(UserDetailDto user_detail_dto, UserDto user_dto);
    }
}
