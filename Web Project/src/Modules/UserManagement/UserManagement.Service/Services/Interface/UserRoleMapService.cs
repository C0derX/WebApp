using Core.Common.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using UserManagement.Service.Dto;

namespace UserManagement.Service.Services.Interface
{
    public interface UserRoleMapService
    {
        void saveOrUpdate(List<UserRoleMapDto> dtos);
        void save(UserRoleMapDto dto);
        void update(UserRoleMapDto dto);
        void delete(DeleteDto dto);
    }
}
