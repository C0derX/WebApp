#pragma checksum "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Menu\create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c2462266a59910cfc467c5fe967afcc7813c2cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_UserManagement_Views_Menu_create), @"mvc.1.0.view", @"/Areas/UserManagement/Views/Menu/create.cshtml")]
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
#line 1 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\_ViewImports.cshtml"
using UserManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\_ViewImports.cshtml"
using UserManagement.Service.Dto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\_ViewImports.cshtml"
using Web.Areas.UserManagement.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\_ViewImports.cshtml"
using Web.Areas.UserManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c2462266a59910cfc467c5fe967afcc7813c2cb", @"/Areas/UserManagement/Views/Menu/create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04379ed2ba7c53072995197b67b0545412eedf70", @"/Areas/UserManagement/Views/_ViewImports.cshtml")]
    public class Areas_UserManagement_Views_Menu_create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MenuDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Menu Entry form   <a href=""/UserManagement/Menu"" class=""badge badge-primary float-right""><i class=""mdi mdi-arrow-left""></i> Back</a></h4>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c2462266a59910cfc467c5fe967afcc7813c2cb4961", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 12 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Menu\create.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 13 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Menu\create.cshtml"
               Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\" row\">\r\n                        <div class=\"col-md-6\">\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 17 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Menu\create.cshtml"
                           Write(Html.LabelFor(a => a.name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
#nullable restore
#line 18 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Menu\create.cshtml"
                           Write(Html.TextBoxFor(a => a.name, new { @class = "form-control", @placeholder = "Eg. Sales" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <p class=\"text-danger\">");
#nullable restore
#line 19 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Menu\create.cshtml"
                                                  Write(Html.ValidationMessageFor(a => a.name));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            </div>\r\n\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 23 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Menu\create.cshtml"
                           Write(Html.LabelFor(a => a.module_id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
#nullable restore
#line 24 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Menu\create.cshtml"
                           Write(Html.DropDownListFor(a => a.module_id, (SelectList)ViewBag.moduleList, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <p class=\"text-danger\">");
#nullable restore
#line 25 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Menu\create.cshtml"
                                                  Write(Html.ValidationMessageFor(a => a.module_id));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            </div>\r\n\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 29 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Menu\create.cshtml"
                           Write(Html.LabelFor(a => a.parent_menu_id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
#nullable restore
#line 30 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Menu\create.cshtml"
                           Write(Html.DropDownListFor(a => a.parent_menu_id, (SelectList)ViewBag.parentMenuList, "Top Menu", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <p class=\"text-danger\">");
#nullable restore
#line 31 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Menu\create.cshtml"
                                                  Write(Html.ValidationMessageFor(a => a.parent_menu_id));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            </div>\r\n\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 35 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Menu\create.cshtml"
                           Write(Html.LabelFor(a => a.permissions));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <br />\r\n");
#nullable restore
#line 37 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Menu\create.cshtml"
                                  
                                    foreach (var itm in Enum.GetValues(typeof(Core.Common.Enums.Permissions)))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <input name=\"permissions[]\"");
                BeginWriteAttribute("value", " value=\"", 2192, "\"", 2204, 1);
#nullable restore
#line 40 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Menu\create.cshtml"
WriteAttributeValue("", 2200, itm, 2200, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"pcheck\" type=\"checkbox\" /> ");
#nullable restore
#line 40 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Menu\create.cshtml"
                                                                                                              Write(itm);

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Menu\create.cshtml"
                                                                                                                       
                                    }
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <p class=\"text-danger\">");
#nullable restore
#line 44 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Menu\create.cshtml"
                                                  Write(Html.ValidationMessageFor(a => a.permissions));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            </div>\r\n\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 48 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Menu\create.cshtml"
                           Write(Html.LabelFor(a => a.is_visible_to_menu));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
#nullable restore
#line 49 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Menu\create.cshtml"
                           Write(Html.CheckBoxFor(a => a.is_visible_to_menu, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <p class=\"text-danger\">");
#nullable restore
#line 50 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Menu\create.cshtml"
                                                  Write(Html.ValidationMessageFor(a => a.is_visible_to_menu));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            </div>\r\n\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 54 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Menu\create.cshtml"
                           Write(Html.LabelFor(a => a.display_icon));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
#nullable restore
#line 55 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Menu\create.cshtml"
                           Write(Html.TextBoxFor(a => a.display_icon, new { @class = "form-control", @placeholder = "Eg. fa fa-user" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <p class=\"text-danger\">");
#nullable restore
#line 56 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Menu\create.cshtml"
                                                  Write(Html.ValidationMessageFor(a => a.display_icon));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            </div>\r\n\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 60 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Menu\create.cshtml"
                           Write(Html.LabelFor(a => a.web_url));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
#nullable restore
#line 61 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Menu\create.cshtml"
                           Write(Html.TextBoxFor(a => a.web_url, new { @class = "form-control", @placeholder = "Eg. /billing/sales/create" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <p class=\"text-danger\">");
#nullable restore
#line 62 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Menu\create.cshtml"
                                                  Write(Html.ValidationMessageFor(a => a.web_url));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            </div>\r\n\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 66 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Menu\create.cshtml"
                           Write(Html.LabelFor(a => a.api_url));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
#nullable restore
#line 67 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Menu\create.cshtml"
                           Write(Html.TextBoxFor(a => a.api_url, new { @class = "form-control", @placeholder = "Eg. /api/billing/sales/create" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <p class=\"text-danger\">");
#nullable restore
#line 68 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Menu\create.cshtml"
                                                  Write(Html.ValidationMessageFor(a => a.api_url));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            </div>\r\n\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 72 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Menu\create.cshtml"
                           Write(Html.LabelFor(a => a.display_order));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
#nullable restore
#line 73 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Menu\create.cshtml"
                           Write(Html.TextBoxFor(a => a.display_order, new { @class = "form-control", @placeholder = "Eg. 1,2,3" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <p class=\"text-danger\">");
#nullable restore
#line 74 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Menu\create.cshtml"
                                                  Write(Html.ValidationMessageFor(a => a.display_order));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                            </div>
                        </div>
                        <div class=""col-md-6"">

                        </div>
                    </div>
                    <button type=""submit"" class=""btn btn-primary mr-2"">Submit</button>
                    <a href=""/UserManagement/Menu"" class=""btn btn-danger"">Cancel</a>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(\'input[name=\"permissions[]\"]\').on(\'change\', function () {\r\n            $(\'input[name=\"permissions[]\"]\').not(this).prop(\'checked\', false);\r\n        });\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MenuDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
