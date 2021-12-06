using System;
using UserManagement.Entities;
using UserManagement.Service.Assemblers.Interface;
using UserManagement.Service.Dto;

namespace UserManagement.Service.Assemblers.Implementations
{
    public class UserDetailAssemblerImpl : UserDetailAssembler
    {
        public void copy(UserDetails userDetails, UserDetailDto userDetailDto)
        {
            userDetails.first_name = userDetailDto.first_name;
            userDetails.last_name = userDetailDto.last_name;
            if (userDetailDto.image != null)
            {
                userDetails.image = userDetailDto.image;
            }
            userDetails.permanent_address = userDetailDto.permanent_address;
            userDetails.temporary_address = userDetailDto.temporary_address;
            userDetails.primary_contact = userDetailDto.primary_contact;
            userDetails.secondary_contact = userDetailDto.secondary_contact;
            userDetails.user_id = userDetailDto.user_id;
            
        }
        public void copy(UserDetailDto user_detail_dto, UserDto user_dto)
        {
            user_detail_dto.user_id = user_dto.Id;
            user_detail_dto.first_name = user_dto.user_detail_dto.first_name;
            user_detail_dto.last_name = user_dto.user_detail_dto.last_name;
            user_detail_dto.permanent_address = user_dto.user_detail_dto.permanent_address;
            user_detail_dto.temporary_address = user_dto.user_detail_dto.temporary_address;
            user_detail_dto.primary_contact = user_dto.user_detail_dto.primary_contact;
            user_detail_dto.secondary_contact = user_dto.user_detail_dto.secondary_contact;
            if (user_dto.user_detail_dto.image != null)
            {
                user_detail_dto.image = user_dto.user_detail_dto.image;

            }

        }
    }
}
