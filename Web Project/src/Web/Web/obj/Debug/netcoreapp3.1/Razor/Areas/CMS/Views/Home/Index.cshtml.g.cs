#pragma checksum "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef171998c70f94bb7a81ae0253508423d33b2158"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_CMS_Views_Home_Index), @"mvc.1.0.view", @"/Areas/CMS/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\_ViewImports.cshtml"
using UserManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\_ViewImports.cshtml"
using Web.Pagination;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\_ViewImports.cshtml"
using CMS.Service.Dto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\_ViewImports.cshtml"
using Web.Areas.CMS.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef171998c70f94bb7a81ae0253508423d33b2158", @"/Areas/CMS/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d0035aa91e7575b9033f8110724e0a5e37e6c64", @"/Areas/CMS/Views/_ViewImports.cshtml")]
    public class Areas_CMS_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeIndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\Home\Index.cshtml"
  
    var countDetails = Model.homeDetails;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-sm-9"">
        <div class=""row"">
            <div class=""col-sm-12 pr-0"">
                <div class=""d-lg-flex"">
                    <h3 class=""text-dark font-weight-bold mb-0 mr-5"">Welcome to Dashboard</h3>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-sm-3"">
        <div class=""dropdown float-right"">
            <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuIconButton1"">
                <h6 class=""dropdown-header"">Settings</h6>
                <a class=""dropdown-item"" href=""index.html#"">Action</a>
                <a class=""dropdown-item"" href=""index.html#"">Another action</a>
                <a class=""dropdown-item"" href=""index.html#"">Something else here</a>
                <div class=""dropdown-divider""></div>
                <a class=""dropdown-item"" href=""index.html#"">Separated link</a>
            </div>
        </div>
    </div>
</div>
<div class=""row mt-3"">
    <div class=""col-12 col-sm-6 co");
            WriteLiteral(@"l-md-6 col-xl-3 grid-margin"">
        <div class=""card bg-gradient-info"">
            <div class=""card-body"">
                <a href=""/cms/student/index""><h4 class=""card-title"">Total Student</h4></a>
                <p class=""text-small text-white"">Till Today</p>
                <div class=""d-flex justify-content-between align-items-center"">
                    <h2 class=""text-dark font-weight-bold"">");
#nullable restore
#line 35 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\Home\Index.cshtml"
                                                      Write(countDetails.student_count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<span class=""text-muted text-extra-small""></span></h2>
                    <div class=""text-danger font-weight-bold d-flex justify-content-between align-items-center"">
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-12 col-sm-6 col-md-6 col-xl-3 grid-margin"">
        <div class=""card bg-gradient-success"">
            <div class=""card-body"">
                <a href=""/cms/organizer/index""><h4 class=""card-title"">Total Organizer</h4></a>
                <p class=""text-small text-white"">Till Today</p>
                <div class=""d-flex justify-content-between align-items-center"">
                    <h2 class=""text-dark font-weight-bold"">");
#nullable restore
#line 48 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\Home\Index.cshtml"
                                                      Write(countDetails.organizer_count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<span class=""text-muted text-extra-small""></span></h2>
                    <div class=""text-danger font-weight-bold d-flex justify-content-between align-items-center"">
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-12 col-sm-6 col-md-6 col-xl-3 grid-margin"">
        <div class=""card bg-secondary"">
            <div class=""card-body"">
                <a href=""/cms/seminar/index""><h4 class=""card-title"">Active Seminar</h4></a>
                <p class=""text-small text-white"">Till Today</p>
                <div class=""d-flex justify-content-between align-items-center"">
                    <h2 class=""text-dark font-weight-bold"">");
#nullable restore
#line 61 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\Home\Index.cshtml"
                                                      Write(countDetails.seminar_count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<span class=""text-muted text-extra-small""></span></h2>
                    <div class=""text-danger font-weight-bold d-flex justify-content-between align-items-center"">
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-12 col-sm-6 col-md-6 col-xl-3 grid-margin"">
        <div class=""card bg-gradient-primary"">
            <div class=""card-body"">
                <a href=""cms/register/index""><h4 class=""card-title"">Registration</h4></a>
                <p class=""text-small text-white"">Till Today</p>
                <div class=""d-flex justify-content-between align-items-center"">
                    <h2 class=""text-dark font-weight-bold"">");
#nullable restore
#line 74 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\Home\Index.cshtml"
                                                      Write(countDetails.register_count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<span class=""text-muted text-extra-small""></span></h2>
                    <div class=""text-danger font-weight-bold d-flex justify-content-between align-items-center"">
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Student Table</h4>
                <div class=""table-responsive"">
                    <table class=""table table-hover"">
                        <thead>
                            <tr>
                                <th>Student ID</th>
                                <th>Student Name</th>
                                <th>Date Of Birth</th>
                                <th>Address</th>
                                <th>Email</th>
                                <th>Phone No</th>
                            </tr>
                        </thead");
            WriteLiteral(">\r\n                        <tbody>\r\n");
#nullable restore
#line 100 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\Home\Index.cshtml"
                              
                                foreach (var item in Model.std)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 104 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\Home\Index.cshtml"
                                       Write(item.student_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 105 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\Home\Index.cshtml"
                                       Write(item.fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 106 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\Home\Index.cshtml"
                                       Write(item.dob.ToString("MM-dd-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 107 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\Home\Index.cshtml"
                                       Write(item.address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 108 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\Home\Index.cshtml"
                                       Write(item.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 109 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\Home\Index.cshtml"
                                       Write(item.phone_no);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 111 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\Home\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<SharedResource> Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
