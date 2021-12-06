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
using UserManagement.Web.Areas.Administator.Controllers;
using Web.Areas.CMS.ViewModels;
using Web.FilterModel;
using Web.Helpers;
using Web.Pagination;

namespace Web.Areas.CMS.Controllers
{
    [Area("cms")]
    [Route("cms/seminar")]

    public class SeminarController : BaseController
    {
        private readonly PaginatedMetaService _paginationService;
        private readonly IMapper _mapper;
        private readonly SeminarRepository _seminarRepository;
        private readonly SeminarService _seminarService;
        private readonly OrganizerRepository _organizerRepository;

        public SeminarController(PaginatedMetaService paginationService, IMapper mapper, SeminarRepository seminarRepository, SeminarService seminarService,OrganizerRepository organizerRepository)
        {
            _paginationService = paginationService;
            _mapper = mapper;
            _seminarRepository = seminarRepository;
            _seminarService = seminarService;
            _organizerRepository = organizerRepository;
        }
        [Route("")]
        [Route("index")]
        public IActionResult Index(Filter filter)
        {
            var seminar = _seminarRepository.getQueryable().Where(a => a.is_deleted == false);
            if (!string.IsNullOrWhiteSpace(filter.search_key))
            {
                seminar = seminar.Where(a => a.title.Contains(filter.search_key));
            }
            ViewBag.pagerInfo = _paginationService.GetMetaData(seminar.Count(), filter.page, filter.number_of_rows);
            seminar = seminar.OrderByDescending(a => a.Id).Skip(filter.number_of_rows * (filter.page - 1)).Take(filter.number_of_rows);

            var seminarList = seminar.ToList();
            SeminarIndexViewModel vm = getViewModelForIndex(seminarList);
            return View(vm);
        }

        private SeminarIndexViewModel getViewModelForIndex(List<Seminar> seminarList)
        {
            SeminarIndexViewModel vm = new SeminarIndexViewModel();
            foreach (var link in seminarList)
            {
                vm.seminarDetails.Add(_mapper.Map<SeminarDetails>(link));
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
            var organization = _organizerRepository.getQueryable().Where(a => !a.is_deleted && a.is_active).ToList();
            ViewBag.organization = new SelectList(organization, "Id", "orgname");
        }
        [HttpPost]
        [Route("create")]
        public IActionResult Create(SeminarDto dto)
        {
            getViewBagData();
            try
            {
                if (ModelState.IsValid)
                {
                    dto.created_by = getLoggedInUserId();
                    _seminarService.save(dto);
                    AlertHelper.setMessage(this, "Seminar saved successfully.", messageType.success);
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
                var seminar = _seminarRepository.getById(Id) ?? throw new ItemNotFoundException("Seminar doesnot exist.");
                SeminarDto dto = _mapper.Map<SeminarDto>(seminar);
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
        public IActionResult Update(SeminarDto dto)
        {
            getViewBagData();
            try
            {
                if (ModelState.IsValid)
                {
                    dto.modified_by = getLoggedInUserId();
                    _seminarService.update(dto);
                    AlertHelper.setMessage(this, "Seminar updated successfully.", messageType.success);
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
                _seminarService.delete(dto);
                AlertHelper.setMessage(this, "Seminar deleted successfully.", messageType.success);
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
                _seminarService.enable(dto);
                AlertHelper.setMessage(this, "Seminar enabled successfully.", messageType.success);
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
                _seminarService.disable(dto);
                AlertHelper.setMessage(this, "Seminar disabled successfully.", messageType.success);
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
