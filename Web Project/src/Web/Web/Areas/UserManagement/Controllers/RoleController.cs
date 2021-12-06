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
    //[Authorize(Policy = nameof(UserTypeClaims.organisationAdminPolicy))]
    [Authorize]
    [Area("UserManagement")]
    [Route("UserManagement/Role")]
    public class RoleController : BaseController
    {
        private readonly RoleService _roleService;
        private readonly RoleRepository _roleRepository;
        private readonly IMapper _mapper;
        private readonly PaginatedMetaService _paginationService;
        private readonly RoleMenuMapService _roleMenuMapService;

        public RoleController(RoleService roleService, RoleRepository roleRepository, IMapper mapper, PaginatedMetaService paginationService,ModuleRepository moduleRepository,RoleMenuMapRepository roleMenuMapRepository,RoleMenuMapService roleMenuMapService)
        {
            _roleService = roleService;
            _roleRepository = roleRepository;
            _mapper = mapper;
            _paginationService = paginationService;
            _moduleRepository = moduleRepository;
            _roleMenuMapRepository = roleMenuMapRepository;
            _roleMenuMapService = roleMenuMapService;
        }

        [Route("")]
        [Route("index")]
        public IActionResult Index(Filter filter)
        {
            var roles = _roleRepository.getQueryable().Where(a => a.is_deleted == false);
            if (!string.IsNullOrWhiteSpace(filter.search_key))
            {
                roles = roles.Where(a => a.name.Contains(filter.search_key));
            }
            ViewBag.pagerInfo = _paginationService.GetMetaData(roles.Count(), filter.page, filter.number_of_rows);
            roles = roles.OrderByDescending(a => a.Id).Skip(filter.number_of_rows * (filter.page - 1)).Take(filter.number_of_rows);

            var rolesList = roles.ToList();
            RoleIndexViewModel vm = getViewModelForIndex(rolesList);
            return View(vm);
        }

        private RoleIndexViewModel getViewModelForIndex(List<Role> rolesList)
        {
            RoleIndexViewModel vm = new RoleIndexViewModel();
            foreach (var role in rolesList)
            {
                var roleDetails = _mapper.Map<RoleDetails>(role);
                if(role.RolePermissionMap!=null)
                roleDetails.permissions = role.RolePermissionMap.getPermissions();
                vm.roleDetails.Add(roleDetails);
            }
            return vm;
        }

        [HttpGet]
        [Route("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create(RoleDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dto.created_by = getLoggedInUserId();
                    _roleService.save(dto);
                    AlertHelper.setMessage(this, "Role created successfully!!", messageType.success);
                    return RedirectToAction("index");
                }

            }
            catch (Exception ex)
            {
                AlertHelper.setMessage(this, ex.Message, messageType.error);
                return RedirectToAction("index");
            }
            return View(dto);
        }

        [HttpGet]
        [Route("update/{Id}")]
        public IActionResult Update(long Id)
        {
            try
            {
                var role = _roleRepository.getById(Id);
                if (role == null)
                    throw new ItemNotFoundException("Role doesnot exist.");
                var roleDto = _mapper.Map<RoleDto>(role);
                roleDto.permissions = role.RolePermissionMap.getPermissions();
                return View(roleDto);
            }
            catch (Exception ex)
            {
                AlertHelper.setMessage(this, ex.Message, messageType.error);
                return RedirectToAction("index");
            }

        }

        [HttpPost]
        [Route("update")]
        public IActionResult Update(RoleDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dto.modified_by = getLoggedInUserId();
                    _roleService.update(dto);
                    AlertHelper.setMessage(this, "Role updated successfully!!", messageType.success);
                    return RedirectToAction("index");
                }
           
            }
            catch (Exception ex)
            {
                AlertHelper.setMessage(this, ex.Message, messageType.error);
                return RedirectToAction("index");
            }
            return View(dto);
        }

        [HttpGet]
        [Route("enable/{Id}")]
        public IActionResult Enable(long Id)
        {
            try
            {
                ModificationDto dto = new ModificationDto();
                dto.modified_by = getLoggedInUserId();
                dto.Id = Id;
                _roleService.enable(dto);
                AlertHelper.setMessage(this, "Role Enabled successfully !!", messageType.success);
                return RedirectToAction("index");
            }
            catch (Exception ex)
            {
                AlertHelper.setMessage(this, ex.Message, messageType.error);
                return RedirectToAction("index");
            }
        }

        [HttpGet]
        [Route("disable/{Id}")]
        public IActionResult Disable(long Id)
        {
            try
            {
                ModificationDto dto = new ModificationDto();
                dto.modified_by = getLoggedInUserId();
                dto.Id = Id;
                _roleService.disable(dto);
                AlertHelper.setMessage(this, "Role Disabled successfully !!", messageType.success);
                return RedirectToAction("index");
            }
            catch (Exception ex)
            {
                AlertHelper.setMessage(this, ex.Message, messageType.error);
                return RedirectToAction("index");
            }
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
                _roleService.delete(dto);
                AlertHelper.setMessage(this, "Role Deleted successfully !!", messageType.success);
                return RedirectToAction("index");
            }
            catch (Exception ex)
            {
                AlertHelper.setMessage(this, ex.Message, messageType.error);
                return RedirectToAction("index");
            }
        }

        [HttpGet]
        [Route("assign-role-menu/{Id}")]
        public IActionResult AssignRoleMenu(long Id)
        {
            try
            {
                RoleMenuModel model = new RoleMenuModel();
                var role = _roleRepository.getById(Id);
                if (role == null)
                    throw new ItemNotFoundException("Role is invalid.");
                var modules = _moduleRepository.getQueryable().Where(a => !a.is_deleted).ToList();

                var assignedMenus = _roleMenuMapRepository.getByRole(role.Id);
                model.roleMenuMaps = assignedMenus;
                model.modules = modules;
                model.role_id = role.Id;
                return View(model);
            }
            catch (Exception ex)
            {
                AlertHelper.setMessage(this, ex.Message, messageType.error);
                return RedirectToAction("index");
            }
            
        }

        [HttpPost]
        [Route("assign-role-menu")]
        public IActionResult AssignRoleMenu(RoleMenuModel roleMenuModel)
        {
            try
            {
                var dto = _mapper.Map<RoleMenuMapDto>(roleMenuModel);
                dto.created_by = getLoggedInUserId();
                _roleMenuMapService.saveOrUpdate(dto);
                AlertHelper.setMessage(this, "Menus Has been assigned to roles successfully !!",messageType.success);
                return RedirectToAction("index");
            }
            catch (Exception ex)
            {
                AlertHelper.setMessage(this, ex.Message, messageType.error);
                return RedirectToAction("index");
            }
        }
    }
}
