#pragma checksum "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\BookingByCity\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4e47e63cb0ac632857867166e66c85786890dfa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookingByCity_Index), @"mvc.1.0.view", @"/Views/BookingByCity/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4e47e63cb0ac632857867166e66c85786890dfa", @"/Views/BookingByCity/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80e7f94beaba79f3255a3561c524fd1ccd9aa89b", @"/Views/_ViewImports.cshtml")]
    public class Views_BookingByCity_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HotelListViewModel.Result>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\BookingByCity\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Hotel Ara</h1>\r\n<hr />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4e47e63cb0ac632857867166e66c85786890dfa7219", async() => {
                WriteLiteral("\r\n    <input class=\"form-control\" type=\"text\" name=\"search\"/>\r\n    <button type=\"submit\" class=\"btn btn-primary my-3\">Ara</button>\r\n");
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
            WriteLiteral("\r\n\r\n<table class=\"table table-striped mt-3\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Otel Adı</th>\r\n        <th>Otel Puanı</th>\r\n        <th>Otel Detaylar</th>\r\n    </tr>\r\n");
#nullable restore
#line 24 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\BookingByCity\Index.cshtml"
     foreach (var item in Model)
    {
        count += 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 28 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\BookingByCity\Index.cshtml"
           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\BookingByCity\Index.cshtml"
           Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\BookingByCity\Index.cshtml"
           Write(item.reviewScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a href=\"#\" class=\"btn btn-dark\">Detaylar</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\BookingByCity\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HotelListViewModel.Result>> Html { get; private set; }
    }
}
#pragma warning restore 1591