#pragma checksum "C:\Data\FinalProjects\CinemaApp\CinemaApp.UI\Views\Cinema\Detail.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0bc6d4e4f41c38aecba53a69eff5fbe74b84b396ab54fcae7e64e4fab2b6baef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cinema_Detail), @"mvc.1.0.view", @"/Views/Cinema/Detail.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Data\FinalProjects\CinemaApp\CinemaApp.UI\Views\_ViewImports.cshtml"
using CinemaApp.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Data\FinalProjects\CinemaApp\CinemaApp.UI\Views\_ViewImports.cshtml"
using CinemaApp.Business.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Data\FinalProjects\CinemaApp\CinemaApp.UI\Views\_ViewImports.cshtml"
using CinemaApp.Entity.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Data\FinalProjects\CinemaApp\CinemaApp.UI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"0bc6d4e4f41c38aecba53a69eff5fbe74b84b396ab54fcae7e64e4fab2b6baef", @"/Views/Cinema/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2e3fe344f7757eeea75d394aaaa4b0b1bcb7f19dd57e155686ad1d2ce094b8bf", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cinema_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cinema>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%;height: 720px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/image/cinehero3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("photo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Data\FinalProjects\CinemaApp\CinemaApp.UI\Views\Cinema\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main>\r\n\r\n    <!-- cinema hero start -->\r\n\r\n    <section id=\"cinema_hero\">\r\n        <div class=\"hero-image\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0bc6d4e4f41c38aecba53a69eff5fbe74b84b396ab54fcae7e64e4fab2b6baef5038", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"container h-100\">\r\n            <div class=\"cinema_content h-100\">\r\n                <h2>");
#nullable restore
#line 17 "C:\Data\FinalProjects\CinemaApp\CinemaApp.UI\Views\Cinema\Detail.cshtml"
               Write(Model.CinemaName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <p>\r\n                    ");
#nullable restore
#line 19 "C:\Data\FinalProjects\CinemaApp\CinemaApp.UI\Views\Cinema\Detail.cshtml"
               Write(Model.ShortContent);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </p>
            </div>
        </div>
    </section>

    <!-- cinema hero end -->
    <!-- tabs start  -->

    <section id=""tabs"">

        <div class=""tab_header"">

            <ul class=""nav nav-pills mb-3 justify-content-center"" id=""pills-tab"" role=""tablist"">
                
                <li class=""nav-item"" role=""presentation"">
                    <a class=""nav-link active"" id=""pills-contact-tab"" data-toggle=""pill"" href=""#pills-contact"" role=""tab"" aria-controls=""pills-profile"" aria-selected=""false"">Contact Information</a>
                </li>

            </ul>

        </div>


        <div class=""tab_body"">

            <div class=""tab-content mt-5"" id=""pills-tabContent"">
               

                <div class=""tab-pane fade show active"" id=""pills-contact"" role=""tabpanel"" aria-labelledby=""pills-profile-tab"">
                    <div class=""contact_us tab_list "">
                        <div class=""container-fluid"">
                           ");
            WriteLiteral(@" <div class=""row"">
                                <div class=""col-lg-6 col-md-6 col-sm-12"">
                                    <div class=""contact-items"">
                                        <div class=""contact-item pt-4"">
                                            <h5>Bizim Unvan</h5>
                                            <p>
                                                ");
#nullable restore
#line 57 "C:\Data\FinalProjects\CinemaApp\CinemaApp.UI\Views\Cinema\Detail.cshtml"
                                           Write(Model.OurAdress);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </p>
                                        </div>

                                        <div class=""contact-item pt-4"">
                                            <h5>Telefon</h5>
                                            <p>
                                                ");
#nullable restore
#line 64 "C:\Data\FinalProjects\CinemaApp\CinemaApp.UI\Views\Cinema\Detail.cshtml"
                                           Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </p>
                                        </div>

                                        <div class=""contact-item pt-4"">
                                            <h5>Elektron Unvan</h5>
                                            <p>
                                                ");
#nullable restore
#line 71 "C:\Data\FinalProjects\CinemaApp\CinemaApp.UI\Views\Cinema\Detail.cshtml"
                                           Write(Model.EMail);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </p>
                                        </div>

                                        <div class=""contact-item pt-4"">
                                            <h5>Marketing Sobesi</h5>
                                            <p>
                                                media@cinemaplus.az
                                            </p>
                                        </div>

                                        <div class=""contact-item pt-4"">
                                            <h5>İş saatı</h5>
                                            <p>
                                                ");
#nullable restore
#line 85 "C:\Data\FinalProjects\CinemaApp\CinemaApp.UI\Views\Cinema\Detail.cshtml"
                                           Write(Model.WorkingHour);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </p>
                                        </div>


                                    </div>


                                </div>
                                <div class=""col-lg-6 col-md-6 col-sm-12"">

                                    ");
#nullable restore
#line 96 "C:\Data\FinalProjects\CinemaApp\CinemaApp.UI\Views\Cinema\Detail.cshtml"
                               Write(Html.Raw(Model.MapLocation));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div> \r\n        </div>\r\n\r\n</section>\r\n\r\n    <!-- tabs end -->\r\n\r\n</main>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cinema> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591