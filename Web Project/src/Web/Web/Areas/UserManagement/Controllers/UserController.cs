using AutoMapper;
using Core.Common.Dto;
using Core.Common.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
    [Route("UserManagement/User")]
    public class UserController : BaseController
    {
        private readonly UserService _userService;
        private readonly IMapper _mapper;
        private readonly FileHelper _fileHelper;
        private readonly PaginatedMetaService _paginationService;
        private readonly RoleRepository _roleRepository;

        public UserController(UserService userService, IMapper mapper, FileHelper fileHelper,UserRepository userRepository,PaginatedMetaService paginationService,RoleRepository roleRepository)
        {
            _userService = userService;
            _mapper = mapper;
            _fileHelper = fileHelper;
            _userRepository = userRepository;
            _paginationService = paginationService;
            _roleRepository = roleRepository;
        }

        [Route("")]
        [Route("index")]
        public IActionResult Index(Filter filter)
        {
            var users = _userRepository.getQueryable().Where(a => a.is_deleted == false);
            if (!string.IsNullOrWhiteSpace(filter.search_key))
            {
                users = users.Where(a => a.UserDetails.getUserFullName().Contains(filter.search_key));
            }
            ViewBag.pagerInfo = _paginationService.GetMetaData(users.Count(), filter.page, filter.number_of_rows);
            users = users.OrderByDescending(a => a.Id).Skip(filter.number_of_rows * (filter.page - 1)).Take(filter.number_of_rows);

            var usersList = users.ToList();
            UserIndexViewModel vm = getViewModelForIndex(usersList);
            return View(vm);
        }

        private UserIndexViewModel getViewModelForIndex(List<User> usersList)
        {
            UserIndexViewModel vm = new UserIndexViewModel();
            foreach (var user in usersList)
            {
                vm.userDataDetails.Add(_mapper.Map<UserDataDetails>(user));
            }
            return vm;
        }

        [HttpGet]
        [Route("create")]
        public IActionResult Create()
        {
            ViewBag.roles =new SelectList(getAllRoles(),"Id","name");
            return View();
        }

        private List<Role> getAllRoles()
        {
            return _roleRepository.getQueryable().Where(a => !a.is_deleted && a.is_enabled == true).ToList();
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create(UserDto dto, IFormFile file = null)
        {
            ViewBag.roles = new SelectList(getAllRoles(), "Id", "name");
            try
            {
                if (ModelState.IsValid)
                {
                    if (file != null)
                    {
                        string fileName = dto.user_detail_dto.first_name;
                        dto.user_detail_dto.image = _fileHelper.saveImageAndGetFileName(file, fileName);
                    }
                    dto.created_by = getLoggedInUserId();
                    _userService.save(dto);
                    AlertHelper.setMessage(this, "User Created Successfully !!", messageType.success);
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
            ViewBag.roles = new SelectList(getAllRoles(), "Id", "name");
            try
            {
                var user = _userRepository.getById(Id);
                if (user == null)
                    throw new ItemNotFoundException("User Doesnot exist.");
                var userDto = _mapper.Map<UserDto>(user);
                userDto.user_detail_dto = _mapper.Map<UserDetailDto>(user.UserDetails);
                userDto.role_id = user.UserRoleMap.role_id;
                return View(userDto);
            }
            catch (Exception ex)
            {
                AlertHelper.setMessage(this, ex.Message, messageType.error);
                return RedirectToAction("index");
            }
        }

        [HttpPost]
        [Route("update")]
        public IActionResult Update(UserDto userDto, IFormFile file)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (file != null)
                    {
                        string fileName = userDto.user_detail_dto.first_name;
                        userDto.user_detail_dto.image = _fileHelper.saveImageAndGetFileName(file, fileName);
                    }
                    userDto.modified_by = getLoggedInUserId();
                    _userService.update(userDto,file);
                    AlertHelper.setMessage(this, "User updated successfully !!", messageType.success);
                    return RedirectToAction("index");
                }
               
            }
            catch (Exception ex)
            {
                AlertHelper.setMessage(this, ex.Message, messageType.error);
                return RedirectToAction("index");
            }
            return View(userDto);
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
                _userService.delete(dto);
                AlertHelper.setMessage(this, "User Deleted Successfully !!",messageType.success);
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
                _userService.enable(dto);
                AlertHelper.setMessage(this, "User Enabled Successfully !!",messageType.success);
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
                _userService.disable(dto);
                AlertHelper.setMessage(this, "User Disabled Successfully !!", messageType.success);
                return RedirectToAction("index");
            }
            catch (Exception ex)
            {
                AlertHelper.setMessage(this, ex.Message, messageType.error);
                return RedirectToAction("index");
            }
        }

        [HttpGet]
        [Route("change-password/{Id}")]
        public IActionResult ChangePassword(long Id)
        {
            try
            {
                ChangePasswordDto dto = new ChangePasswordDto();
                var user = _userRepository.getById(Id);
                if (user == null)
                    throw new ItemNotFoundException("User doesnot exist.");
                dto.user_id = Id;
                return View(dto);
            }
            catch (Exception ex)
            {
                AlertHelper.setMessage(this, ex.Message, messageType.error);
                return RedirectToAction("index");
            }
        }

        [HttpPost]
        [Route("change-password")]
        public IActionResult ChangePassword(ChangePasswordDto changePasswordDto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _userService.changePassword(changePasswordDto);
                    AlertHelper.setMessage(this, "Password changed successfully !!", messageType.success);
                    return RedirectToAction("index");
                }
            }
            catch (Exception ex)
            {
                AlertHelper.setMessage(this, ex.Message, messageType.error);
                return View();
            }
            return View(changePasswordDto);
        }

        [HttpGet]
        [Route("mark-email-registered/{Token}")]
        public IActionResult MarkEmailRegisterd(string Token)
        {
            try
            {
                _userService.markEmailRegistered(Token);
                AlertHelper.setMessage(this, "Email Has been Registered.", messageType.success);
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
