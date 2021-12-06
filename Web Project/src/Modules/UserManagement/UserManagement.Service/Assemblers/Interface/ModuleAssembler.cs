using UserManagement.Entities;
using UserManagement.Service.Dto;

namespace UserManagement.Service.Assemblers.Interface
{
    public interface ModuleAssembler
    {
        void copy(Modules modules, ModuleDto moduleDto);
    }
}
