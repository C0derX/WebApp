using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http.Headers;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("Error")]
    public class ErrorController : Controller
    {
        [HttpGet("/error/{statusCode}")]
        public IActionResult Index(int statusCode)
        {
            var statusCodeData = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
          
            switch (statusCode)
            {
                case 404:
                    if (string.IsNullOrWhiteSpace(statusCodeData.OriginalQueryString))
                    {
                        ViewBag.StatusCode = statusCode;
                        ViewBag.ErrorMessage = "The page you requested could not be found";
                    }
                    else
                    {
                        ViewBag.StatusCode = 401;
                        ViewBag.ErrorMessage = "You are not authorized to access this feature";
                    }
                    
                    ViewBag.RouteOfException = statusCodeData.OriginalPath;
                    break;
                case 401:
                    ViewBag.ErrorMessage = "You are not authorized to use this feature.";
                    ViewBag.StatusCode = statusCode;
                    ViewBag.RouteOfException = statusCodeData.OriginalPath;
                    break;
                case 500:
                    ViewBag.ErrorMessage = "Something went wrong on the server";
                    ViewBag.StatusCode = statusCode;
                    ViewBag.RouteOfException = statusCodeData.OriginalPath;
                    break;
            }

            return View("Error");
        }
    }
}
