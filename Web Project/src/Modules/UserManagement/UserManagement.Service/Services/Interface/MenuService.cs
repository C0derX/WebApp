using Core.Common.Dto;
using UserManagement.Entities;
using UserManagement.Service.Dto;

namespace UserManagement.Service.Services.Interface
{
    public interface MenuService
    {
        Menu save(MenuDto menuDto);
        void update(MenuDto menuDto);
        void delete(DeleteDto deleteDto);
        void enable(ModificationDto dto);
        void disable(ModificationDto dto);
    }
}
