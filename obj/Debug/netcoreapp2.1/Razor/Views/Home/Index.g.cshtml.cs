#pragma checksum "C:\Users\seang\source\repos\F1 App\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8e9269dbc2ca1e3df0b832259ce77da34de3604"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\seang\source\repos\F1 App\Views\_ViewImports.cshtml"
using F1_App;

#line default
#line hidden
#line 2 "C:\Users\seang\source\repos\F1 App\Views\_ViewImports.cshtml"
using F1_App.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8e9269dbc2ca1e3df0b832259ce77da34de3604", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db96c1fc32c59391eb24e66ccf1b83edce48ebd3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tournaments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\seang\source\repos\F1 App\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Race CRace = ViewBag.Race;
    List<Driver> Top5Drivers = ViewBag.DriverList;
    List<Tournament> TourList = ViewBag.TournList;

#line default
#line hidden
            BeginContext(181, 75, true);
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-sm-8\">\r\n        <h4>Next Race : ");
            EndContext();
            BeginContext(257, 14, false);
#line 11 "C:\Users\seang\source\repos\F1 App\Views\Home\Index.cshtml"
                   Write(CRace.RaceName);

#line default
#line hidden
            EndContext();
            BeginContext(271, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(275, 13, false);
#line 11 "C:\Users\seang\source\repos\F1 App\Views\Home\Index.cshtml"
                                     Write(CRace.Country);

#line default
#line hidden
            EndContext();
            BeginContext(288, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(292, 10, false);
#line 11 "C:\Users\seang\source\repos\F1 App\Views\Home\Index.cshtml"
                                                      Write(CRace.Date);

#line default
#line hidden
            EndContext();
            BeginContext(302, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(304, 10, false);
#line 11 "C:\Users\seang\source\repos\F1 App\Views\Home\Index.cshtml"
                                                                  Write(CRace.Time);

#line default
#line hidden
            EndContext();
            BeginContext(314, 143, true);
            WriteLiteral("</h4>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        <ol class=\"list-group ui-widget-content\" id=\"DriverList\">\r\n");
            EndContext();
#line 18 "C:\Users\seang\source\repos\F1 App\Views\Home\Index.cshtml"
             foreach (var item in Top5Drivers)
            {

#line default
#line hidden
            BeginContext(520, 19, true);
            WriteLiteral("                <li");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 539, "\"", 555, 1);
#line 20 "C:\Users\seang\source\repos\F1 App\Views\Home\Index.cshtml"
WriteAttributeValue("", 544, @item.Id, 544, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(556, 159, true);
            WriteLiteral(" class=\"list-group-item driverItem\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-xs-6\">\r\n                            <p><b>");
            EndContext();
            BeginContext(716, 22, false);
#line 23 "C:\Users\seang\source\repos\F1 App\Views\Home\Index.cshtml"
                             Write(item.StandingsPosition);

#line default
#line hidden
            EndContext();
            BeginContext(738, 7, true);
            WriteLiteral("</b> - ");
            EndContext();
            BeginContext(746, 14, false);
#line 23 "C:\Users\seang\source\repos\F1 App\Views\Home\Index.cshtml"
                                                           Write(item.GivenName);

#line default
#line hidden
            EndContext();
            BeginContext(760, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(762, 15, false);
#line 23 "C:\Users\seang\source\repos\F1 App\Views\Home\Index.cshtml"
                                                                           Write(item.FamilyName);

#line default
#line hidden
            EndContext();
            BeginContext(777, 117, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"col-xs-3\">\r\n                            <p>");
            EndContext();
            BeginContext(895, 13, false);
#line 26 "C:\Users\seang\source\repos\F1 App\Views\Home\Index.cshtml"
                          Write(item.TeamName);

#line default
#line hidden
            EndContext();
            BeginContext(908, 117, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"col-xs-3\">\r\n                            <p>");
            EndContext();
            BeginContext(1026, 11, false);
#line 29 "C:\Users\seang\source\repos\F1 App\Views\Home\Index.cshtml"
                          Write(item.Points);

#line default
#line hidden
            EndContext();
            BeginContext(1037, 96, true);
            WriteLiteral(" Points</p>\r\n                        </div>\r\n                    </div>\r\n                </li>\r\n");
            EndContext();
#line 33 "C:\Users\seang\source\repos\F1 App\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1148, 55, true);
            WriteLiteral("        </ol>\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n");
            EndContext();
#line 37 "C:\Users\seang\source\repos\F1 App\Views\Home\Index.cshtml"
         if (User.Identity.IsAuthenticated)
        {


#line default
#line hidden
            BeginContext(1261, 27, true);
            WriteLiteral("            <h2>My Points: ");
            EndContext();
            BeginContext(1289, 14, false);
#line 40 "C:\Users\seang\source\repos\F1 App\Views\Home\Index.cshtml"
                      Write(ViewBag.Points);

#line default
#line hidden
            EndContext();
            BeginContext(1303, 44, true);
            WriteLiteral("</h2>\r\n            <ul class=\"list-group\">\r\n");
            EndContext();
#line 42 "C:\Users\seang\source\repos\F1 App\Views\Home\Index.cshtml"
                 foreach (var item in TourList)
                {

#line default
#line hidden
            BeginContext(1415, 50, true);
            WriteLiteral("                    <li>\r\n                        ");
            EndContext();
            BeginContext(1465, 112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "523fb80fe88d41c4879a100f87258944", async() => {
                BeginContext(1554, 4, true);
                WriteLiteral("<h2>");
                EndContext();
                BeginContext(1559, 9, false);
#line 45 "C:\Users\seang\source\repos\F1 App\Views\Home\Index.cshtml"
                                                                                                                Write(item.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1568, 5, true);
                WriteLiteral("</h2>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 45 "C:\Users\seang\source\repos\F1 App\Views\Home\Index.cshtml"
                                                                                           WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1577, 29, true);
            WriteLiteral("\r\n                    </li>\r\n");
            EndContext();
#line 47 "C:\Users\seang\source\repos\F1 App\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1625, 19, true);
            WriteLiteral("            </ul>\r\n");
            EndContext();
#line 49 "C:\Users\seang\source\repos\F1 App\Views\Home\Index.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1680, 57, true);
            WriteLiteral("            <ul class=\"list-group\">\r\n                <li>");
            EndContext();
            BeginContext(1737, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e42ed5af92147ec96d576228b55994f", async() => {
                BeginContext(1813, 8, true);
                WriteLiteral("Register");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1825, 27, true);
            WriteLiteral("</li>\r\n                <li>");
            EndContext();
            BeginContext(1852, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "327543524345420f881f9ec334cf78e1", async() => {
                BeginContext(1925, 5, true);
                WriteLiteral("Login");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1934, 26, true);
            WriteLiteral("</li>\r\n            </ul>\r\n");
            EndContext();
#line 56 "C:\Users\seang\source\repos\F1 App\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1971, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
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
