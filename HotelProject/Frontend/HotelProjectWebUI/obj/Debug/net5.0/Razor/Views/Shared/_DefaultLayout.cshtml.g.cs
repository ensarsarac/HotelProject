#pragma checksum "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\Shared\_DefaultLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cc4725e20d68f7d0b81dd78d1ad640a45175f4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__DefaultLayout), @"mvc.1.0.view", @"/Views/Shared/_DefaultLayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cc4725e20d68f7d0b81dd78d1ad640a45175f4a", @"/Views/Shared/_DefaultLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80e7f94beaba79f3255a3561c524fd1ccd9aa89b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__DefaultLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\Shared\_DefaultLayout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
#nullable restore
#line 9 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\Shared\_DefaultLayout.cshtml"
Write(await Component.InvokeAsync("HeadPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cc4725e20d68f7d0b81dd78d1ad640a45175f4a6934", async() => {
                WriteLiteral("\r\n    <div class=\"container-fluid bg-white p-0\">\r\n        <!-- Spinner Start -->\r\n        ");
#nullable restore
#line 14 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\Shared\_DefaultLayout.cshtml"
   Write(await Component.InvokeAsync("SpinnerPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 15 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\Shared\_DefaultLayout.cshtml"
   Write(await Component.InvokeAsync("HeaderPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 16 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\Shared\_DefaultLayout.cshtml"
   Write(RenderSection("Banner", true));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 17 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\Shared\_DefaultLayout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 18 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\Shared\_DefaultLayout.cshtml"
   Write(await Html.PartialAsync("/Views/Default/NewsletterPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 19 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\Shared\_DefaultLayout.cshtml"
   Write(await Component.InvokeAsync("FooterPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    </div>\r\n\r\n    ");
#nullable restore
#line 23 "D:\Belgeler\source\repos\HotelProject\Frontend\HotelProjectWebUI\Views\Shared\_DefaultLayout.cshtml"
Write(await Component.InvokeAsync("ScriptPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
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
