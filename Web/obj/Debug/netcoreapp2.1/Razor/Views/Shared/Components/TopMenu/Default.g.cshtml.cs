#pragma checksum "C:\Users\omarf\Desktop\site\Web\Views\Shared\Components\TopMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "309737415800ab1a4461da40a255a3266582beae"
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
#line 1 "C:\Users\omarf\Desktop\site\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#line 2 "C:\Users\omarf\Desktop\site\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"309737415800ab1a4461da40a255a3266582beae", @"/Views/Shared/Components/TopMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"243bef8901b38e9eef9e38f8c66b8f401f171c9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TopMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.Views.Components.TopMenu.TopMenuViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(53, 206, true);
            WriteLiteral("\n<ul class=\"menu\">\n    <li>\n        <label for=\"drop-1\" class=\"toggle\">Карьера в IT</label>\n        <a href=\"#\" class=\"top-link\">Карьера в IT</a>\n        <input type=\"checkbox\" id=\"drop-1\" />\n\n        <ul>\n");
            EndContext();
#line 10 "C:\Users\omarf\Desktop\site\Web\Views\Shared\Components\TopMenu\Default.cshtml"
             foreach (var career in Model.CareerPosts)
            {

#line default
#line hidden
            BeginContext(328, 21, true);
            WriteLiteral("                <li>\n");
            EndContext();
#line 13 "C:\Users\omarf\Desktop\site\Web\Views\Shared\Components\TopMenu\Default.cshtml"
                      string imagePath = $"https://storage.googleapis.com/youit/{career.Url}/mini.png"; 

#line default
#line hidden
            BeginContext(455, 24, true);
            WriteLiteral("                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 479, "\"", 495, 1);
#line 14 "C:\Users\omarf\Desktop\site\Web\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 485, imagePath, 485, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(496, 24, true);
            WriteLiteral(" />\n                    ");
            EndContext();
            BeginContext(520, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4af99d15ced349b28ee45cf9e5bda86c", async() => {
                BeginContext(592, 12, false);
#line 15 "C:\Users\omarf\Desktop\site\Web\Views\Shared\Components\TopMenu\Default.cshtml"
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
#line 15 "C:\Users\omarf\Desktop\site\Web\Views\Shared\Components\TopMenu\Default.cshtml"
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
            BeginContext(608, 76, true);
            WriteLiteral("\n                    <div style=\"clear: left;\"></div>\n                </li>\n");
            EndContext();
#line 18 "C:\Users\omarf\Desktop\site\Web\Views\Shared\Components\TopMenu\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(698, 219, true);
            WriteLiteral("        </ul>\n    </li>\n\n    <li>\n        <label for=\"drop-2\" class=\"toggle\">Программирование</label>\n        <a href=\"#\" class=\"top-link\">Программирование</a>\n        <input type=\"checkbox\" id=\"drop-2\" />\n        <ul>\n");
            EndContext();
#line 27 "C:\Users\omarf\Desktop\site\Web\Views\Shared\Components\TopMenu\Default.cshtml"
             foreach (var programmingPost in Model.ProgrammingPosts)
            {

#line default
#line hidden
            BeginContext(1000, 21, true);
            WriteLiteral("                <li>\n");
            EndContext();
#line 30 "C:\Users\omarf\Desktop\site\Web\Views\Shared\Components\TopMenu\Default.cshtml"
                      string imagePath = $"https://storage.googleapis.com/youit/{programmingPost.Url}/mini.png"; 

#line default
#line hidden
            BeginContext(1136, 24, true);
            WriteLiteral("                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1160, "\"", 1176, 1);
#line 31 "C:\Users\omarf\Desktop\site\Web\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 1166, imagePath, 1166, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1177, 24, true);
            WriteLiteral(" />\n                    ");
            EndContext();
            BeginContext(1201, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94c9edb8be33452e8b608537ee3e3009", async() => {
                BeginContext(1282, 21, false);
#line 32 "C:\Users\omarf\Desktop\site\Web\Views\Shared\Components\TopMenu\Default.cshtml"
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
#line 32 "C:\Users\omarf\Desktop\site\Web\Views\Shared\Components\TopMenu\Default.cshtml"
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
            BeginContext(1307, 76, true);
            WriteLiteral("\n                    <div style=\"clear: left;\"></div>\n                </li>\n");
            EndContext();
#line 35 "C:\Users\omarf\Desktop\site\Web\Views\Shared\Components\TopMenu\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(1397, 207, true);
            WriteLiteral("        </ul>\n    </li>\n\n    <li>\n        <label for=\"drop-3\" class=\"toggle\">Секреты IT</label>\n        <a href=\"#\" class=\"top-link\">Секреты IT</a>\n        <input type=\"checkbox\" id=\"drop-3\" />\n        <ul>\n");
            EndContext();
#line 44 "C:\Users\omarf\Desktop\site\Web\Views\Shared\Components\TopMenu\Default.cshtml"
             foreach (var juniorPost in Model.JuniorPosts)
            {

#line default
#line hidden
            BeginContext(1677, 17, true);
            WriteLiteral("            <li>\n");
            EndContext();
#line 47 "C:\Users\omarf\Desktop\site\Web\Views\Shared\Components\TopMenu\Default.cshtml"
                  string imagePath = $"https://storage.googleapis.com/youit/{juniorPost.Url}/mini.png"; 

#line default
#line hidden
            BeginContext(1800, 20, true);
            WriteLiteral("                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1820, "\"", 1836, 1);
#line 48 "C:\Users\omarf\Desktop\site\Web\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 1826, imagePath, 1826, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1837, 20, true);
            WriteLiteral(" />\n                ");
            EndContext();
            BeginContext(1857, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0be9933a8269421181fca72119134b52", async() => {
                BeginContext(1933, 16, false);
#line 49 "C:\Users\omarf\Desktop\site\Web\Views\Shared\Components\TopMenu\Default.cshtml"
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
#line 49 "C:\Users\omarf\Desktop\site\Web\Views\Shared\Components\TopMenu\Default.cshtml"
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
            BeginContext(1953, 68, true);
            WriteLiteral("\n                <div style=\"clear: left;\"></div>\n            </li>\n");
            EndContext();
#line 52 "C:\Users\omarf\Desktop\site\Web\Views\Shared\Components\TopMenu\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(2035, 30, true);
            WriteLiteral("        </ul>\n    </li>\n\n</ul>");
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
