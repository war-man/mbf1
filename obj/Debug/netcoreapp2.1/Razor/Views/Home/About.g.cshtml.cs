#pragma checksum "d:\C#\MVC\mbf\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90efd60e3c68896e4907c522027302cc21ed2713"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "d:\C#\MVC\mbf\Views\_ViewImports.cshtml"
using mbf;

#line default
#line hidden
#line 2 "d:\C#\MVC\mbf\Views\_ViewImports.cshtml"
using mbf.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90efd60e3c68896e4907c522027302cc21ed2713", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86493a36ab6c9d2984651996eaa42039f1a71e30", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/pages/about.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 1 "d:\C#\MVC\mbf\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("stylesheet", async() => {
                BeginContext(64, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(70, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b4249266526a4852b022cd3ed8b3151f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(122, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(127, 14945, true);
            WriteLiteral(@"

<section class=""collection-heading heading-content "">
    <div class=""container"">
        <div class=""row"">
            <div class=""collection-wrapper"">
                <h1 class=""collection-title""><span>About</span></h1>
                <div class=""breadcrumb-group"">
                    <div class=""breadcrumb clearfix"">
                        <span itemscope="""" itemtype=""http://data-vocabulary.org/Breadcrumb"">
                            <a href=""./index.html"" title=""Sarahmarket 1"" itemprop=""url""><span itemprop=""title"">Home</span></a>
                        </span>
                        <span class=""arrow-space"">/</span>
                        <span itemscope="""" itemtype=""http://data-vocabulary.org/Breadcrumb"">
                            <a href=""./services.html"" title=""Services"" itemprop=""url""><span itemprop=""title"">About</span></a>
                        </span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<div id=""");
            WriteLiteral(@"shopify-section-template-about"" class=""shopify-section"">
    <div class=""about-us style2"">
        <div class=""container page-about"">
            <div class=""row"">
                <div class=""col-md-12 welcome-about-us banners"">
                    <div class=""content-about-us"">
                        <a href=""#"" title=""mbf"">
                            <div class=""image-about-us col-md-12 col-sm-12"">
                                <img class=""img-responsive"" alt=""mbf"" src=""//placehold.it/1650x500"">
                            </div>
                        </a>
                        <div class=""content-about col-md-12 col-sm-12"">
                            <div class=""title-about-us"">
                                <h2>Title</h2>
                            </div>
                            <div class=""des-about-us"">
                                <p>Lorem Khaled Ipsum is a major key to success. Eliptical talk. The key to more success is to get a massage once a week, very important, m");
            WriteLiteral(@"ajor key, cloth talk. Mogul talk. Cloth talk. I’m giving you cloth talk, cloth. Special cloth alert, cut from a special cloth. In life you have to take the trash out, if you have trash in your life, take it out, throw it away, get rid of it, major key. Surround yourself with angels.</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""wpb_wrapper"">
            </div>
        </div>
        <div class=""container about-service"">
            <div class=""container"">
                <div class=""wrap"">
                    <div class=""row"">
                        <div class=""item col-md-4 col-xs-12"">
                            <div class=""item_wrap"">
                                <div class=""image service"">
                                    <img class=""lazyautosizes lazyloaded"" data-sizes=""auto"" src=""//cdn.shopify.com/s/files/1/0058/5370/8399/t/2/assets/Forma_11.png?720"" data-src=""//cdn");
            WriteLiteral(@".shopify.com/s/files/1/0058/5370/8399/t/2/assets/Forma_11.png?720"" sizes=""54px""> </div>
                                <h3>Strategy &amp; Marketing</h3>
                                <div class=""des"">Lorem Khaled Ipsum is a major key to success. Eliptical talk. The key to more success is to get a massage once a week, very important, major key, cloth talk.</div>
                            </div>
                        </div>
                        <div class=""item col-md-4 col-xs-12"">
                            <div class=""item_wrap"">
                                <div class=""image service"">
                                    <img class=""lazyautosizes lazyloaded"" data-sizes=""auto"" src=""//cdn.shopify.com/s/files/1/0058/5370/8399/t/2/assets/Forma_1.png?720"" data-src=""//cdn.shopify.com/s/files/1/0058/5370/8399/t/2/assets/Forma_1.png?720"" sizes=""41px"">
                                </div>
                                <h3>interaction design</h3>
                                <div class=""");
            WriteLiteral(@"des"">Lorem Khaled Ipsum is a major key to success. Eliptical talk. The key to more success is to get a massage once a week, very important, major key, cloth talk.</div>
                            </div>
                        </div>
                        <div class=""item col-md-4 col-xs-12"">
                            <div class=""item_wrap"">
                                <div class=""image service"">
                                    <img class=""lazyautosizes lazyloaded"" data-sizes=""auto"" src=""//cdn.shopify.com/s/files/1/0058/5370/8399/t/2/assets/Shape_1.png?720"" data-src=""//cdn.shopify.com/s/files/1/0058/5370/8399/t/2/assets/Shape_1.png?720"" sizes=""49px"">
                                </div>
                                <h3>WEb Development</h3>
                                <div class=""des"">Lorem Khaled Ipsum is a major key to success. Eliptical talk. The key to more success is to get a massage once a week, very important, major key, cloth talk. </div>
                            </di");
            WriteLiteral(@"v>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""_line""></div>
        <div class=""container about-policy banners"">
            <div class=""container"">
                <div class=""wrap"">
                    <div class=""row"">
                        <div class=""item col-md-4 col-xs-12"">
                            <div class=""item_wrap"">
                                <div class=""image service"">
                                    <a href=""#"" title=""mbf"">
                                        <img class=""img-responsive"" alt=""mbf"" src=""//placehold.it/530X340"">
                                    </a>
                                    <h3>WHAT WE REALLY DO?</h3>
                                    <div class=""des"">Get all the best deals, sales and offers from the best online shopping store in UAE. Sign up now !</div>
                                </div>
                            </div>
         ");
            WriteLiteral(@"               </div>
                        <div class=""item col-md-4 col-xs-12"">
                            <div class=""item_wrap"">
                                <div class=""image service"">
                                    <a href=""#"" title=""mbf"">
                                        <img class=""img-responsive"" alt=""mbf"" src=""//placehold.it/530X340"">
                                    </a>
                                    <h3>OUR VERSION</h3>
                                    <div class=""des"">Get all the best deals, sales and offers from the best online shopping store in UAE. Sign up now !</div>
                                </div>
                            </div>
                        </div>
                        <div class=""item col-md-4 col-xs-12"">
                            <div class=""item_wrap"">
                                <div class=""image service"">
                                    <a href=""#"" title=""mbf"">
                                        <img cl");
            WriteLiteral(@"ass=""img-responsive"" alt=""mbf"" src=""//placehold.it/530X340"">
                                    </a>
                                    <h3>HISTORY OF BEGINNING</h3>
                                    <div class=""des"">Get all the best deals, sales and offers from the best online shopping store in UAE. Sign up now ! </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""our-member"">
        <div class=""container"">
            <div class=""wrap"">
                <div class=""title-about-us"">
                    <h2>Our Member</h2>
                </div>
                <div class=""dshort-des""> Lorem Khaled Ipsum is a major key to success. Eliptical talk. The key to more success is to get a massage once a week </div>
                <div class=""row"">
                    <div class=""col-xl-3 col-lg-3 col-6"">
                  ");
            WriteLiteral(@"      <div class=""item-inner"">
                            <div class=""w-image-box"">
                                <img class=""img-responsive"" alt=""mbf"" src=""//placehold.it/160x160"">
                            </div>
                            <div class=""info-member"">
                                <div class=""item-content"">
                                    <h2 class=""cl-name""><a title=""Jennifer lawrence"" href=""#"">Jennifer lawrence</a></h2>
                                    <p class=""cl-job"">Tech Leader</p>
                                </div>
                                <div class=""socials-wraps "">
                                    <ul>
                                        <li class=""facebook""><a class=""_blank"" href=""#"" target=""_blank""><i class=""fa fa-facebook""></i></a></li>
                                        <li class=""twitter""><a class=""_blank"" href=""#"" target=""_blank""><i class=""fa fa-twitter""></i></a></li>
                                        <li class=""google_pl");
            WriteLiteral(@"us""><a class=""_blank"" href=""#"" target=""_blank""><i class=""fa  fa-google-plus""></i></a></li>
                                        <li class=""dribbble""><a class=""_blank"" href=""#"" target=""_blank""><i class=""fa  fa-dribbble""></i></a></li>
                                        <li class=""linkedin""><a class=""_blank"" href=""#"" target=""_blank""><i class=""fa fa-linkedin""></i></a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-xl-3 col-lg-3 col-6"">
                        <div class=""item-inner"">
                            <div class=""w-image-box"">
                                <img class=""img-responsive"" alt=""mbf"" src=""//placehold.it/160x160"">
                            </div>
                            <div class=""info-member"">
                                <div class=""item-content"">
                                    <h2 class=");
            WriteLiteral(@"""cl-name""><a title=""Jennifer lawrence"" href=""#"">George Scoots</a></h2>
                                    <p class=""cl-job"">Tech Leader</p>
                                </div>
                                <div class=""socials-wraps "">
                                    <ul>
                                        <li class=""facebook""><a class=""_blank"" href=""#"" target=""_blank""><i class=""fa fa-facebook""></i></a></li>
                                        <li class=""twitter""><a class=""_blank"" href=""#"" target=""_blank""><i class=""fa fa-twitter""></i></a></li>
                                        <li class=""google_plus""><a class=""_blank"" href=""#"" target=""_blank""><i class=""fa  fa-google-plus""></i></a></li>
                                        <li class=""dribbble""><a class=""_blank"" href=""#"" target=""_blank""><i class=""fa  fa-dribbble""></i></a></li>
                                        <li class=""linkedin""><a class=""_blank"" href=""#"" target=""_blank""><i class=""fa fa-linkedin""></i></a></li>
      ");
            WriteLiteral(@"                              </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-xl-3 col-lg-3 col-6"">
                        <div class=""item-inner"">
                            <div class=""w-image-box"">
                                <img class=""img-responsive"" alt=""mbf"" src=""//placehold.it/160x160"">
                            </div>
                            <div class=""info-member"">
                                <div class=""item-content"">
                                    <h2 class=""cl-name""><a title=""Jennifer lawrence"" href=""#"">George Scoots</a></h2>
                                    <p class=""cl-job"">Tech Leader</p>
                                </div>
                                <div class=""socials-wraps "">
                                    <ul>
                                        <li class=""facebook""><a class=""_blank"" href=""#"" target=""_blank");
            WriteLiteral(@"""><i class=""fa fa-facebook""></i></a></li>
                                        <li class=""twitter""><a class=""_blank"" href=""#"" target=""_blank""><i class=""fa fa-twitter""></i></a></li>
                                        <li class=""google_plus""><a class=""_blank"" href=""#"" target=""_blank""><i class=""fa  fa-google-plus""></i></a></li>
                                        <li class=""dribbble""><a class=""_blank"" href=""#"" target=""_blank""><i class=""fa  fa-dribbble""></i></a></li>
                                        <li class=""linkedin""><a class=""_blank"" href=""#"" target=""_blank""><i class=""fa fa-linkedin""></i></a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-xl-3 col-lg-3 col-6"">
                        <div class=""item-inner"">
                            <div class=""w-image-box"">
                                <img class=""img-resp");
            WriteLiteral(@"onsive"" alt=""mbf"" src=""//placehold.it/160x160"">
                            </div>
                            <div class=""info-member"">
                                <div class=""item-content"">
                                    <h2 class=""cl-name""><a title=""Jennifer lawrence"" href=""#"">Jennifer lawrence</a></h2>
                                    <p class=""cl-job"">Tech Leader</p>
                                </div>
                                <div class=""socials-wraps "">
                                    <ul>
                                        <li class=""facebook""><a class=""_blank"" href=""#"" target=""_blank""><i class=""fa fa-facebook""></i></a></li>
                                        <li class=""twitter""><a class=""_blank"" href=""#"" target=""_blank""><i class=""fa fa-twitter""></i></a></li>
                                        <li class=""google_plus""><a class=""_blank"" href=""#"" target=""_blank""><i class=""fa  fa-google-plus""></i></a></li>
                                        <li cla");
            WriteLiteral(@"ss=""dribbble""><a class=""_blank"" href=""#"" target=""_blank""><i class=""fa  fa-dribbble""></i></a></li>
                                        <li class=""linkedin""><a class=""_blank"" href=""#"" target=""_blank""><i class=""fa fa-linkedin""></i></a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <style>
        .main-content {
            padding-bottom: 0 !important;
        }
    </style>
</div>
");
            EndContext();
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
