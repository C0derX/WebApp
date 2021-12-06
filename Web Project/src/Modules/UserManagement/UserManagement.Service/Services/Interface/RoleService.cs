using Core.Common.Dto;
using UserManagement.Service.Dto;

namespace UserManagement.Service.Services.Interface
{
    public interface RoleService
    {
        void save(RoleDto roleDto);
        void update(RoleDto roleDto);
        void delete(DeleteDto deleteDto);
        void enable(ModificationDto modificationDto);
        void disable(ModificationDto modificationDto);
    }
}
