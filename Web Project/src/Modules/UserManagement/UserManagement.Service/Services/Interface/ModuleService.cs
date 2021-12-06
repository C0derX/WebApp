using Core.Common.Dto;
using UserManagement.Service.Dto;

namespace UserManagement.Service.Services.Interface
{
    public interface ModuleService
    {
        void save(ModuleDto moduleDto);
        void update(ModuleDto moduleDto);
        void delete(DeleteDto dto);
    }
}
