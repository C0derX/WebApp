#pragma checksum "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Organization\AssignModule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24fb35913f4ef83a1011825254b5310f4a511ab0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_UserManagement_Views_Organization_AssignModule), @"mvc.1.0.view", @"/Areas/UserManagement/Views/Organization/AssignModule.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24fb35913f4ef83a1011825254b5310f4a511ab0", @"/Areas/UserManagement/Views/Organization/AssignModule.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04379ed2ba7c53072995197b67b0545412eedf70", @"/Areas/UserManagement/Views/_ViewImports.cshtml")]
    public class Areas_UserManagement_Views_Organization_AssignModule : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrganizationModuleMapModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/UserManagement/Organization/assign-module"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h4 class=\"card-title\">Assign Modules To ");
#nullable restore
#line 9 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Organization\AssignModule.cshtml"
                                                    Write(Model.organization.organization_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24fb35913f4ef83a1011825254b5310f4a511ab06012", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 11 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Organization\AssignModule.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 12 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Organization\AssignModule.cshtml"
               Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 13 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Organization\AssignModule.cshtml"
               Write(Html.HiddenFor(a => a.organization_id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    <div class=\" row\">\r\n                        <div class=\"col-md-6\">\r\n                            <h4><input type=\"checkbox\" id=\"select_all\" /> Select All</h4>\r\n                            <ul style=\"list-style-type:none;\">\r\n");
#nullable restore
#line 19 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Organization\AssignModule.cshtml"
                                  
                                    foreach (var item in Model.modules)
                                    {
                                        string selected = "";
                                        if (Model.organizationModuleMaps.Any(a => a.module_id == item.Id))
                                        {
                                            selected = "checked";
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <li>\r\n                                            <input type=\"checkbox\" name=\"module_ids[]\" ");
#nullable restore
#line 28 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Organization\AssignModule.cshtml"
                                                                                  Write(selected);

#line default
#line hidden
#nullable disable
                WriteLiteral(" value=\"");
#nullable restore
#line 28 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Organization\AssignModule.cshtml"
                                                                                                   Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" id=\"");
#nullable restore
#line 28 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Organization\AssignModule.cshtml"
                                                                                                                 Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" />\r\n                                            ");
#nullable restore
#line 29 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Organization\AssignModule.cshtml"
                                       Write(item.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                        </li>\r\n");
#nullable restore
#line 32 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Organization\AssignModule.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </ul>
                        </div>
                        <div class=""col-md-6""></div>
                        <button type=""submit"" class=""btn btn-primary mr-2"">Submit</button>
                    </div>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $('#select_all').change(function () {
            var checkboxes = $(this).closest('form').find(':checkbox');
            checkboxes.prop('checked', $(this).is(':checked'));
        });

        $(function () {
            $(""input[type='checkbox']"").change(function () {
                $(this).siblings('ul')
                    .find(""input[type='checkbox']"")
                    .prop('checked', this.checked);
            });
        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrganizationModuleMapModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
