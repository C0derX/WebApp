using Core.Common.Dto;
using System.Collections.Generic;
using UserManagement.Service.Dto;

namespace UserManagement.Service.Services.Interface
{
    public interface OrganizationModuleMapService
    {
        void saveOrUpdate(OrganizationModuleMapDto organizationModuleMapDto);
        void saveOrUpdate(long org_id,List<OrganizationModuleMapDto> organizationModuleMapDtos);
        void update(OrganizationModuleMapDto organizationModuleMapDto);
        void delete(DeleteDto dto);
    }
}
