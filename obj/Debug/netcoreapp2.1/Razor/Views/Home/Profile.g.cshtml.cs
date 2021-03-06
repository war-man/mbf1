#pragma checksum "d:\C#\MVC\mbf\Views\Home\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1bb16c79e791b4b5b9b2bb2d0a06d2b8302e137"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Profile), @"mvc.1.0.view", @"/Views/Home/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Profile.cshtml", typeof(AspNetCore.Views_Home_Profile))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1bb16c79e791b4b5b9b2bb2d0a06d2b8302e137", @"/Views/Home/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86493a36ab6c9d2984651996eaa42039f1a71e30", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2963, true);
            WriteLiteral(@"		<main class=""main-content"" id=""MainContent"" role=""main"">
			<section class=""collection-heading heading-content "">
				<div class=""container"">
					<div class=""row"">
						<div class=""collection-wrapper"">
							<h1 class=""collection-title""><span>My Account</span></h1>
							<div class=""breadcrumb-group"">
								<div class=""breadcrumb clearfix"">
									<span itemscope="""" itemtype=""http://data-vocabulary.org/Breadcrumb"">
										<a href=""index.html"" title=""Bridal 1"" itemprop=""url"">
											<span itemprop=""title"">Home</span>
										</a>
									</span>
									<span class=""arrow-space"">/</span>
									<span itemscope="""" itemtype=""http://data-vocabulary.org/Breadcrumb"">
										<a href=""index.html"" title=""Logout"" itemprop=""url"">
											<span itemprop=""title"">Logout</span>
										</a>
									</span>
								</div>
							</div>
						</div>
					</div>
				</div>
			</section>
			<section class=""account-content"">
				<div class=""account-content-wrapper"">
				");
            WriteLiteral(@"	<div class=""container"">
						<div class=""row"">
							<div class=""account-content-inner"">
								<div id=""customer-account"">
									<div id=""customer_sidebar"" class=""col-sm-3 col-md-3"">
										<h3 class=""sb-title"">ACCOUNT DETAILS</h3>
										<div class=""sb-group"">
											<p class=""customer-name"">Jin Alkaid</p>
											<p class=""email note"">jin@gmail.com</p>
											<div class=""address note"">
												<p>Ung Van Khiem</p>
												<p>Ho Chi Minh city, Vietnam</p>
												<p>123</p>
												<p></p>
												<a id=""view_address"" href=""addresses.html""><i class=""fa fa-bookmark-o""></i><span>View Addresses</span></a>
											</div>
										</div>
										<!--End sb-group-account -->
									</div>
									<div id=""customer_orders"" class=""col-sm-9 col-md-9"">
										<table>
											<thead>
												<tr>
													<th class=""order_number"">Order</th>
													<th class=""date"">Date</th>
													<th class=""payment_status"">Payment ");
            WriteLiteral(@"Status</th>
													<th class=""fulfillment_status"">Fulfillment Status</th>
													<th class=""total"">Total</th>
												</tr>
											</thead>
											<tbody>
												<tr class=""odd "">
													<td class=""td-name""><a href=""order.html"" title="""">#1001</a></td>
													<td class=""td-note""><span class=""note"">07 Jun 00:14</span></td>
													<td class=""td-authorized""><span class=""status_authorized"">Authorized</span></td>
													<td class=""td-unfulfilled""><span class=""status_unfulfilled"">Unfulfilled</span></td>
													<td class=""td-total""><span class=""total"" style=""font-family:'currencies'""><span class=""money"" data-currency-usd=""$292.90"">$292.90</span></span>
													</td>
												</tr>
											</tbody>
										</table>
									</div>
								</div>
							</div>
						</div>
					</div>
				</div>
			</section>
		</main>");
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
