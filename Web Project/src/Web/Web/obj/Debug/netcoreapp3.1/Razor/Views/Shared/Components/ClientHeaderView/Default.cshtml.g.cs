#pragma checksum "C:\Users\Acer\Desktop\assignment_seminars\Project\src\Web\Web\Views\Shared\Components\ClientHeaderView\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23d5760042b9933832ecc76b8047c9b5744f7735"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ClientHeaderView_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ClientHeaderView/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23d5760042b9933832ecc76b8047c9b5744f7735", @"/Views/Shared/Components/ClientHeaderView/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c64baf8114b4a107a9368e757b97e2256b4bef9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ClientHeaderView_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClientHeaderIndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""header"">
    <div class=""container"">
        <div class=""navbar"">
            <div class=""logo"">
                <a target=""_blank""  href=""//koi.edu.au/wp/"">
                    <img src=""/Images/Default/koi.png"" width=""225px"" />
                </a>
            </div>
            <nav>

                <ul id=""MenuItems"">
                    <li>
                        <a href=""/"">Home</a>
                    </li>
                    <li>
                        <a href=""/administrator/"">Login</a>
                    </li>
                    <li>
                        <a href=""#"">About Us</a>
                    </li>
                </ul>
            </nav>

            <img src=""/Images/Default/menu.png""
                 class=""menu-icon""
                 onclick=""openNav()"" />
        </div>

        <div id=""myNav"" class=""overlay"">
            <a href=""javascript:void(0)"" class=""closebtn"" onclick=""closeNav()"">&times;</a>
            <div class=""overlay-con");
            WriteLiteral(@"tent"">
                <ul id=""MenuItems"">
                    <li>
                        <a href=""/"">Home</a>
                    </li>
                    <li>
                        <a href=""/administrator/"">Login</a>
                    </li>
                    <li>
                        <a href=""#"">About Us</a>
                    </li>
                </ul>
            </div>

        </div>
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
