using AutoMapper;
using Core.Common.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using UserManagement.Entities;
using UserManagement.Service.Dto;
using UserManagement.Service.Repository.Interface;
using UserManagement.Service.Services.Interface;
using UserManagement.Web.Areas.Administator.Controllers;
using Web.Areas.UserManagement.Models;
using Web.Areas.UserManagement.ViewModels;
using Web.FilterModel;
using Web.Helpers;
using Web.Pagination;

namespace Web.Areas.UserManagement.Controllers
{
    [Authorize(Policy = nameof(UserTypeClaims.organisationAdminPolicy))]
    [Area("UserManagement")]
    [Route("UserManagement/Module")]
    public class ModuleController : BaseController
    {
        private readonly ModuleService _moduleService;
        private readonly PaginatedMetaService _paginationService;
        private readonly IMapper _mapper;

        public ModuleController(ModuleService moduleService, PaginatedMetaService paginationService,ModuleRepository moduleRepository,IMapper mapper)
        {
            _moduleService = moduleService;
            _paginationService = paginationService;
            _moduleRepository = moduleRepository;
            _mapper = mapper;
        }

        [Route("")]
        [Route("index")]
        public IActionResult Index(Filter filter)
        {
            var modules = _moduleRepository.getQueryable().Where(a => a.is_deleted ==false);
            if (!string.IsNullOrWhiteSpace(filter.search_key))
            {
                modules = modules.Where(a => a.name.Contains(filter.search_key));
            }
            ViewBag.pagerInfo = _paginationService.GetMetaData(modules.Count(), filter.page, filter.number_of_rows);
            modules = modules.OrderByDescending(a => a.Id).Skip(filter.number_of_rows * (filter.page - 1)).Take(filter.number_of_rows);

            var modulesList = modules.ToList();
            ModuleIndexViewModel vm = getViewModelForIndex(modulesList);
            return View(vm);
        }

        [HttpGet]
        [Route("create")]
        public IActionResult create()
        {
            return View();
        }

        [HttpPost]
        [Route("create")]
        public IActionResult create(ModuleDto moduleDto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    moduleDto.created_by = getLoggedInUserId();
                    _moduleService.save(moduleDto);
                    AlertHelper.setMessage(this, "Module saved successfully.", messageType.success);
                    return RedirectToAction("index");

                }
            }
            catch (Exception ex)
            {
                AlertHelper.setMessage(this, ex.Message, messageType.error);
                return RedirectToAction("index");
            }
            return View(moduleDto);
        }

        [HttpGet]
        [Route("delete/{Id}")]
        public IActionResult Delete(long Id)
        {
            try
            {
                DeleteDto dto = new DeleteDto();
                dto.Id = Id;
                dto.modified_by = getLoggedInUserId();
                _moduleService.delete(dto);
                AlertHelper.setMessage(this, "Module Deleted Successfully!!", messageType.success);
                return RedirectToAction("index");
            }
            catch (Exception ex)
            {
                AlertHelper.setMessage(this, ex.Message, messageType.error);
                return RedirectToAction("index");
            }
        }

        [HttpGet]
        [Route("update/{Id}")]
        public IActionResult update(long Id)
        {
            try
            {
                var module = _moduleRepository.getById(Id);
                if (module == null)
                    throw new ItemNotFoundException("Module not found.");
                var moduleDto = _mapper.Map<ModuleDto>(module);
                return View(moduleDto);
            }
            catch (Exception ex)
            {
                AlertHelper.setMessage(this, ex.Message, messageType.error);
                return RedirectToAction("index");
            }
          
        }

        [HttpPost]
        [Route("update")]
        public IActionResult update(ModuleDto moduleDto)
        {
            try
            {
                _moduleService.update(moduleDto);
                AlertHelper.setMessage(this, "Module updated successfully!!", messageType.success);
                return RedirectToAction("index");
            }
            catch (Exception ex)
            {
                AlertHelper.setMessage(this, ex.Message, messageType.error);
                return RedirectToAction("index");
            }
        }

        private ModuleIndexViewModel getViewModelForIndex(List<Modules> modulesList)
        {
            ModuleIndexViewModel vm = new ModuleIndexViewModel();
            foreach (var list in modulesList)
            {
                vm.moduleDetails.Add(_mapper.Map<ModuleDetails>(list));
            }
            return vm;
        }
    }
}
