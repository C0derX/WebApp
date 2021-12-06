using Web.ViewModels;
using CMS.Service.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace UserManagement.Web.Controllers
{
    public class HomeController :Controller
    {
        private readonly StudentRepository _studentRepository;

        public HomeController(StudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
   
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            ClientHomeIndexViewModel vm = new ClientHomeIndexViewModel();
            vm.student = _studentRepository.getQueryable().Where(a => a.is_active == true && !a.is_deleted).ToList();
            return View(vm);
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
