#pragma checksum "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Views\Shared\message.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7853675841cb3e9906f5094a9edb651cde7ab4d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_message), @"mvc.1.0.view", @"/Views/Shared/message.cshtml")]
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
#line 1 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Views\_ViewImports.cshtml"
using UserManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Views\_ViewImports.cshtml"
using Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Views\_ViewImports.cshtml"
using CMS.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7853675841cb3e9906f5094a9edb651cde7ab4d3", @"/Views/Shared/message.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c64baf8114b4a107a9368e757b97e2256b4bef9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_message : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Views\Shared\message.cshtml"
  
    if (TempData["message"] != null)
    {
        Web.Helpers.Alert alert = Newtonsoft.Json.JsonConvert.DeserializeObject<Web.Helpers.Alert>(TempData["message"].ToString());
        if (alert.message_type ==Web.Helpers.messageType.success)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""alert alert-success"" role=""alert"">
                <button type=""button"" class=""close"" data-dismiss=""alert""
                        aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
                <i class=""mdi mdi-check-all""></i>
                <strong>");
#nullable restore
#line 14 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Views\Shared\message.cshtml"
                   Write(alert.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </div>\r\n            <br />\r\n");
#nullable restore
#line 17 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Views\Shared\message.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""alert alert-danger"" role=""alert"">
                <button type=""button"" class=""close"" data-dismiss=""alert""
                        aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
                <i class=""mdi mdi-block-helper""></i>
                <strong>");
#nullable restore
#line 26 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Views\Shared\message.cshtml"
                   Write(alert.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </div>\r\n            <br />\r\n");
#nullable restore
#line 29 "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Views\Shared\message.cshtml"
        }
    };

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
