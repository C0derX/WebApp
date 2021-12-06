using Core.Common.Dto;
using System.Collections.Generic;
using UserManagement.Service.Dto;

namespace UserManagement.Service.Services.Interface
{
    public interface RoleMenuMapService
    {
        void save(RoleMenuMapDto roleMenuMapDto);
        void update(RoleMenuMapDto roleMenuMapDto);
        void saveOrUpdate(RoleMenuMapDto roleMenuMapDto);
        void saveOrUpdate(List<RoleMenuMapDto> roleMenuMapDtos);
        void delete(DeleteDto deleteDto);
    }
}
