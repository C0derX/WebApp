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
    public sealed class UserRoleMapServiceImpl : UserRoleMapService
    {
        private readonly UserRoleMapRepository _userRoleMapRepo;
        private readonly UserRepository _userRepo;
        private readonly RoleRepository _roleRepo;
        private readonly UnitOfWork _unitOfWork;

        public UserRoleMapServiceImpl(UserRoleMapRepository userRoleMapRepo, UserRepository userRepo, RoleRepository roleRepo, UnitOfWork unitOfWork)
        {
            _userRoleMapRepo = userRoleMapRepo;
            _userRepo = userRepo;
            _roleRepo = roleRepo;
            _unitOfWork = unitOfWork;
        }

        public void save(UserRoleMapDto dto)
        {
            try
            {
                _unitOfWork.begin();
                long distinctRoleIds = dto.role_id;
                int countOfUserAndRole = _userRoleMapRepo.getQueryable().Where(a=>a.user_id == dto.user_id).Count();
                if (countOfUserAndRole > 0)
                {
                    throw new DuplicateItemException("User role map for specified user and role already exists.");
                }
                User user = _userRepo.getById(dto.user_id) ?? throw new ItemNotFoundException($"User with id {dto.user_id} doesnot exist.");

                UserRoleMap entity = new UserRoleMap();
                entity.user_id = dto.user_id;
                entity.role_id = dto.role_id;
                entity.created_by = dto.created_by;

                _unitOfWork.GetRepository<UserRoleMap>().insert(entity);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void update(UserRoleMapDto dto)
        {
            try
            {
                _unitOfWork.begin();
                var user = _userRepo.getById(dto.user_id) ?? throw new ItemNotFoundException($"User with id {dto.user_id} doesnot exist.");
                var userRolemap = _userRoleMapRepo.getQueryable().Where(a => a.user_id == dto.user_id).SingleOrDefault();
                userRolemap.modified_by = dto.modified_by;
                userRolemap.role_id = dto.role_id;
                _unitOfWork.GetRepository<UserRoleMap>().update(userRolemap);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void delete(DeleteDto dto)
        {
            try
            {
                _unitOfWork.begin();
                var userRoleMap = _userRoleMapRepo.getById(dto.Id) ?? throw new ItemNotFoundException($"User role map with id {dto.Id} doesnot exist.");
                userRoleMap.delete();
                userRoleMap.modified_by = dto.modified_by;
                userRoleMap.modified_date = DateTime.Now;
                _unitOfWork.GetRepository<UserRoleMap>().update(userRoleMap);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void saveOrUpdate(List<UserRoleMapDto> dtos)
        {
            try
            {
                _unitOfWork.begin();
                foreach (var dto in dtos)
                {
                    saveOrUpdate(dto);
                }
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void saveOrUpdate(UserRoleMapDto dto)
        {
            try
            {
                _unitOfWork.begin();
                var maps = _userRoleMapRepo.getByUser(dto.user_id);
                deletePreviouslyAssignedMaps(maps);
                save(dto);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        private void deletePreviouslyAssignedMaps(List<UserRoleMap> previouslyMappedRolesForUser)
        {
            _unitOfWork.GetRepository<UserRoleMap>().deleteRange(previouslyMappedRolesForUser);
        }
    }
}
