using UserManagement.Entities;
using UserManagement.Service.Assemblers.Interface;
using UserManagement.Service.Dto;

namespace UserManagement.Service.Assemblers.Implementations
{
    public class ModuleAssemblerImpl : ModuleAssembler
    {
        public void copy(Modules modules, ModuleDto moduleDto)
        {
            modules.code = moduleDto.code;
            modules.display_icon = moduleDto.display_icon;
            modules.display_order = moduleDto.display_order;
            modules.module_key = moduleDto.module_key;
            modules.name = moduleDto.name;
        }
    }
}
