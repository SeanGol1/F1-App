#pragma checksum "C:\Users\seang\source\repos\F1 App\Views\UserPredictions\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "752630dcdd0bc8d2fc3e96a0f5942452b09a80f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserPredictions_Create), @"mvc.1.0.view", @"/Views/UserPredictions/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserPredictions/Create.cshtml", typeof(AspNetCore.Views_UserPredictions_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"752630dcdd0bc8d2fc3e96a0f5942452b09a80f0", @"/Views/UserPredictions/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db96c1fc32c59391eb24e66ccf1b83edce48ebd3", @"/Views/_ViewImports.cshtml")]
    public class Views_UserPredictions_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<F1_App.Models.UserPredictions>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UserPredictions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\seang\source\repos\F1 App\Views\UserPredictions\Create.cshtml"
  
    ViewData["Title"] = "Create";    
    List<Driver> driverList = ViewBag.Drivers;
    int editingNo = 0;
    int count = 1;

    


#line default
#line hidden
            BeginContext(188, 184, true);
            WriteLiteral("<script>\r\n  \r\n</script>\r\n<h2>Create</h2>\r\n\r\n<h4>UserPredictions</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    \r\n    <button class=\"btn btn-primary\" onclick=\"submit()\">AJAX Submit</button>\r\n    ");
            EndContext();
            BeginContext(372, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac8e0336d0794ddca96b415ab6dd1c31", async() => {
                BeginContext(463, 16, true);
                WriteLiteral("View Predictions");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(483, 51, true);
            WriteLiteral("\r\n\r\n    <div class=\"row\">\r\n        <h2 id=\"editNo\">");
            EndContext();
            BeginContext(535, 9, false);
#line 25 "C:\Users\seang\source\repos\F1 App\Views\UserPredictions\Create.cshtml"
                   Write(editingNo);

#line default
#line hidden
            EndContext();
            BeginContext(544, 110, true);
            WriteLiteral("</h2>\r\n        <div class=\"col-md-6\">\r\n            <ol class=\"list-group ui-widget-content\" id=\"DriverList\">\r\n");
            EndContext();
#line 28 "C:\Users\seang\source\repos\F1 App\Views\UserPredictions\Create.cshtml"
                 foreach (var item in driverList)
                {

#line default
#line hidden
            BeginContext(724, 23, true);
            WriteLiteral("                    <li");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 747, "\"", 763, 1);
#line 30 "C:\Users\seang\source\repos\F1 App\Views\UserPredictions\Create.cshtml"
WriteAttributeValue("", 752, @item.Id, 752, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(764, 196, true);
            WriteLiteral(" class=\"list-group-item driverItem\">                        \r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-8\">\r\n                                <h3><b>");
            EndContext();
            BeginContext(961, 22, false);
#line 33 "C:\Users\seang\source\repos\F1 App\Views\UserPredictions\Create.cshtml"
                                  Write(item.StandingsPosition);

#line default
#line hidden
            EndContext();
            BeginContext(983, 7, true);
            WriteLiteral("</b> - ");
            EndContext();
            BeginContext(991, 14, false);
#line 33 "C:\Users\seang\source\repos\F1 App\Views\UserPredictions\Create.cshtml"
                                                                Write(item.GivenName);

#line default
#line hidden
            EndContext();
            BeginContext(1005, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1007, 15, false);
#line 33 "C:\Users\seang\source\repos\F1 App\Views\UserPredictions\Create.cshtml"
                                                                                Write(item.FamilyName);

#line default
#line hidden
            EndContext();
            BeginContext(1022, 43, true);
            WriteLiteral("</h3>\r\n                                <h4>");
            EndContext();
            BeginContext(1066, 13, false);
#line 34 "C:\Users\seang\source\repos\F1 App\Views\UserPredictions\Create.cshtml"
                               Write(item.TeamName);

#line default
#line hidden
            EndContext();
            BeginContext(1079, 43, true);
            WriteLiteral("</h4>\r\n                                <h5>");
            EndContext();
            BeginContext(1123, 11, false);
#line 35 "C:\Users\seang\source\repos\F1 App\Views\UserPredictions\Create.cshtml"
                               Write(item.Points);

#line default
#line hidden
            EndContext();
            BeginContext(1134, 156, true);
            WriteLiteral(" Points</h5>\r\n                            </div>\r\n                            <div class=\"col-md-2\">\r\n                                <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1290, "\"", 1308, 2);
#line 38 "C:\Users\seang\source\repos\F1 App\Views\UserPredictions\Create.cshtml"
WriteAttributeValue("", 1295, item, 1295, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 1302, "_check", 1302, 6, true);
            EndWriteAttribute();
            BeginContext(1309, 245, true);
            WriteLiteral(" name=\"RedFlag\" value=\"Red Flag\">\r\n                                <label for=\"RedFlag\">DNF</label><br>\r\n                            </div>\r\n                            <div class=\"col-md-2\">\r\n                                <input type=\"button\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 1554, "\"", 1569, 1);
#line 42 "C:\Users\seang\source\repos\F1 App\Views\UserPredictions\Create.cshtml"
WriteAttributeValue("", 1561, item.Id, 1561, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1570, "\"", 1589, 2);
#line 42 "C:\Users\seang\source\repos\F1 App\Views\UserPredictions\Create.cshtml"
WriteAttributeValue("", 1575, item.Id, 1575, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 1585, "_add", 1585, 4, true);
            EndWriteAttribute();
            BeginContext(1590, 111, true);
            WriteLiteral(" onClick=\"addDriver(this.id)\" value=\"Add Driver\" /><br />\r\n                                <input type=\"button\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 1701, "\"", 1716, 1);
#line 43 "C:\Users\seang\source\repos\F1 App\Views\UserPredictions\Create.cshtml"
WriteAttributeValue("", 1708, item.Id, 1708, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1717, "\"", 1735, 2);
#line 43 "C:\Users\seang\source\repos\F1 App\Views\UserPredictions\Create.cshtml"
WriteAttributeValue("", 1722, item.Id, 1722, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 1732, "_up", 1732, 3, true);
            EndWriteAttribute();
            BeginContext(1736, 111, true);
            WriteLiteral(" onClick=\"moveDriverUp(this.id)\" value=\"Move Up\" /><br />\r\n                                <input type=\"button\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 1847, "\"", 1862, 1);
#line 44 "C:\Users\seang\source\repos\F1 App\Views\UserPredictions\Create.cshtml"
WriteAttributeValue("", 1854, item.Id, 1854, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1863, "\"", 1876, 1);
#line 44 "C:\Users\seang\source\repos\F1 App\Views\UserPredictions\Create.cshtml"
WriteAttributeValue("", 1868, item.Id, 1868, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1877, 153, true);
            WriteLiteral(" onClick=\"addDriver(this.id)\" value=\"Move Down\" /><br />\r\n                            </div>\r\n                        </div>\r\n                    </li>\r\n");
            EndContext();
#line 48 "C:\Users\seang\source\repos\F1 App\Views\UserPredictions\Create.cshtml"
                }

#line default
#line hidden
            BeginContext(2049, 157, true);
            WriteLiteral("            </ol>\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <ol id=\"PositionList\" class=\"list-group\"></ol>\r\n        </div>\r\n\r\n    </div>\r\n");
            EndContext();
            BeginContext(2303, 23, true);
            WriteLiteral("</div>\r\n\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2326, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f982b27048f84e4197f0e29d94284a1e", async() => {
                BeginContext(2348, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2364, 551, true);
            WriteLiteral(@"
</div>
<script src=""https://code.jquery.com/ui/1.12.1/jquery-ui.js""
        integrity=""sha256-T0Vest3yCU7pafRw9r+settMBX6JkKN06dqBnpQ8d30=""
        crossorigin=""anonymous""></script>
<script>
    
    //When Driver Is clicked add to a list.
    function addDriver(id) {
        var dId = id.substring(0, id.length-4);
        var node = document.getElementById(dId);

        var list = document.getElementById(""PositionList"");
        list.appendChild(node);
        var item = document.createElement(""p"");
        $(item).attr(""id"", """);
            EndContext();
            BeginContext(2916, 5, false);
#line 81 "C:\Users\seang\source\repos\F1 App\Views\UserPredictions\Create.cshtml"
                       Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(2921, 107, true);
            WriteLiteral("\");\r\n        $(item).attr(\"style\", \"visibility:hidden;\");\r\n        $(\"#PositionList\").sortable();\r\n        ");
            EndContext();
            BeginContext(3030, 7, false);
#line 84 "C:\Users\seang\source\repos\F1 App\Views\UserPredictions\Create.cshtml"
    Write(count++);

#line default
#line hidden
            EndContext();
            BeginContext(3038, 1226, true);
            WriteLiteral(@"
        
    }

    function moveDriverUp(id) {
        var node = document.getElementById(id);
        var list = document.getElementById(""PositionList"");
        list.appendChild(node);  
        
      
    }



    function submit() {
        
        var allData = [];


        $('#PositionList li').each(function (i) {
            var data = {};
            var id = this.id;
            var position = i + 1;
            data.name = id;
            data.position = position;
            allData.push(data);
        });

        
        $.ajax({
            type: ""POST"",
            url: ""/UserPredictions/getPosList"",
            contentType: ""application/json; charset=utf-8"",
            data: JSON.stringify(allData),
            success: function () {
                sendToIndex();
                //alert(data.Result);
            },
            dataType: ""json""
        });



        }

    function sendToIndex() {
            $.ajax({
            type: ""GE");
            WriteLiteral("T\",\r\n            url: \"/UserPredictions/Index\",\r\n            success: function () {\r\n                \r\n                //alert(data.Result);\r\n            }\r\n            \r\n        });\r\n    }\r\n</script>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4282, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 142 "C:\Users\seang\source\repos\F1 App\Views\UserPredictions\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<F1_App.Models.UserPredictions> Html { get; private set; }
    }
}
#pragma warning restore 1591
