#pragma checksum "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Views\Shared\Components\ClientFooterView\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c2e6d68a8532571d5868099de512c9d721e202f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ClientFooterView_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ClientFooterView/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c2e6d68a8532571d5868099de512c9d721e202f", @"/Views/Shared/Components/ClientFooterView/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c64baf8114b4a107a9368e757b97e2256b4bef9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ClientFooterView_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClientHeaderIndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    
<div class=""footer"">
    <div class=""container"">
        <div class=""row footer-row"">
            <div class=""footer-col-1"">
                <h3>Download Our App</h3>
                <p>Download Our App for Android and Ios Devices</p>
                <div class=""app-logo"">
                    <img src=""/Images/Default/play.png"" />
                    <img src=""/Images/Default/apps.png"" />
                </div>
            </div>
            <div class=""footer-col-2"">
                <a href=""#"">
                    <img src=""/Images/Default/banner.png"" width=""100px"" />
                </a>
                <p>
                    Our main objective of this project is to learn asp.net web development
                </p>
            </div>
            <div class=""footer-col-3"">
                <h3>Get the links</h3>
                <ul>
                    <li>About</li>
                    <li>Terms and Conditions</li>
                    <li>Join us</li>
                </ul>
");
            WriteLiteral(@"            </div>
            <div class=""footer-col-4"">
                <h3>Follow Us</h3>
                <ul>
                    <li>Facebook</li>
                    <li>Twitter</li>
                    <li>Instagram</li>
                    <li>Youtube</li>
                </ul>
            </div>
        </div>
        <hr />
        <p class=""copyright"">Copyright &copy;2021 Project</p>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClientHeaderIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
