#pragma checksum "C:\Users\seang\source\repos\F1 App\Views\Drivers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8eb836837616d26d2574c4d3158ec05a7930361"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Drivers_Index), @"mvc.1.0.view", @"/Views/Drivers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Drivers/Index.cshtml", typeof(AspNetCore.Views_Drivers_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8eb836837616d26d2574c4d3158ec05a7930361", @"/Views/Drivers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db96c1fc32c59391eb24e66ccf1b83edce48ebd3", @"/Views/_ViewImports.cshtml")]
    public class Views_Drivers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<F1_App.Models.Driver>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\seang\source\repos\F1 App\Views\Drivers\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(85, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(114, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "669a309169144f8e82f310a967df672a", async() => {
                BeginContext(137, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(151, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(244, 40, false);
#line 16 "C:\Users\seang\source\repos\F1 App\Views\Drivers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(284, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(340, 53, false);
#line 19 "C:\Users\seang\source\repos\F1 App\Views\Drivers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StandingsPosition));

#line default
#line hidden
            EndContext();
            BeginContext(393, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(449, 42, false);
#line 22 "C:\Users\seang\source\repos\F1 App\Views\Drivers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Points));

#line default
#line hidden
            EndContext();
            BeginContext(491, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(547, 44, false);
#line 25 "C:\Users\seang\source\repos\F1 App\Views\Drivers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TeamName));

#line default
#line hidden
            EndContext();
            BeginContext(591, 102, true);
            WriteLiteral("\r\n            </th>\r\n            <th>Place Prediction</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "C:\Users\seang\source\repos\F1 App\Views\Drivers\Index.cshtml"
 foreach (var item in Model) {


#line default
#line hidden
            BeginContext(727, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(788, 39, false);
#line 35 "C:\Users\seang\source\repos\F1 App\Views\Drivers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(827, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(895, 52, false);
#line 38 "C:\Users\seang\source\repos\F1 App\Views\Drivers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.StandingsPosition));

#line default
#line hidden
            EndContext();
            BeginContext(947, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1015, 41, false);
#line 41 "C:\Users\seang\source\repos\F1 App\Views\Drivers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Points));

#line default
#line hidden
            EndContext();
            BeginContext(1056, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1124, 43, false);
#line 44 "C:\Users\seang\source\repos\F1 App\Views\Drivers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TeamName));

#line default
#line hidden
            EndContext();
            BeginContext(1167, 91, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 50 "C:\Users\seang\source\repos\F1 App\Views\Drivers\Index.cshtml"

        
}

#line default
#line hidden
            BeginContext(1273, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<F1_App.Models.Driver>> Html { get; private set; }
    }
}
#pragma warning restore 1591
