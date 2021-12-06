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
    [Route("cms/organizer")]

    public class OrganizerController : BaseController
    {
        private readonly PaginatedMetaService _paginationService;
        private readonly IMapper _mapper;
        private readonly OrganizerRepository _organizerRepository;
        private readonly OrganizerService _organizerService;

        public OrganizerController(PaginatedMetaService paginationService, IMapper mapper, OrganizerRepository organizerRepository, OrganizerService organizerService)
        {
            _paginationService = paginationService;
            _mapper = mapper;
            _organizerRepository = organizerRepository;
            _organizerService = organizerService;
        }
        [Route("")]
        [Route("index")]
        public IActionResult Index(Filter filter)
        {
            var org = _organizerRepository.getQueryable().Where(a => a.is_deleted == false);
            if (!string.IsNullOrWhiteSpace(filter.search_key))
            {
                org = org.Where(a => a.orgname.Contains(filter.search_key));
            }
            ViewBag.pagerInfo = _paginationService.GetMetaData(org.Count(), filter.page, filter.number_of_rows);
            org = org.OrderByDescending(a => a.Id).Skip(filter.number_of_rows * (filter.page - 1)).Take(filter.number_of_rows);

            var orgList = org.ToList();
            OrganizerIndexViewModel vm = getViewModelForIndex(orgList);
            return View(vm);
        }
        private OrganizerIndexViewModel getViewModelForIndex(List<Organizer> orgList)
        {
            OrganizerIndexViewModel vm = new OrganizerIndexViewModel();
            foreach (var link in orgList)
            {
                vm.organizerDetails.Add(_mapper.Map<OrganizerDetails>(link));
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
        public IActionResult Create(OrganizerDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dto.created_by = getLoggedInUserId();
                    _organizerService.save(dto);
                    AlertHelper.setMessage(this, "Organizer saved successfully.", messageType.success);
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
                var org = _organizerRepository.getById(Id) ?? throw new ItemNotFoundException("Organizer doesnot exist.");
                OrganizerDto dto = _mapper.Map<OrganizerDto>(org);
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
        public IActionResult Update(OrganizerDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dto.modified_by = getLoggedInUserId();
                    _organizerService.update(dto);
                    AlertHelper.setMessage(this, "Organizer updated successfully.", messageType.success);
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
                _organizerService.delete(dto);
                AlertHelper.setMessage(this, "Organizer deleted successfully.", messageType.success);
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
                _organizerService.enable(dto);
                AlertHelper.setMessage(this, "Organizer enabled successfully.", messageType.success);
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
                _organizerService.disable(dto);
                AlertHelper.setMessage(this, "Organizer disabled successfully.", messageType.success);
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
