#pragma checksum "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f851b96209d61ced3f6283af4599548aabcec14a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TopMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TopMenu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/TopMenu/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_TopMenu_Default))]
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
#line 1 "C:\Users\omarf\Desktop\site\Web\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#line 2 "C:\Users\omarf\Desktop\site\Web\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f851b96209d61ced3f6283af4599548aabcec14a", @"/Views/Shared/Components/TopMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TopMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.Views.Components.TopMenu.TopMenuViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetPost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(54, 198, true);
            WriteLiteral("\r\n<ul class=\"menu\">\r\n    <li>\r\n        <label for=\"drop-1\" class=\"toggle\">Карьера в IT</label>\r\n        <a href=\"#\" class=\"top-link\">Карьера в IT</a>\r\n        <input type=\"checkbox\" id=\"drop-1\" />\r\n");
            EndContext();
            BeginContext(338, 14, true);
            WriteLiteral("        <ul>\r\n");
            EndContext();
#line 10 "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml"
             foreach (var career in Model.CareerPosts)
            {

#line default
#line hidden
            BeginContext(423, 22, true);
            WriteLiteral("                <li>\r\n");
            EndContext();
#line 13 "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml"
                      string imagePath = $"https://storage.googleapis.com/youit/{career.Url}/mini.png"; 

#line default
#line hidden
            BeginContext(552, 24, true);
            WriteLiteral("                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 576, "\"", 592, 1);
#line 14 "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 582, imagePath, 582, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(593, 25, true);
            WriteLiteral(" />\r\n                    ");
            EndContext();
            BeginContext(618, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c073fff1b7d24c58b6efab10688b9507", async() => {
                BeginContext(693, 12, false);
#line 15 "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml"
                                                                                         Write(career.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-url", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 15 "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml"
                                                                     WriteLiteral(career.Url);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["url"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-url", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["url"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(709, 79, true);
            WriteLiteral("\r\n                    <div style=\"clear: left;\"></div>\r\n                </li>\r\n");
            EndContext();
#line 18 "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(803, 227, true);
            WriteLiteral("        </ul>\r\n    </li>\r\n\r\n    <li>\r\n        <label for=\"drop-2\" class=\"toggle\">Программирование</label>\r\n        <a href=\"#\" class=\"top-link\">Программирование</a>\r\n        <input type=\"checkbox\" id=\"drop-2\" />\r\n        <ul>\r\n");
            EndContext();
#line 27 "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml"
             foreach (var programmingPost in Model.ProgrammingPosts)
            {

#line default
#line hidden
            BeginContext(1115, 22, true);
            WriteLiteral("                <li>\r\n");
            EndContext();
#line 30 "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml"
                      string imagePath = $"https://storage.googleapis.com/youit/{programmingPost.Url}/mini.png"; 

#line default
#line hidden
            BeginContext(1253, 24, true);
            WriteLiteral("                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1277, "\"", 1293, 1);
#line 31 "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 1283, imagePath, 1283, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1294, 25, true);
            WriteLiteral(" />\r\n                    ");
            EndContext();
            BeginContext(1319, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09a8beb637d140a2810e164c5f81a06a", async() => {
                BeginContext(1403, 21, false);
#line 32 "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml"
                                                                                                  Write(programmingPost.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-url", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 32 "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml"
                                                                     WriteLiteral(programmingPost.Url);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["url"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-url", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["url"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1428, 79, true);
            WriteLiteral("\r\n                    <div style=\"clear: left;\"></div>\r\n                </li>\r\n");
            EndContext();
#line 35 "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(1522, 215, true);
            WriteLiteral("        </ul>\r\n    </li>\r\n\r\n    <li>\r\n        <label for=\"drop-3\" class=\"toggle\">Секреты IT</label>\r\n        <a href=\"#\" class=\"top-link\">Секреты IT</a>\r\n        <input type=\"checkbox\" id=\"drop-3\" />\r\n        <ul>\r\n");
            EndContext();
#line 44 "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml"
             foreach (var juniorPost in Model.JuniorPosts)
            {

#line default
#line hidden
            BeginContext(1812, 18, true);
            WriteLiteral("            <li>\r\n");
            EndContext();
#line 47 "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml"
                  string imagePath = $"https://storage.googleapis.com/youit/{juniorPost.Url}/mini.png"; 

#line default
#line hidden
            BeginContext(1937, 20, true);
            WriteLiteral("                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1957, "\"", 1973, 1);
#line 48 "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 1963, imagePath, 1963, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1974, 21, true);
            WriteLiteral(" />\r\n                ");
            EndContext();
            BeginContext(1995, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15f19349fc5543a5a05548c39bb155fe", async() => {
                BeginContext(2074, 16, false);
#line 49 "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml"
                                                                                         Write(juniorPost.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-url", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml"
                                                                 WriteLiteral(juniorPost.Url);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["url"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-url", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["url"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2094, 71, true);
            WriteLiteral("\r\n                <div style=\"clear: left;\"></div>\r\n            </li>\r\n");
            EndContext();
#line 52 "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(2180, 33, true);
            WriteLiteral("        </ul>\r\n    </li>\r\n\r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.Views.Components.TopMenu.TopMenuViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
