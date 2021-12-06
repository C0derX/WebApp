using UserManagement.Entities;
using UserManagement.Service.Dto;

namespace UserManagement.Service.Assemblers.Interface
{
    public interface MenuAssembler
    {
        void copy(Menu menu, MenuDto menuDto);
    }
}
