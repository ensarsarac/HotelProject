#pragma checksum "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\RoleAssign\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2f374ad16507a72fba175823e92606844f9856b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RoleAssign_Index), @"mvc.1.0.view", @"/Views/RoleAssign/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2f374ad16507a72fba175823e92606844f9856b", @"/Views/RoleAssign/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80e7f94beaba79f3255a3561c524fd1ccd9aa89b", @"/Views/_ViewImports.cshtml")]
    public class Views_RoleAssign_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HotelProjectEntityLayer.Concrete.AppUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\RoleAssign\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card"">
    <div class=""card-body"">
        <div class=""card-title"">
            <h4>Rol Atama Sayfası</h4>
        </div>
        <div class=""table-responsive"">
            <table class=""table table-bordered"">
                <thead>
                    <tr>
                        <th>Ad Soyad</th>
                        <th>Rol Ata</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 23 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\RoleAssign\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 26 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\RoleAssign\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 26 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\RoleAssign\Index.cshtml"
                                      Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 797, "\"", 835, 2);
            WriteAttributeValue("", 804, "/RoleAssign/AssignRole/", 804, 23, true);
#nullable restore
#line 27 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\RoleAssign\Index.cshtml"
WriteAttributeValue("", 827, item.Id, 827, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Rol Ata</a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 29 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\RoleAssign\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HotelProjectEntityLayer.Concrete.AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
