using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using UserManagement.Entities;
using UserManagement.Service.Dto;

namespace UserManagement.Service.Services.Interface
{
    public interface OrganizationService
    {
        void saveOrUpdate(OrganizationDto organization, IFormFile file);
    }
}
