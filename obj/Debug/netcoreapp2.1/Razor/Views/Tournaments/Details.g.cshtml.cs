#pragma checksum "C:\Users\seang\source\repos\F1 App\Views\Tournaments\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ef97511d454dde02f1eac197e7f8fe9737ac285"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tournaments_Details), @"mvc.1.0.view", @"/Views/Tournaments/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tournaments/Details.cshtml", typeof(AspNetCore.Views_Tournaments_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ef97511d454dde02f1eac197e7f8fe9737ac285", @"/Views/Tournaments/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db96c1fc32c59391eb24e66ccf1b83edce48ebd3", @"/Views/_ViewImports.cshtml")]
    public class Views_Tournaments_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<F1_App.Models.Tournament>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\seang\source\repos\F1 App\Views\Tournaments\Details.cshtml"
  
    ViewData["Title"] = "Details";
    List<Microsoft.AspNetCore.Identity.IdentityUser> userList = ViewBag.UserList;
    List<UserPoints> userPoints = ViewBag.UserPList;
    int count = 0;

#line default
#line hidden
            BeginContext(235, 10, true);
            WriteLiteral("\r\n    <h2>");
            EndContext();
            BeginContext(246, 36, false);
#line 10 "C:\Users\seang\source\repos\F1 App\Views\Tournaments\Details.cshtml"
   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(282, 22, true);
            WriteLiteral("</h2>\r\n    <h5>Admin: ");
            EndContext();
            BeginContext(305, 39, false);
#line 11 "C:\Users\seang\source\repos\F1 App\Views\Tournaments\Details.cshtml"
          Write(Html.DisplayFor(model => model.AdminID));

#line default
#line hidden
            EndContext();
            BeginContext(344, 45, true);
            WriteLiteral("</h5>\r\n<div>\r\n   \r\n    <h3>Standings</h3>\r\n\r\n");
            EndContext();
#line 16 "C:\Users\seang\source\repos\F1 App\Views\Tournaments\Details.cshtml"
     foreach (var item in userPoints.OrderByDescending(u => u.Points))
    {

#line default
#line hidden
            BeginContext(468, 15, true);
            WriteLiteral("        <h3><b>");
            EndContext();
            BeginContext(485, 17, false);
#line 18 "C:\Users\seang\source\repos\F1 App\Views\Tournaments\Details.cshtml"
           Write(count = count + 1);

#line default
#line hidden
            EndContext();
            BeginContext(503, 6, true);
            WriteLiteral("</b>  ");
            EndContext();
            BeginContext(511, 13, false);
#line 18 "C:\Users\seang\source\repos\F1 App\Views\Tournaments\Details.cshtml"
                                     Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(525, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(530, 11, false);
#line 18 "C:\Users\seang\source\repos\F1 App\Views\Tournaments\Details.cshtml"
                                                        Write(item.Points);

#line default
#line hidden
            EndContext();
            BeginContext(542, 14, true);
            WriteLiteral(" Points</h3>\r\n");
            EndContext();
#line 19 "C:\Users\seang\source\repos\F1 App\Views\Tournaments\Details.cshtml"
        
    }

#line default
#line hidden
            BeginContext(573, 21, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(594, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45da636fa93d4a7ebc2a1afe979497d9", async() => {
                BeginContext(640, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 24 "C:\Users\seang\source\repos\F1 App\Views\Tournaments\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            BeginContext(648, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(656, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "083ae016918d4c68b8a5e1b30b222386", async() => {
                BeginContext(678, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(694, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<F1_App.Models.Tournament> Html { get; private set; }
    }
}
#pragma warning restore 1591
