using Core.Library.UnitOfWork;
using Project.Exceptions;
using System;
using System.Linq;
using UserManagement.Entities;
using UserManagement.Service.Dto;
using UserManagement.Service.Services.Interface;

namespace UserManagement.Service.Services.Implementations
{
    public class RolePermissionMapServiceImpl : RolePermissionMapService
    {
        private readonly UnitOfWork _unitOfWork;

        public RolePermissionMapServiceImpl(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void saveOrUpdate(RolePermissionMapDto dto)
        {
            try
            {
                if (dto == null)
                {
                    return;
                }
                _unitOfWork.begin();
                long roleId = dto.role_id;

                deleteOldPermissions(roleId,dto.created_by);

                var roles = _unitOfWork.GetRepository<Role>().Get(a =>a.Id==roleId).SingleOrDefault();

                        RolePermissionMap entity = new RolePermissionMap();
                        entity.role_id = roleId;
                        entity.Role = roles ?? throw new ItemNotFoundException($"Role with id {roleId} doesnot exist.");
                        entity.created_by = dto.created_by;
                        entity.created_date = DateTime.Now;
                        entity.setPermissions(dto.permissions);
                                    
                _unitOfWork.GetRepository<RolePermissionMap>().insert(entity);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        private void deleteOldPermissions(long roleId,long createdBy)
        {
            var savedPermissionsOfUsers = _unitOfWork.GetRepository<RolePermissionMap>().Get(a => a.role_id == roleId).SingleOrDefault();
            if (savedPermissionsOfUsers != null)
            {
                savedPermissionsOfUsers.delete();
                savedPermissionsOfUsers.modified_by = createdBy;
                savedPermissionsOfUsers.modified_date = DateTime.Now;
                _unitOfWork.GetRepository<RolePermissionMap>().update(savedPermissionsOfUsers);
            }
           
        }
    }
}
