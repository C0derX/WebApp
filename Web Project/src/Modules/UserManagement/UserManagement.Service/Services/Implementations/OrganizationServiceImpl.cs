using Core.Common.Helpers;
using Core.Library.UnitOfWork;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UserManagement.Entities;
using UserManagement.Service.Assemblers.Interface;
using UserManagement.Service.Dto;
using UserManagement.Service.Repository.Interface;
using UserManagement.Service.Services.Interface;

namespace UserManagement.Service.Services.Implementations
{
    public class OrganizationServiceImpl : OrganizationService
    {
        private readonly OrganizationRepository _organizationRepository;
        private readonly OrganizationAssembler _organizationAssembler;
        private readonly UnitOfWork _unitOfWork;
        private readonly FileHelper _fileHelper;

        public OrganizationServiceImpl(OrganizationRepository organizationRepository,OrganizationAssembler organizationAssembler,UnitOfWork unitOfWork,FileHelper fileHelper)
        {
            _organizationRepository = organizationRepository;
            _organizationAssembler = organizationAssembler;
            _unitOfWork = unitOfWork;
            _fileHelper = fileHelper;
        }
        public void saveOrUpdate(OrganizationDto organizationDto,IFormFile file=null)
        {
            
                var organizationdata = _organizationRepository.getAll().FirstOrDefault();
                if (organizationdata == null)
                    save(organizationDto,file);
                else
                    update(organizationDto, organizationdata,file);
           
        }

        private void update(OrganizationDto organizationDto,Organization organizationdata,IFormFile file)
        {
            try
            {
                if (file != null)
                {
                    if (!string.IsNullOrWhiteSpace(organizationdata.logo))
                    {
                        deleteImage(organizationdata.logo);
                    }
                    organizationDto.logo = _fileHelper.saveImageAndGetFileName(file, organizationDto.organization_name);
                }

                _unitOfWork.begin();
                _organizationAssembler.copy(organizationdata, organizationDto);
                organizationdata.modified_by =organizationDto.modified_by;
                organizationdata.modified_date = DateTime.Now;
                _unitOfWork.GetRepository<Organization>().update(organizationdata);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        private void save(OrganizationDto organizationDto,IFormFile file)
        {
            try
            {
                _unitOfWork.begin();
                Organization organization = new Organization();
                if (file != null)
                {
                    string filePrefix = organizationDto.organization_name;

                    organization.logo = _fileHelper.saveFileAndGetFileName(file, filePrefix);
                }
                _organizationAssembler.copy(organization, organizationDto);
                organization.created_by = organizationDto.created_by;
                organization.created_date = DateTime.Now;
                _unitOfWork.GetRepository<Organization>().insert(organization);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
           
        }
        private void deleteImage(string iMAGE_PATH)
        {
            _fileHelper.deleteImage(iMAGE_PATH, _fileHelper.getPathToImageFolder());
        }
    }
}
