#pragma checksum "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\Shared\Components\DashboardLinkedin\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ea960811eb4c2c3c1ff4965249132efbb9484bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_DashboardLinkedin_Default), @"mvc.1.0.view", @"/Views/Shared/Components/DashboardLinkedin/Default.cshtml")]
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
#line 1 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\_ViewImports.cshtml"
using HotelProjectWebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\_ViewImports.cshtml"
using HotelProjectWebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\_ViewImports.cshtml"
using HotelProjectWebUI.Models.Testimonial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\_ViewImports.cshtml"
using HotelProjectWebUI.Dtos.ServiceDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\_ViewImports.cshtml"
using HotelProjectWebUI.Dtos.RegisterDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\_ViewImports.cshtml"
using HotelProjectWebUI.Dtos.LoginDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\_ViewImports.cshtml"
using HotelProjectWebUI.Dtos.AboutDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\_ViewImports.cshtml"
using HotelProjectWebUI.Dtos.RoomDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\_ViewImports.cshtml"
using HotelProjectWebUI.Dtos.TestimonialDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\_ViewImports.cshtml"
using HotelProjectWebUI.Dtos.StaffDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\_ViewImports.cshtml"
using HotelProjectWebUI.Dtos.SubscribeDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\_ViewImports.cshtml"
using HotelProjectWebUI.Dtos.BookingDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\_ViewImports.cshtml"
using HotelProjectWebUI.Dtos.ContactDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\_ViewImports.cshtml"
using HotelProjectWebUI.Dtos.GuestDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\_ViewImports.cshtml"
using HotelProjectWebUI.Dtos.SendMessage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\_ViewImports.cshtml"
using HotelProjectWebUI.Dtos.WorkLocationDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\_ViewImports.cshtml"
using HotelProjectWebUI.Dtos.AppUserDto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ea960811eb4c2c3c1ff4965249132efbb9484bb", @"/Views/Shared/Components/DashboardLinkedin/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80e7f94beaba79f3255a3561c524fd1ccd9aa89b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_DashboardLinkedin_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\Shared\Components\DashboardLinkedin\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-3 col-sm-6"">
    <div class=""card"">
        <div class=""social-graph-wrapper widget-linkedin"">
            <span class=""s-icon""><i class=""fa fa-linkedin""></i></span>
        </div>
        <div class=""row"">
            <div class=""col-6 border-right"">
                <div class=""pt-3 pb-3 pl-0 pr-0 text-center"">
                    <h4 class=""m-1"">");
#nullable restore
#line 14 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\Shared\Components\DashboardLinkedin\Default.cshtml"
                               Write(ViewBag.followers);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <p class=\"m-0\">Takipçi</p>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-6\">\r\n                <div class=\"pt-3 pb-3 pl-0 pr-0 text-center\">\r\n                    <h4 class=\"m-1\">");
#nullable restore
#line 20 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\Shared\Components\DashboardLinkedin\Default.cshtml"
                               Write(ViewBag.connection);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <p class=\"m-0\">Faaliyet</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
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
