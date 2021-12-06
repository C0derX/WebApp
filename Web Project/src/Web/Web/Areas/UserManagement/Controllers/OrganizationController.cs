using AutoMapper;
using Core.Common.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using UserManagement.Service.Dto;
using UserManagement.Service.Repository.Interface;
using UserManagement.Service.Services.Interface;
using UserManagement.Web.Areas.Administator.Controllers;
using Web.Areas.UserManagement.Models;
using Web.Helpers;

namespace Web.Areas.UserManagement.Controllers
{
    [Authorize(Policy = nameof(UserTypeClaims.organisationAdminPolicy))]
    [Area("UserManagement")]
    [Route("UserManagement/Organization")]
    public class OrganizationController : BaseController
    {
        private readonly OrganizationService _organizationService;
        private readonly OrganizationRepository _organizationRepository;
        private readonly IMapper _mapper;
        private readonly FileHelper _fileHelper;
        private readonly OrganizationModuleMapService _orgModuleMapService;
        private readonly OrganizationModuleMapRepository _orgModuleMapRepository;

        public OrganizationController(OrganizationService organizationService, OrganizationRepository organizationRepository, IMapper mapper, FileHelper fileHelper,OrganizationModuleMapService organizationModuleMapService,OrganizationModuleMapRepository organizationModuleMapRepository, ModuleRepository moduleRepository)
        {
            _organizationService = organizationService;
            _organizationRepository = organizationRepository;
            _mapper = mapper;
            _fileHelper = fileHelper;
            _orgModuleMapService = organizationModuleMapService;
            _orgModuleMapRepository = organizationModuleMapRepository;
            _moduleRepository = moduleRepository;
        }

        [HttpGet]
        [Route("create")]
        public IActionResult Create()
        {
            var organization = _organizationRepository.getAll().FirstOrDefault();
            var organizationDto = _mapper.Map<OrganizationDto>(organization);
            return View(organizationDto);
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create(OrganizationDto dto, IFormFile file)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dto.created_by = getLoggedInUserId();
                    dto.modified_by = getLoggedInUserId();
                    _organizationService.saveOrUpdate(dto,file);
                    return Redirect("/administrator");
                }
            }
            catch (Exception ex)
            {
                AlertHelper.setMessage(this, ex.Message, messageType.error);
                return RedirectToAction("create");
            }
            return View(dto);
        }

        [HttpGet]
        [Route("assign-module/{organization_id}")]
        public IActionResult AssignModule(long organization_id)
        {
            OrganizationModuleMapModel model = new OrganizationModuleMapModel();
            try
            {
                var organization = _organizationRepository.getById(organization_id) ?? throw new ItemNotFoundException("Organization Id not found.");
                var modules = _moduleRepository.getQueryable().Where(a => a.is_deleted == false).ToList();
                var assignedModules = _orgModuleMapRepository.getQueryable().Where(a => a.organization_id == organization_id).ToList();

                model.organizationModuleMaps = assignedModules;
                model.modules = modules;
                model.organization = organization;
                model.organization_id = organization_id;

            }
            catch (Exception ex)
            {
                AlertHelper.setMessage(this, ex.Message, messageType.error);
                return Redirect("/administrator");
            }
           
            return View(model);
        }

        [HttpPost]
        [Route("assign-module")]
        public IActionResult AssignModule(OrganizationModuleMapModel model)
        {
            try
            {
                List<OrganizationModuleMapDto> orgModuleMapDto = getDtoFromModel(model);
                _orgModuleMapService.saveOrUpdate(model.organization_id,orgModuleMapDto);
                return Redirect("/UserManagement/organization/assign-module/"+model.organization_id);
            }
            catch (Exception ex)
            {
                AlertHelper.setMessage(this, ex.Message, messageType.error);
                return Redirect("/UserManagement/organization/assign-module/" + model.organization_id);
            }
        }

        private List<OrganizationModuleMapDto> getDtoFromModel(OrganizationModuleMapModel model)
        {
            List<OrganizationModuleMapDto> dtos = new List<OrganizationModuleMapDto>();
            foreach (var item in model.module_ids)
            {
                OrganizationModuleMapDto map = new OrganizationModuleMapDto();
                map.module_id = item;
                map.organization_id = model.organization_id;
                map.created_by = getLoggedInUserId();
                dtos.Add(map);
            }
            return dtos;
        }
    }
}
