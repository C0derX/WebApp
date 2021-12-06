using Core.Common.Dto;
using Core.Library.UnitOfWork;
using Project.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using UserManagement.Entities;
using UserManagement.Service.Dto;
using UserManagement.Service.Repository.Interface;
using UserManagement.Service.Services.Interface;

namespace UserManagement.Service.Services.Implementations
{
    public class RoleMenuMapServiceImpl : RoleMenuMapService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly RoleMenuMapRepository _roleMenuMapRepository;
        private readonly MenuRepository _menuRepository;
        private readonly RoleRepository _roleRepository;

        public RoleMenuMapServiceImpl(UnitOfWork unitOfWork,RoleMenuMapRepository roleMenuMapRepository,MenuRepository menuRepository,RoleRepository roleRepository)
        {
            _unitOfWork = unitOfWork;
            _roleMenuMapRepository = roleMenuMapRepository;
            _menuRepository = menuRepository;
            _roleRepository = roleRepository;
        }
        public void delete(DeleteDto deleteDto)
        {
            try
            {
                _unitOfWork.begin();
                var roleMenuMap = _roleMenuMapRepository.getById(deleteDto.Id) ?? throw new ItemNotFoundException($"Role Menu Map with ID {deleteDto.Id} doesnot exist. ");
                roleMenuMap.delete();
                roleMenuMap.modified_by = deleteDto.modified_by;
                roleMenuMap.modified_date = DateTime.Now;
                _unitOfWork.GetRepository<RoleMenuMap>().update(roleMenuMap);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void save(RoleMenuMapDto roleMenuMapDto)
        {
            try
            {
                _unitOfWork.begin();
                List<long> distinctMenuIds = roleMenuMapDto.menu_ids.Distinct().ToList();
                int countOfSpecifiedRoleAndMenus = _roleMenuMapRepository.getQueryable().Where(a => distinctMenuIds.Contains(a.Id) && a.role_id == roleMenuMapDto.role_id).Count();
                if (countOfSpecifiedRoleAndMenus > 0)
                {
                    throw new InvalidValueException($"Role menu map for same role and same menu already exists.");
                }
                var menus = _menuRepository.getQueryable().Where(a => distinctMenuIds.Contains(a.Id)).ToList();
                Role role = _roleRepository.getById(roleMenuMapDto.role_id) ?? throw new ItemNotFoundException($"Role with id {roleMenuMapDto.role_id} doesnot exist.");
                List<RoleMenuMap> mappings = new List<RoleMenuMap>();
                foreach (var menuId in roleMenuMapDto.menu_ids)
                {
                    var roleMenuMap = new RoleMenuMap();
                    roleMenuMap.Role = role;
                    roleMenuMap.Menu = menus.Where(a => a.Id == menuId).SingleOrDefault() ?? throw new ItemNotFoundException($"Menu with id {menuId} doesnot exist.");
                    roleMenuMap.created_by = roleMenuMapDto.created_by;
                    roleMenuMap.created_date = DateTime.Now;
                    mappings.Add(roleMenuMap);
                }
                _unitOfWork.GetRepository<RoleMenuMap>().insertRange(mappings);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void saveOrUpdate(RoleMenuMapDto roleMenuMapDto)
        {
            try
            {
                _unitOfWork.begin();
                var maps = _roleMenuMapRepository.getByRole(roleMenuMapDto.role_id).ToList();
                deleteOldMaps(maps);
                save(roleMenuMapDto);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void saveOrUpdate(List<RoleMenuMapDto> roleMenuMapDtos)
        {
            try
            {
                _unitOfWork.begin();
                foreach (var roleMenuMapDto in roleMenuMapDtos)
                {
                    saveOrUpdate(roleMenuMapDto);
                }
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void update(RoleMenuMapDto roleMenuMapDto)
        {
            try
            {
                _unitOfWork.begin();
                var role = _roleRepository.getById(roleMenuMapDto.role_id) ?? throw new ItemNotFoundException($"Role with id {roleMenuMapDto.role_id} doesnot exist.");
                var previouslyMappedMenusForRole = _roleMenuMapRepository.getByRole(roleMenuMapDto.role_id);
                deleteOldMaps(previouslyMappedMenusForRole);
                save(roleMenuMapDto);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        private void deleteOldMaps(List<RoleMenuMap> maps)
        {
            _unitOfWork.GetRepository<RoleMenuMap>().deleteRange(maps);
        }
    }
}
