using Core.Common.Dto;
using Core.Library.UnitOfWork;
using Project.Exceptions;
using System;
using UserManagement.Entities;
using UserManagement.Service.Assemblers.Interface;
using UserManagement.Service.Dto;
using UserManagement.Service.Repository.Interface;
using UserManagement.Service.Services.Interface;

namespace UserManagement.Service.Services.Implementations
{
    public class MenuServiceImpl : MenuService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly MenuRepository _menuRepository;
        private readonly MenuAssembler _menuAssembler;
        private readonly MenuPermissionMapRepository _menuPermissionMapRepository;

        public MenuServiceImpl(UnitOfWork unitOfWork,MenuRepository menuRepository,MenuAssembler menuAssembler,MenuPermissionMapRepository menuPermissionMapRepository)
        {
            _unitOfWork = unitOfWork;
            _menuRepository = menuRepository;
            _menuAssembler = menuAssembler;
            _menuPermissionMapRepository = menuPermissionMapRepository;
        }
        public void delete(DeleteDto deleteDto)
        {
            try
            {
                _unitOfWork.begin();
                var menu = _menuRepository.getById(deleteDto.Id)?? throw new ItemNotFoundException($"Menu with Id {deleteDto.Id} doesnot exist.");
                if (menu.hasSubMenus())
                    throw new ItemUsedException("This Menu has sub menus. You cannot delete at this moment.");
                menu.delete();
                menu.modified_by = deleteDto.modified_by;
                menu.modified_date = DateTime.Now;
                _unitOfWork.GetRepository<Menu>().update(menu);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void disable(ModificationDto dto)
        {
            try
            {
                _unitOfWork.begin();
                var menu = _menuRepository.getById(dto.Id);
                if (menu == null)
                    throw new ItemNotFoundException("Menu doesnot exist.");
                menu.setInactive();
                menu.modified_date = DateTime.Now;
                menu.modified_by = dto.modified_by;
                _unitOfWork.GetRepository<Menu>().update(menu);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void enable(ModificationDto dto)
        {
            try
            {
                _unitOfWork.begin();
                var menu = _menuRepository.getById(dto.Id);
                if (menu == null)
                    throw new ItemNotFoundException("Menu doesnot exist.");
                menu.setActive();
                menu.modified_date = DateTime.Now;
                menu.modified_by = dto.modified_by;
                _unitOfWork.GetRepository<Menu>().update(menu);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public Menu save(MenuDto menuDto)
        {
            try
            {
                _unitOfWork.begin();
                bool isDublicateMenuName = isMenuNameDublicateInSameModule(menuDto);
                if (isDublicateMenuName)
                    throw new DuplicateItemException("Menu with same name already exist in Module.Please try with another name.");
                Menu menu = new Menu();
                _menuAssembler.copy(menu, menuDto);
                menu.created_by = menuDto.created_by;
                menu.created_date = DateTime.Now;
                _unitOfWork.GetRepository<Menu>().insert(menu);

                //add permissions to menu
                MenuPermissionMap menuPermissionMap = new MenuPermissionMap();
                menuPermissionMap.menu_id = menu.Id;
                menuPermissionMap.created_by = menuDto.created_by;
                menuPermissionMap.setPermissions(menuDto.permissions);
                _unitOfWork.GetRepository<MenuPermissionMap>().insert(menuPermissionMap);

                _unitOfWork.commit();
                return menu;
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void update(MenuDto menuDto)
        {
            try
            {
                _unitOfWork.begin();
                var menu = _menuRepository.getById(menuDto.Id) ?? throw new ItemNotFoundException($"Menu with Id {menuDto.Id} doesnot exist.");
                bool isDublicateMenuName = isMenuNameDublicateInSameModule(menuDto);
                if (isDublicateMenuName)
                    throw new DuplicateItemException("Menu with same name already exist in Module.Please try with another name.");
                _menuAssembler.copy(menu, menuDto);
                menu.modified_by = menuDto.modified_by;
                menu.modified_date = DateTime.Now;
                _unitOfWork.GetRepository<Menu>().update(menu);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }
        private bool isMenuNameDublicateInSameModule(MenuDto menuDto)
        {
            var menuWithSameNameInModule = _menuRepository.getByModuleAndMenuName(menuDto.module_id, menuDto.name);
            bool menuWithSameNameExists = menuWithSameNameInModule != null;
            bool menuWithSameNameIsSameAsDto = false;
            if (menuWithSameNameInModule != null)
            {
                menuWithSameNameIsSameAsDto = menuWithSameNameInModule.Id == menuDto.Id;
            }
            if (menuWithSameNameExists && !menuWithSameNameIsSameAsDto)
            {
                return true;
            }
            return false;
        }
    }
}
