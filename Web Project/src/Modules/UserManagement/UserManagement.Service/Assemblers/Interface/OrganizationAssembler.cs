using System;
using System.Collections.Generic;
using System.Text;
using UserManagement.Entities;
using UserManagement.Service.Dto;

namespace UserManagement.Service.Assemblers.Interface
{
    public interface OrganizationAssembler
    {
        void copy(Organization organization, OrganizationDto organizationDto);
    }
}
