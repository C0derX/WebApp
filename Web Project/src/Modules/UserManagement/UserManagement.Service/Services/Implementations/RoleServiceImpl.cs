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
    public class RoleServiceImpl : RoleService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly RoleRepository _roleRepository;
        private readonly RoleAssembler _roleAssembler;
        private readonly RoleMenuMapService _roleMenuMapService;
        private readonly RolePermissionMapService _rolePermissionMapService;

        public RoleServiceImpl(UnitOfWork unitOfWork, RoleRepository roleRepository, RoleAssembler roleAssembler, RoleMenuMapService roleMenuMapService,RolePermissionMapService rolePermissionMapService)
        {
            _unitOfWork = unitOfWork;
            _roleRepository = roleRepository;
            _roleAssembler = roleAssembler;
            _roleMenuMapService = roleMenuMapService;
            _rolePermissionMapService = rolePermissionMapService;
        }
        public void delete(DeleteDto deleteDto)
        {
            try
            {
                _unitOfWork.begin();
                var role = _roleRepository.getById(deleteDto.Id) ?? throw new ItemNotFoundException($"Role with Id {deleteDto.Id} doesnot exist.");
                var isUserPresentForSpecifiedRole = _roleRepository.getById(deleteDto.Id).hasUsersAssigned();
                if (isUserPresentForSpecifiedRole)
                    throw new ItemUsedException("Specified Role is already assigned to Users. You cannot delete at this moment.");
                role.delete();
                role.modified_by = deleteDto.modified_by;
                role.modified_date = DateTime.Now;
                _unitOfWork.GetRepository<Role>().update(role);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void disable(ModificationDto modificationDto)
        {
            try
            {
                _unitOfWork.begin();
                var role = _roleRepository.getById(modificationDto.Id) ?? throw new ItemNotFoundException($"Role with Id {modificationDto.Id} doesnot exist.");
                role.disable();
                role.modified_by = modificationDto.modified_by;
                role.modified_date = DateTime.Now;
                _unitOfWork.GetRepository<Role>().update(role);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void enable(ModificationDto modificationDto)
        {
            try
            {
                _unitOfWork.begin();
                var role = _roleRepository.getById(modificationDto.Id) ?? throw new ItemNotFoundException($"Role with Id {modificationDto.Id} doesnot exist.");
                role.enable();
                role.modified_by = modificationDto.modified_by;
                role.modified_date = DateTime.Now;
                _unitOfWork.GetRepository<Role>().update(role);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void save(RoleDto roleDto)
        {
            try
            {
                _unitOfWork.begin();
                bool isNameAllowed = isRoleNameAllowed(roleDto);
                if (!isNameAllowed)
                    throw new ItemUsedException("Role with specified name already exist.Please try another name.");
                Role role = new Role();
                _roleAssembler.copy(role, roleDto);
                role.created_by = roleDto.created_by;
                role.created_date = DateTime.Now;
                _unitOfWork.GetRepository<Role>().insert(role);
                roleDto.Id = role.Id;
                saveRoleMenuMaps(roleDto);
                saveRolePermissionMaps(roleDto);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        private void saveRolePermissionMaps(RoleDto roleDto)
        {
            RolePermissionMapDto dto = new RolePermissionMapDto();
            dto.role_id = roleDto.Id;
            dto.permissions = roleDto.permissions;
            dto.created_by = roleDto.created_by;
            dto.modified_by = roleDto.created_by;
            _rolePermissionMapService.saveOrUpdate(dto);
        }

        private void saveRoleMenuMaps(RoleDto roleDto)
        {
            RoleMenuMapDto roleMenuMapDto = new RoleMenuMapDto()
            {
                role_id = roleDto.Id,
                menu_ids = roleDto.menu_ids,
                created_by = roleDto.created_by
            };
            _roleMenuMapService.save(roleMenuMapDto);
        }

        private bool isRoleNameAllowed(RoleDto roleDto)
        {
            var roleWithSameName = _roleRepository.getByName(roleDto.name);
            bool roleWithSameNameDoesnotExist = roleWithSameName == null;
            bool roleWithSameNameIsSameAsDto = false;
            if (roleWithSameName != null)
            {
                roleWithSameNameIsSameAsDto = roleWithSameName.Id == roleDto.Id;
            }
            return roleWithSameNameDoesnotExist || roleWithSameNameIsSameAsDto;
        }

        public void update(RoleDto roleDto)
        {
            try
            {
                _unitOfWork.begin();
                var role = _roleRepository.getById(roleDto.Id) ?? throw new ItemNotFoundException($"Role with Id {roleDto.Id} doesnot exist.");
                bool isNameAllowed = isRoleNameAllowed(roleDto);
                if (!isNameAllowed)
                    throw new DuplicateItemException("Role with specified name is already used.Please try another name");
                _roleAssembler.copy(role, roleDto);
                role.modified_by = roleDto.modified_by;
                role.modified_date = DateTime.Now;
                _unitOfWork.GetRepository<Role>().update(role);
                roleDto.Id = role.Id;
                saveRolePermissionMaps(roleDto);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }
    }
}
