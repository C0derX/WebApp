#pragma checksum "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "828c90dd0c28d463c41c01a8cd60363c668886c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_UserManagement_Views_Role_update), @"mvc.1.0.view", @"/Areas/UserManagement/Views/Role/update.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"828c90dd0c28d463c41c01a8cd60363c668886c1", @"/Areas/UserManagement/Views/Role/update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04379ed2ba7c53072995197b67b0545412eedf70", @"/Areas/UserManagement/Views/_ViewImports.cshtml")]
    public class Areas_UserManagement_Views_Role_update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/UserManagement/Role/Update"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                <h4 class=""card-title"">Role Update form   <a href=""/UserManagement/Role"" class=""badge badge-primary float-right""><i class=""mdi mdi-arrow-left""></i> Back</a></h4>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "828c90dd0c28d463c41c01a8cd60363c668886c15330", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 12 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\update.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 13 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\update.cshtml"
               Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 14 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\update.cshtml"
               Write(Html.HiddenFor(a => a.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 15 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\update.cshtml"
               Write(Html.HiddenFor(a => a.created_by));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\" row\">\r\n                        <div class=\"col-md-6\">\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 19 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\update.cshtml"
                           Write(Html.LabelFor(a => a.name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
#nullable restore
#line 20 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\update.cshtml"
                           Write(Html.TextBoxFor(a => a.name, new { @class = "form-control", @placeholder = "Eg. Admin" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <p class=\"text-danger\">");
#nullable restore
#line 21 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\update.cshtml"
                                                  Write(Html.ValidationMessageFor(a => a.name));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            </div>\r\n\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 25 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\update.cshtml"
                           Write(Html.LabelFor(a => a.permissions));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <br />\r\n");
#nullable restore
#line 27 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\update.cshtml"
                                  
                                    foreach (var itm in Enum.GetValues(typeof(Core.Common.Enums.Permissions)))
                                    {
                                        string status = "";
                                        if (Model.permissions != null)
                                        {
                                            if (Model.permissions.Contains((Core.Common.Enums.Permissions)itm))
                                            {
                                                status = "checked";
                                            }
                                        }


#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <input name=\"permissions[]\" class=\"ml-4\" ");
#nullable restore
#line 39 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\update.cshtml"
                                                                            Write(status);

#line default
#line hidden
#nullable disable
                WriteLiteral(" value=\"");
#nullable restore
#line 39 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\update.cshtml"
                                                                                           Write(itm);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" type=\"checkbox\" /> ");
#nullable restore
#line 39 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\update.cshtml"
                                                                                                                    Write(itm);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n");
#nullable restore
#line 40 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\update.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <p class=\"text-danger\">");
#nullable restore
#line 43 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\update.cshtml"
                                                  Write(Html.ValidationMessageFor(a => a.permissions));

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
                    <a href=""/UserManagement/Role"" class=""btn btn-danger"">Cancel</a>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
