#pragma checksum "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\Seminar\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "292e3f3db7ff15945e582a7217665542647689ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_CMS_Views_Seminar_Index), @"mvc.1.0.view", @"/Areas/CMS/Views/Seminar/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"292e3f3db7ff15945e582a7217665542647689ec", @"/Areas/CMS/Views/Seminar/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d0035aa91e7575b9033f8110724e0a5e37e6c64", @"/Areas/CMS/Views/_ViewImports.cshtml")]
    public class Areas_CMS_Views_Seminar_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SeminarIndexViewModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Web.Pagination.PagerTagHelper __Web_Pagination_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Seminar</h4>
                <p class=""card-description"">
                    <a href=""/cms/seminar/create"" class=""btn btn-rounded btn-primary btn-sm""><i class=""mdi mdi-plus-circle mdi-18px""></i>Add New Seminar</a>
                </p>
                <div class=""table-responsive"">
                    <table class=""table table-hover"">
                        <thead>
                            <tr>
                                <th>Title</th>
                                <th>Date</th>
                                <th>Description</th>
                                <th>Types</th>
                                <th>Organizer</th>
                                <th>Status</th>
                                <th>Action</th>
                            </tr>
                        </thead>
                   ");
            WriteLiteral("     <tbody>\r\n");
#nullable restore
#line 26 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\Seminar\Index.cshtml"
                              
                                foreach (var item in Model.seminarDetails)
                                {



#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 32 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\Seminar\Index.cshtml"
                                       Write(item.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 33 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\Seminar\Index.cshtml"
                                       Write(item.date.ToString("MM-dd-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 34 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\Seminar\Index.cshtml"
                                       Write(item.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 35 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\Seminar\Index.cshtml"
                                       Write(item.types);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 36 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\Seminar\Index.cshtml"
                                       Write(item.organizer.orgname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 37 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\Seminar\Index.cshtml"
                                          
                                            string badgeType = "badge-success";
                                            string status = "Active";
                                            if (!item.is_active)
                                            {
                                                badgeType = "badge-danger";
                                                status = "Inactive";
                                            }

                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td><label");
            BeginWriteAttribute("class", " class=\"", 2207, "\"", 2231, 2);
            WriteAttributeValue("", 2215, "badge", 2215, 5, true);
#nullable restore
#line 47 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\Seminar\Index.cshtml"
WriteAttributeValue(" ", 2220, badgeType, 2221, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 47 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\Seminar\Index.cshtml"
                                                                       Write(status);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label></td>

                                        <td>
                                            <div>
                                                <button class=""btn btn-primary"" type=""button"" id=""dropdownMenuIconButton6"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                                    <i class=""mdi mdi-security""></i>
                                                </button>
                                                <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuIconButton6"" x-placement=""bottom-start"" style=""position: absolute; will-change: transform; top: 0px; left: 0px; transform: translate3d(0px, 38px, 0px);"">
                                                    <a class=""dropdown-item""");
            BeginWriteAttribute("href", " href=\"", 3025, "\"", 3060, 2);
            WriteAttributeValue("", 3032, "/cms/seminar/update/", 3032, 20, true);
#nullable restore
#line 55 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\Seminar\Index.cshtml"
WriteAttributeValue("", 3052, item.Id, 3052, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"mdi mdi-account-edit\"></i> Edit</a>\r\n                                                    <div class=\"dropdown-divider\"></div>\r\n                                                    <a class=\"dropdown-item delete\"");
            BeginWriteAttribute("href", " href=\"", 3282, "\"", 3317, 2);
            WriteAttributeValue("", 3289, "/cms/seminar/delete/", 3289, 20, true);
#nullable restore
#line 57 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\Seminar\Index.cshtml"
WriteAttributeValue("", 3309, item.Id, 3309, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"mdi mdi-delete\"></i> Delete</a>\r\n                                                    <div class=\"dropdown-divider\"></div>\r\n");
#nullable restore
#line 59 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\Seminar\Index.cshtml"
                                                      
                                                        if (item.is_active)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <a class=\"dropdown-item \"");
            BeginWriteAttribute("href", " href=\"", 3729, "\"", 3765, 2);
            WriteAttributeValue("", 3736, "/cms/seminar/disable/", 3736, 21, true);
#nullable restore
#line 62 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\Seminar\Index.cshtml"
WriteAttributeValue("", 3757, item.Id, 3757, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"mdi mdi-thumb-down\"></i> Disable</a>\r\n");
#nullable restore
#line 63 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\Seminar\Index.cshtml"
                                                        }
                                                        else
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <a class=\"dropdown-item \"");
            BeginWriteAttribute("href", " href=\"", 4080, "\"", 4115, 2);
            WriteAttributeValue("", 4087, "/cms/seminar/enable/", 4087, 20, true);
#nullable restore
#line 66 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\Seminar\Index.cshtml"
WriteAttributeValue("", 4107, item.Id, 4107, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"mdi mdi-thumb-up\"></i> Enable</a>\r\n");
#nullable restore
#line 67 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\Seminar\Index.cshtml"
                                                        }
                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </div>\r\n                                            </div>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 74 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\Seminar\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("Pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "292e3f3db7ff15945e582a7217665542647689ec13737", async() => {
            }
            );
            __Web_Pagination_PagerTagHelper = CreateTagHelper<global::Web.Pagination.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__Web_Pagination_PagerTagHelper);
#nullable restore
#line 79 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\CMS\Views\Seminar\Index.cshtml"
__Web_Pagination_PagerTagHelper.Info = ViewBag.pagerInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("info", __Web_Pagination_PagerTagHelper.Info, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SeminarIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
