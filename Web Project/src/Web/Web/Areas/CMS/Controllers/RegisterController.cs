using AutoMapper;
using CMS.Entities;
using CMS.Service.Dto;
using CMS.Service.Repository.Interface;
using CMS.Service.Services.Interface;
using Core.Common.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.Web.Areas.Administator.Controllers;
using Web.Areas.CMS.ViewModels;
using Web.FilterModel;
using Web.Helpers;
using Web.Pagination;

namespace Web.Areas.CMS.Controllers
{
    [Area("cms")]
    [Route("cms/register")]
    public class RegisterController : BaseController
    {
        private readonly PaginatedMetaService _paginationService;
        private readonly IMapper _mapper;
        private readonly RegisterRepository _registerRepository;
        private readonly RegisterService _registerService;
        private readonly StudentRepository _studentRepository;
        private readonly SeminarRepository _seminarRepository;

        public RegisterController(PaginatedMetaService paginationService, IMapper mapper, RegisterRepository registerRepository, RegisterService registerService,StudentRepository studentRepository,SeminarRepository seminarRepository)
        {
            _paginationService = paginationService;
            _mapper = mapper;
            _registerRepository = registerRepository;
            _registerService = registerService;
            _studentRepository = studentRepository;
            _seminarRepository = seminarRepository;
        }
        [Route("")]
        [Route("index")]
        public IActionResult Index(Filter filter)
        {
            var reg = _registerRepository.getQueryable().Where(a => a.is_deleted == false);
            if (!string.IsNullOrWhiteSpace(filter.search_key))
            {
                reg = reg.Where(a => a.title.Contains(filter.search_key));
            }
            ViewBag.pagerInfo = _paginationService.GetMetaData(reg.Count(), filter.page, filter.number_of_rows);
            reg = reg.OrderByDescending(a => a.Id).Skip(filter.number_of_rows * (filter.page - 1)).Take(filter.number_of_rows);

            var regList = reg.ToList();
            RegisterIndexViewModel vm = getViewModelForIndex(regList);
            return View(vm);
        }

        private RegisterIndexViewModel getViewModelForIndex(List<Register> regList)
        {
            RegisterIndexViewModel vm = new RegisterIndexViewModel();
            foreach (var link in regList)
            {
                vm.registerDetails.Add(_mapper.Map<RegisterDetails>(link));
            }
            return vm;
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
            var student = _studentRepository.getQueryable().Where(a => !a.is_deleted && a.is_active).ToList();
            ViewBag.student = new SelectList(student, "Id", "fullname");

            var seminar = _seminarRepository.getQueryable().Where(a => !a.is_deleted && a.is_active).ToList();
            ViewBag.seminar = new SelectList(seminar, "Id", "title");
        }
        [HttpPost]
        [Route("create")]
        public IActionResult Create(RegisterDto dto)
        {
            getViewBagData();
            try
            {
                if (ModelState.IsValid)
                {
                    dto.created_by = getLoggedInUserId();
                    _registerService.save(dto);
                    AlertHelper.setMessage(this, "Registration saved successfully.", messageType.success);
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
            getViewBagData();
            try
            {
                var registration = _registerRepository.getById(Id) ?? throw new ItemNotFoundException("Registration doesnot exist.");
                RegisterDto dto = _mapper.Map<RegisterDto>(registration);
                return View(dto);
            }
            catch (Exception ex)
            {
                AlertHelper.setMessage(this, ex.Message, messageType.error);
                return RedirectToAction("index");
            }
        }

        [HttpPost]
        [Route("update")]
        public IActionResult Update(RegisterDto dto)
        {
            getViewBagData();
            try
            {
                if (ModelState.IsValid)
                {
                    dto.modified_by = getLoggedInUserId();
                    _registerService.update(dto);
                    AlertHelper.setMessage(this, "Registration updated successfully.", messageType.success);
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
        [Route("delete/{Id}")]
        public IActionResult Delete(long Id)
        {
            try
            {
                DeleteDto dto = new DeleteDto();
                dto.Id = Id;
                dto.modified_by = getLoggedInUserId();
                _registerService.delete(dto);
                AlertHelper.setMessage(this, "Registration deleted successfully.", messageType.success);
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
