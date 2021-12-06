using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using UserManagement.Service.Dto;

namespace UserManagement.Service.Services.Interface
{
    public interface UserDetailService
    {
        void saveOrUpdate(UserDetailDto user_detail_dto, IFormFile file);
    }
}
