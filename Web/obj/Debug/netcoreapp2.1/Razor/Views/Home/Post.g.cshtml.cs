#pragma checksum "C:\Users\omarf\Desktop\site\Web\Views\Home\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76e3dd52d8fb5b772efeff73af8bf3fa2de4da8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Post), @"mvc.1.0.view", @"/Views/Home/Post.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Post.cshtml", typeof(AspNetCore.Views_Home_Post))]
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
#line 2 "C:\Users\omarf\Desktop\site\Web\Views\Home\Post.cshtml"
using System.Text.RegularExpressions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76e3dd52d8fb5b772efeff73af8bf3fa2de4da8f", @"/Views/Home/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"243bef8901b38e9eef9e38f8c66b8f401f171c9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Services.DTOs.PostDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/full-post.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(69, 43, true);
            WriteLiteral("\r\n\r\n<div class=\"box full-post\">\r\n\r\n    <h1>");
            EndContext();
            BeginContext(113, 11, false);
#line 7 "C:\Users\omarf\Desktop\site\Web\Views\Home\Post.cshtml"
   Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(124, 750, true);
            WriteLiteral(@"</h1>

    <div>
        <a href=""#""
           class=""pure-button pure-button-primary"" style=""font-size:14px; background-color:#4c75a3;"">
            Поделиться ВКонтакте <i class=""far fa-share-square""></i>
        </a>
        <a href=""#""
           class=""pure-button pure-button-primary"" style=""font-size:14px; background-color: #898F9C;"">
            Поделиться в Facebook <i class=""far fa-share-square""></i>
        </a> <!-- #4267B2 -->
        <a href=""#""
           class=""pure-button pure-button-primary"" style=""font-size:14px; background-color:#2867B2;"">
            Поделиться LinkedIn <i class=""far fa-share-square""></i>
        </a>

    </div>
    <div class=""post-statistic"">
        <div><i class=""far fa-eye""></i> ");
            EndContext();
            BeginContext(875, 20, false);
#line 25 "C:\Users\omarf\Desktop\site\Web\Views\Home\Post.cshtml"
                                   Write(Model.ViewsFormatted);

#line default
#line hidden
            EndContext();
            BeginContext(895, 52, true);
            WriteLiteral("</div>\r\n        <div><i class=\"far fa-comment\"></i> ");
            EndContext();
            BeginContext(948, 19, false);
#line 26 "C:\Users\omarf\Desktop\site\Web\Views\Home\Post.cshtml"
                                       Write(Model.CommentsCount);

#line default
#line hidden
            EndContext();
            BeginContext(967, 55, true);
            WriteLiteral(" </div>\r\n        <div><i class=\"far fa-thumbs-up\"></i> ");
            EndContext();
            BeginContext(1023, 11, false);
#line 27 "C:\Users\omarf\Desktop\site\Web\Views\Home\Post.cshtml"
                                         Write(Model.Likes);

#line default
#line hidden
            EndContext();
            BeginContext(1034, 58, true);
            WriteLiteral(" </div>\r\n        <div> <i class=\"far fa-thumbs-down\"></i> ");
            EndContext();
            BeginContext(1093, 14, false);
#line 28 "C:\Users\omarf\Desktop\site\Web\Views\Home\Post.cshtml"
                                            Write(Model.Dislikes);

#line default
#line hidden
            EndContext();
            BeginContext(1107, 24, true);
            WriteLiteral("</div>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(1132, 20, false);
#line 30 "C:\Users\omarf\Desktop\site\Web\Views\Home\Post.cshtml"
Write(Html.Raw(Model.Text));

#line default
#line hidden
            EndContext();
            BeginContext(1152, 499, true);
            WriteLiteral(@"

    <h4>Похожие записи</h4>
    <div id=""similar-posts"" style=""display:grid; grid-template-columns: 1fr 1fr 1fr; grid-gap:10px;"">
        <!-- ko foreach: similarPosts -->
        <a data-bind=""attr: { href: url }"">
            <div>
                <img style=""max-width:100%; border-radius:3px;"" data-bind=""attr: { src: image }"" />
                <span data-bind=""text: title"" style=""font-size:20px;""></span>
            </div>
        </a>
        <!-- /ko -->
    </div>


    ");
            EndContext();
            BeginContext(1652, 47, false);
#line 45 "C:\Users\omarf\Desktop\site\Web\Views\Home\Post.cshtml"
Write(await Html.PartialAsync("_PostComments", Model));

#line default
#line hidden
            EndContext();
            BeginContext(1699, 519, true);
            WriteLiteral(@"

    <p></p>
    <h4>Вас также может заинтересовать</h4>
    <div id=""more-posts"" style=""display:grid; grid-template-columns: 1fr 1fr; grid-gap:10px;"">
        <!-- ko foreach: morePosts -->
        <div >
            <img style=""max-width:100%; border-radius:3px;"" data-bind=""attr: { src: image }""  />
            <a data-bind=""attr: { href: url }"">
                <span  style=""font-size:20px;"" data-bind=""text: title""></span>
            </a>
        </div>
        <!-- /ko -->
    </div>

</div>
");
            EndContext();
            BeginContext(2218, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59b590c1bff34c33afea69f875a81035", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("async", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2265, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Services.DTOs.PostDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
