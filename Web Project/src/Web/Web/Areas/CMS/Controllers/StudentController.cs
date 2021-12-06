using AutoMapper;
using CMS.Entities;
using CMS.Service.Dto;
using CMS.Service.Repository.Interface;
using CMS.Service.Services.Interface;
using Core.Common.Dto;
using Microsoft.AspNetCore.Mvc;
using Project.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using UserManagement.Web.Areas.Administator.Controllers;
using Web.Areas.CMS.ViewModels;
using Web.FilterModel;
using Web.Helpers;
using Web.Pagination;

namespace Web.Areas.CMS.Controllers
{
    [Area("cms")]
    [Route("cms/student")]

    public class StudentController : BaseController
    {
        private readonly PaginatedMetaService _paginationService;
        private readonly IMapper _mapper;
        private readonly StudentRepository _studentRepository;
        private readonly StudentService _studentService;

        public StudentController(PaginatedMetaService paginationService, IMapper mapper,StudentRepository studentRepository, StudentService studentService)
        {
            _paginationService = paginationService;
            _mapper = mapper;
            _studentRepository = studentRepository;
            _studentService = studentService;
        }
        [Route("")]
        [Route("index")]
        public IActionResult Index(Filter filter)
        {
            var std = _studentRepository.getQueryable().Where(a => a.is_deleted == false);
            if (!string.IsNullOrWhiteSpace(filter.search_key))
            {
                std = std.Where(a => a.fullname.Contains(filter.search_key));
            }
            ViewBag.pagerInfo = _paginationService.GetMetaData(std.Count(), filter.page, filter.number_of_rows);
            std = std.OrderByDescending(a => a.Id).Skip(filter.number_of_rows * (filter.page - 1)).Take(filter.number_of_rows);

            var stdList = std.ToList();
            StudentIndexViewModel vm = getViewModelForIndex(stdList);
            return View(vm);
        }
        private StudentIndexViewModel getViewModelForIndex(List<Student> stdList)
        {
            StudentIndexViewModel vm = new StudentIndexViewModel();
            foreach (var link in stdList)
            {
                vm.studentDetails.Add(_mapper.Map<StudentDetails>(link));
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
        public IActionResult Create(StudentDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dto.created_by = getLoggedInUserId();
                    _studentService.save(dto);
                    AlertHelper.setMessage(this, "Student saved successfully.", messageType.success);
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
                var std = _studentRepository.getById(Id) ?? throw new ItemNotFoundException("student doesnot exist.");
                StudentDto dto = _mapper.Map<StudentDto>(std);
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
        public IActionResult Update(StudentDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dto.modified_by = getLoggedInUserId();
                    _studentService.update(dto);
                    AlertHelper.setMessage(this, "Student updated successfully.", messageType.success);
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
                _studentService.delete(dto);
                AlertHelper.setMessage(this, "Student deleted successfully.", messageType.success);
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
                dto.modified_by = getLoggedInUserId();
                dto.Id = Id;
                _studentService.enable(dto);
                AlertHelper.setMessage(this, "Student enabled successfully.", messageType.success);
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
                _studentService.disable(dto);
                AlertHelper.setMessage(this, "Student disabled successfully.", messageType.success);
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
