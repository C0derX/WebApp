#pragma checksum "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\AssignRoleMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9e1af0117bd4c7120e6a0e8b3706d69955a28de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_UserManagement_Views_Role_AssignRoleMenu), @"mvc.1.0.view", @"/Areas/UserManagement/Views/Role/AssignRoleMenu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9e1af0117bd4c7120e6a0e8b3706d69955a28de", @"/Areas/UserManagement/Views/Role/AssignRoleMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04379ed2ba7c53072995197b67b0545412eedf70", @"/Areas/UserManagement/Views/_ViewImports.cshtml")]
    public class Areas_UserManagement_Views_Role_AssignRoleMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleMenuModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/UserManagement/Role/assign-role-menu"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                <h4 class=""card-title"">Assign Menu To Roles <a href=""/UserManagement/Role"" class=""badge badge-primary float-right""><i class=""mdi mdi-arrow-left""></i> Back</a></h4>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9e1af0117bd4c7120e6a0e8b3706d69955a28de5388", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 12 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\AssignRoleMenu.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 13 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\AssignRoleMenu.cshtml"
               Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 14 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\AssignRoleMenu.cshtml"
               Write(Html.HiddenFor(a => a.role_id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\" row\">\r\n                        <div class=\"col-md-6\">\r\n                            <h4><input type=\"checkbox\" id=\"select_all\" /> Select All</h4>\r\n");
#nullable restore
#line 18 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\AssignRoleMenu.cshtml"
                              
                                foreach (var item in Model.modules)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    <ul style=""list-style-type:none;"">
                                        <li>
                                            <input type=""checkbox"" name=""selectedModules"" />
                                            ");
#nullable restore
#line 24 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\AssignRoleMenu.cshtml"
                                       Write(item.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            <ul style=\"list-style-type:none;\">\r\n");
#nullable restore
#line 26 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\AssignRoleMenu.cshtml"
                                                   foreach (var menu in item.Menus.Where(a => a.parent_menu_id == null))
                                                    {

                                                        string selected = "";
                                                        if (Model.roleMenuMaps.Any(a => a.menu_id == menu.Id))
                                                        {
                                                            selected = "checked";
                                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        <li>\r\n                                                            <input type=\"checkbox\" name=\"menu_ids[]\" ");
#nullable restore
#line 35 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\AssignRoleMenu.cshtml"
                                                                                                Write(selected);

#line default
#line hidden
#nullable disable
                WriteLiteral(" value=\"");
#nullable restore
#line 35 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\AssignRoleMenu.cshtml"
                                                                                                                 Write(menu.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" id=\"");
#nullable restore
#line 35 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\AssignRoleMenu.cshtml"
                                                                                                                               Write(menu.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" />\r\n                                                            ");
#nullable restore
#line 36 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\AssignRoleMenu.cshtml"
                                                       Write(menu.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                                            <ul style=\"list-style-type:none\">\r\n");
#nullable restore
#line 39 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\AssignRoleMenu.cshtml"
                                                                  
                                                                    if (menu.hasSubMenus())
                                                                    {
                                                                        foreach (var sub in menu.sub_menus)
                                                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                            <li>\r\n                                                                                <input type=\"checkbox\" name=\"menu_ids[]\" ");
#nullable restore
#line 45 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\AssignRoleMenu.cshtml"
                                                                                                                    Write(selected);

#line default
#line hidden
#nullable disable
                WriteLiteral(" value=\"");
#nullable restore
#line 45 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\AssignRoleMenu.cshtml"
                                                                                                                                     Write(sub.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" id=\"");
#nullable restore
#line 45 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\AssignRoleMenu.cshtml"
                                                                                                                                                  Write(sub.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" />\r\n                                                                                ");
#nullable restore
#line 46 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\AssignRoleMenu.cshtml"
                                                                           Write(sub.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                                            <ul style=\"list-style-type:none\">\r\n");
#nullable restore
#line 48 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\AssignRoleMenu.cshtml"
                                                                                  
                                                                                    if (sub.hasSubMenus())
                                                                                    {
                                                                                        foreach (var sub1 in sub.sub_menus)
                                                                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                                            <li>\r\n                                                                                                <input type=\"checkbox\" name=\"menu_ids[]\" ");
#nullable restore
#line 54 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\AssignRoleMenu.cshtml"
                                                                                                                                    Write(selected);

#line default
#line hidden
#nullable disable
                WriteLiteral(" value=\"");
#nullable restore
#line 54 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\AssignRoleMenu.cshtml"
                                                                                                                                                     Write(sub1.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" id=\"");
#nullable restore
#line 54 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\AssignRoleMenu.cshtml"
                                                                                                                                                                   Write(sub1.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" />\r\n                                                                                                ");
#nullable restore
#line 55 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\AssignRoleMenu.cshtml"
                                                                                           Write(sub1.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                                                                            </li>\r\n");
#nullable restore
#line 58 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\AssignRoleMenu.cshtml"
                                                                                        }
                                                                                    }
                                                                                

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                                            </ul>\r\n                                                                            </li>\r\n");
#nullable restore
#line 64 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\AssignRoleMenu.cshtml"
                                                                        }
                                                                    }
                                                                

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                            </ul>\r\n                                                        </li>\r\n");
#nullable restore
#line 70 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\AssignRoleMenu.cshtml"
                                                    }
                                                

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            </ul>\r\n                                        </li>\r\n                                    </ul>\r\n");
#nullable restore
#line 75 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Areas\UserManagement\Views\Role\AssignRoleMenu.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleMenuModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
