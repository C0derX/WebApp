using Web.Areas.CMS.ViewModels;
using CMS.Service.Repository.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using UserManagement.Service.Repository.Interface;

namespace UserManagement.Web.Areas.Administator.Controllers
{
    [Authorize]
    [Area("cms")]
    [Route("administrator")]
    [Route("administrator/Home")]
    public class HomeController : BaseController
    {
        private readonly OrganizationRepository _organizationRepository;
        private readonly StudentRepository _studentRepository;
        private readonly SeminarRepository _seminarRepository;
        private readonly OrganizerRepository _organizerRepository;
        private readonly RegisterRepository _registerRepository;

        public HomeController(OrganizationRepository organizationRepository,StudentRepository studentRepository,SeminarRepository seminarRepository,
            OrganizerRepository organizerRepository,RegisterRepository registerRepository)
        {
            _organizationRepository = organizationRepository;
            _studentRepository = studentRepository;
            _seminarRepository = seminarRepository;
            _organizerRepository = organizerRepository;
            _registerRepository = registerRepository;
        }

        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            HomeIndexViewModel vm = new HomeIndexViewModel();
            var organizatinDetails = _organizationRepository.getAll().SingleOrDefault();
            vm.std = _studentRepository.getQueryable().Where(a => a.is_active == true && !a.is_deleted).ToList();
            setHomeDetailsViewModelData(vm);
            if (organizatinDetails == null)
                return Redirect("/Usermanagement/organization/create");
            return View(vm);
        }

        private void setHomeDetailsViewModelData(HomeIndexViewModel vm)
        {
            long student = _studentRepository.getQueryable().Where(a => !a.is_deleted && a.is_active).Count();
            long organizer = _organizerRepository.getQueryable().Where(a => !a.is_deleted && a.is_active).Count();
            long seminar = _seminarRepository.getQueryable().Where(a => !a.is_deleted && a.is_active).Count();
            long register = _registerRepository.getQueryable().Where(a => !a.is_deleted ).Count();
            vm.homeDetails = new HomeDetails()
            {
                student_count = student,
                organizer_count= organizer,
                seminar_count = seminar,
                register_count= register,
            };
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }
    }
}
