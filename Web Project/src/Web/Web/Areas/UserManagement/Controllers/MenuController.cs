using AutoMapper;
using Core.Common.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    [Route("UserManagement/Menu")]
    public class MenuController : BaseController
    {
        private readonly MenuService _menuService;
        private readonly IMapper _mapper;
        private readonly PaginatedMetaService _paginationService;

        public MenuController(MenuService menuService, MenuRepository menuRepository, IMapper mapper, PaginatedMetaService paginationService, ModuleRepository moduleRepository)
        {
            _menuService = menuService;
            _menuRepository = menuRepository;
            _moduleRepository = moduleRepository;
            _mapper = mapper;
            _paginationService = paginationService;
        }

        [Route("")]
        [Route("index")]
        public IActionResult Index(Filter filter)
        {
            var menus = _menuRepository.getQueryable().Where(a => a.is_deleted == false);
            if (!string.IsNullOrWhiteSpace(filter.search_key))
            {
                menus = menus.Where(a => a.name.Contains(filter.search_key));
            }
            ViewBag.pagerInfo = _paginationService.GetMetaData(menus.Count(), filter.page, filter.number_of_rows);
            menus = menus.OrderByDescending(a => a.Id).Skip(filter.number_of_rows * (filter.page - 1)).Take(filter.number_of_rows);

            var menuList = menus.ToList();
            MenuIndexViewModel vm = getViewModelForIndex(menuList);
            return View(vm);
        }

        [HttpGet]
        [Route("create")]
        public IActionResult Create()
        {
            getViewBagData();
            return View();
        }

        private void getViewBagData()
        {
            var modules = _moduleRepository.getQueryable().Where(a => a.is_deleted == false).ToList();
            ViewBag.moduleList = new SelectList(modules, "Id", "name");

            var parentMenus = _menuRepository.getQueryable().Where(a =>!a.is_deleted && a.is_visible_to_menu).ToList();
            ViewBag.parentMenuList = new SelectList(parentMenus, "Id", "name");
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create(MenuDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dto.created_by = getLoggedInUserId();
                    _menuService.save(dto);
                    AlertHelper.setMessage(this, "Menu added successfully!!", messageType.success);
                    return RedirectToAction("index");
                }

            }
            catch (Exception ex)
            {
                AlertHelper.setMessage(this, ex.Message, messageType.error);
                return RedirectToAction("index");
            }
            getViewBagData();
            return View(dto);
        }

        [HttpGet]
        [Route("update/{Id}")]
        public IActionResult Update(long Id)
        {
            getViewBagData();
            try
            {
                var menu = _menuRepository.getById(Id);
                if (menu == null)
                    throw new ItemNotFoundException("Menu doesnot exist.");
                var menuDto = _mapper.Map<MenuDto>(menu);
                menuDto.permissions = menu.MenuPermissionMap.getPermissions();
                return View(menuDto);
            }
            catch (Exception ex)
            {
                AlertHelper.setMessage(this, ex.Message, messageType.error);
                return RedirectToAction("index");
            }
        }

        [HttpPost]
        [Route("update")]
        public IActionResult Update(MenuDto dto)
        {
            try
            {
                dto.modified_by = getLoggedInUserId();
                _menuService.update(dto);
                AlertHelper.setMessage(this, "Menu updated successfully!!");
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
                _menuService.delete(dto);
                AlertHelper.setMessage(this, "Menu Deleted Successfully!!");
                return RedirectToAction("index");
            }
            catch (Exception ex)
            {
                AlertHelper.setMessage(this, ex.Message, messageType.error);
                return RedirectToAction("index");
            }
        }

        [HttpGet]
        [Route("enable/{Id}")]
        public IActionResult Enable(long Id)
        {
            try
            {
                ModificationDto dto = new ModificationDto();
                dto.Id = Id;
                dto.modified_by = getLoggedInUserId();
                _menuService.enable(dto);
                AlertHelper.setMessage(this, "Menu enabled successfully!!");
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
                dto.Id = Id;
                dto.modified_by = getLoggedInUserId();
                _menuService.disable(dto);
                AlertHelper.setMessage(this, "Menu disabled successfully!!");
                return RedirectToAction("index");
            }
            catch (Exception ex)
            {
                AlertHelper.setMessage(this, ex.Message, messageType.error);
                return RedirectToAction("index");
            }
        }

        private MenuIndexViewModel getViewModelForIndex(List<Menu> menuList)
        {
            MenuIndexViewModel vm = new MenuIndexViewModel();
            foreach (var list in menuList)
            {
                vm.menuDetails.Add(_mapper.Map<MenuDetails>(list));
            }
            return vm;
        }


    }
}
