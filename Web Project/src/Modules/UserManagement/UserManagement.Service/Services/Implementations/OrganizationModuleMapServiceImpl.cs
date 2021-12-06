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
    public class OrganizationModuleMapServiceImpl :OrganizationModuleMapService
    {
        private readonly OrganizationModuleMapRepository _organizationModuleMapRepository;
        private readonly UnitOfWork _unitOfWork;
        private readonly OrganizationRepository _organizationRepository;

        public OrganizationModuleMapServiceImpl(OrganizationModuleMapRepository organizationModuleMapRepository, UnitOfWork unitOfWork,OrganizationRepository organizationRepository)
        {
            _organizationModuleMapRepository = organizationModuleMapRepository;
            _unitOfWork = unitOfWork;
            _organizationRepository = organizationRepository;
        }
        public void delete(DeleteDto dto)
        {
            try
            {
                _unitOfWork.begin();
                var orgModuleMap = _organizationModuleMapRepository.getById(dto.Id);
                if (orgModuleMap == null) 
                    throw new ItemNotFoundException("Organization Module Map not found.");
                orgModuleMap.modified_by = dto.modified_by;
                orgModuleMap.modified_date = DateTime.Now;
                _unitOfWork.GetRepository<OrganizationModuleMap>().delete(orgModuleMap);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void saveOrUpdate(OrganizationModuleMapDto organizationModuleMapDto)
        {
            try
            {
                _unitOfWork.begin();

                OrganizationModuleMap organizationModuleMap = assembleModuleMapDtoToEntity(organizationModuleMapDto);
                organizationModuleMap.created_by = organizationModuleMapDto.created_by;
                organizationModuleMap.created_date = DateTime.Now;
                _unitOfWork.GetRepository<OrganizationModuleMap>().insert(organizationModuleMap);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        private void deleteOldMaps(long orgId)
        {
            var oldMaps = _organizationModuleMapRepository.getQueryable().Where(a => a.organization_id ==orgId).ToList();
            _unitOfWork.GetRepository<OrganizationModuleMap>().deleteRange(oldMaps);
        }

        private OrganizationModuleMap assembleModuleMapDtoToEntity(OrganizationModuleMapDto organizationModuleMapDto)
        {
            OrganizationModuleMap orgModuleMap = new OrganizationModuleMap();
            orgModuleMap.module_id = organizationModuleMapDto.module_id;
            orgModuleMap.organization_id = organizationModuleMapDto.organization_id;
           
            return orgModuleMap;
        }

        public void update(OrganizationModuleMapDto organizationModuleMapDto)
        {
            try
            {
                _unitOfWork.begin();
                var orgModuleMap = _organizationModuleMapRepository.getById(organizationModuleMapDto.Id);
                if (orgModuleMap == null)
                    throw new ItemNotFoundException("Module to Organization not found.");
                orgModuleMap = assembleModuleMapDtoToEntity(organizationModuleMapDto);
                orgModuleMap.modified_by = organizationModuleMapDto.modified_by;
                orgModuleMap.modified_date = DateTime.Now;
                _unitOfWork.GetRepository<OrganizationModuleMap>().update(orgModuleMap);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void saveOrUpdate(long orgId,List<OrganizationModuleMapDto> organizationModuleMapDtos)
        {
            try
            {
                _unitOfWork.begin();
                var orgDetails = _organizationRepository.getById(orgId);
                if (orgDetails == null)
                    throw new ItemNotFoundException("Invalid Organization Id.");

                deleteOldMaps(orgId);
                foreach (var moduleMapDto in organizationModuleMapDtos)
                {
                    saveOrUpdate(moduleMapDto);
                }
               
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
