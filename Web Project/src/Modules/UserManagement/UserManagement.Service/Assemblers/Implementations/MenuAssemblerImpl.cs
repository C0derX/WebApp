using Project.Exceptions;
using UserManagement.Entities;
using UserManagement.Service.Assemblers.Interface;
using UserManagement.Service.Dto;
using UserManagement.Service.Repository.Interface;

namespace UserManagement.Service.Assemblers.Implementations
{
    public class MenuAssemblerImpl : MenuAssembler
    {
        private readonly ModuleRepository _moduleRepository;
        private readonly MenuRepository _menuRepository;

        public MenuAssemblerImpl(ModuleRepository moduleRepository , MenuRepository menuRepository)
        {
            _moduleRepository = moduleRepository;
            _menuRepository = menuRepository;
        }
        public void copy(Menu menu, MenuDto menuDto)
        {
            menu.name = menuDto.name;
            menu.module_id = menuDto.module_id;
            menu.parent_menu_id = menuDto.parent_menu_id;
            menu.web_url = menuDto.web_url;
            menu.api_url = menuDto.api_url;
            menu.display_icon = menuDto.display_icon;
            menu.display_order = menuDto.display_order;
            menu.is_visible_to_menu = menuDto.is_visible_to_menu;
            menu.Modules = _moduleRepository.getById(menuDto.module_id) ?? throw new ItemNotFoundException($"Module with id {menuDto.module_id} doesnot exist.");

            if (menuDto.parent_menu_id.HasValue && menuDto.parent_menu_id > 0)
            {
                menu.ParentMenu = _menuRepository.getById((long)menuDto.parent_menu_id) ?? throw new ItemNotFoundException($"Dynamic menu with id {menuDto.parent_menu_id} doesnot exist.");
            }

        }
    }
}
