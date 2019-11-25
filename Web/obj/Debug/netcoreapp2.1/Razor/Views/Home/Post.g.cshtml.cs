#pragma checksum "C:\Users\omarf\Desktop\site\Web\Views\Home\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e612d323bf7084ad6f7e4730327da78aff3f8cd2"
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
using Web.Utils;

#line default
#line hidden
#line 3 "C:\Users\omarf\Desktop\site\Web\Views\Home\Post.cshtml"
using System.Text.RegularExpressions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e612d323bf7084ad6f7e4730327da78aff3f8cd2", @"/Views/Home/Post.cshtml")]
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
            BeginContext(87, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\omarf\Desktop\site\Web\Views\Home\Post.cshtml"
  
    string thumbUpClass = "noReaction";
    string thumbDownClass = "noReaction";

    if (User.Identity.IsAuthenticated)
    {
        string userId = Helper.GetUserId(User);
        if (Model.WhoLiked.Contains(userId))
        {
            thumbUpClass = "liked";
        }
        else if (Model.WhoDisliked.Contains(userId))
        {
            thumbDownClass = "disliked";
        }
    }

#line default
#line hidden
            BeginContext(508, 39, true);
            WriteLiteral("<div class=\"box full-post\">\r\n\r\n    <h1>");
            EndContext();
            BeginContext(548, 11, false);
#line 24 "C:\Users\omarf\Desktop\site\Web\Views\Home\Post.cshtml"
   Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(559, 804, true);
            WriteLiteral(@"</h1>

    <div>
        <a href=""#""
           class=""pure-button pure-button-primary"" style=""font-size:14px; background-color:#4c75a3; margin-bottom:3px;"">
            Поделиться ВКонтакте <i class=""far fa-share-square""></i>
        </a>
        <a href=""#""
           class=""pure-button pure-button-primary"" style=""font-size:14px; background-color: #898F9C; margin-bottom:3px;"">
            Поделиться в Facebook <i class=""far fa-share-square""></i>
        </a> <!-- #4267B2 -->
        <a href=""#""
           class=""pure-button pure-button-primary"" style=""font-size:14px; background-color:#2867B2; margin-bottom:3px;"">
            Поделиться LinkedIn <i class=""far fa-share-square""></i>
        </a>

    </div>
    <div id=""post-statistic"">
        <div><i class=""far fa-eye""></i> ");
            EndContext();
            BeginContext(1364, 20, false);
#line 42 "C:\Users\omarf\Desktop\site\Web\Views\Home\Post.cshtml"
                                   Write(Model.ViewsFormatted);

#line default
#line hidden
            EndContext();
            BeginContext(1384, 78, true);
            WriteLiteral("</div>\r\n        <div><a href=\"#begin-comments\"><i class=\"far fa-comment\"></i> ");
            EndContext();
            BeginContext(1463, 19, false);
#line 43 "C:\Users\omarf\Desktop\site\Web\Views\Home\Post.cshtml"
                                                                 Write(Model.CommentsCount);

#line default
#line hidden
            EndContext();
            BeginContext(1482, 43, true);
            WriteLiteral("</a> </div>\r\n\r\n        <div id=\"post-likes\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1525, "\"", 1546, 1);
#line 45 "C:\Users\omarf\Desktop\site\Web\Views\Home\Post.cshtml"
WriteAttributeValue("", 1533, thumbUpClass, 1533, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1547, 41, true);
            WriteLiteral(" data-bind=\"click: function() { setLike(\'");
            EndContext();
            BeginContext(1589, 8, false);
#line 45 "C:\Users\omarf\Desktop\site\Web\Views\Home\Post.cshtml"
                                                                                      Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1597, 83, true);
            WriteLiteral("\') }\" style=\"cursor:pointer;\">\r\n            <i class=\"far fa-thumbs-up\"></i> <span>");
            EndContext();
            BeginContext(1681, 11, false);
#line 46 "C:\Users\omarf\Desktop\site\Web\Views\Home\Post.cshtml"
                                              Write(Model.Likes);

#line default
#line hidden
            EndContext();
            BeginContext(1692, 56, true);
            WriteLiteral("</span>\r\n        </div>\r\n        <div id=\"post-dislikes\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1748, "\"", 1771, 1);
#line 48 "C:\Users\omarf\Desktop\site\Web\Views\Home\Post.cshtml"
WriteAttributeValue("", 1756, thumbDownClass, 1756, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1772, 44, true);
            WriteLiteral(" data-bind=\"click: function() { setDislike(\'");
            EndContext();
            BeginContext(1817, 8, false);
#line 48 "C:\Users\omarf\Desktop\site\Web\Views\Home\Post.cshtml"
                                                                                              Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1825, 85, true);
            WriteLiteral("\') }\" style=\"cursor:pointer;\">\r\n            <i class=\"far fa-thumbs-down\"></i> <span>");
            EndContext();
            BeginContext(1911, 14, false);
#line 49 "C:\Users\omarf\Desktop\site\Web\Views\Home\Post.cshtml"
                                                Write(Model.Dislikes);

#line default
#line hidden
            EndContext();
            BeginContext(1925, 41, true);
            WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(1967, 20, false);
#line 52 "C:\Users\omarf\Desktop\site\Web\Views\Home\Post.cshtml"
Write(Html.Raw(Model.Text));

#line default
#line hidden
            EndContext();
            BeginContext(1987, 8, true);
            WriteLiteral("\r\n\r\n    ");
            EndContext();
            BeginContext(1996, 47, false);
#line 54 "C:\Users\omarf\Desktop\site\Web\Views\Home\Post.cshtml"
Write(await Html.PartialAsync("_PostComments", Model));

#line default
#line hidden
            EndContext();
            BeginContext(2043, 548, true);
            WriteLiteral(@"

    <p></p>
    <h4>Вас также может заинтересовать</h4>
    <div id=""more-posts"" style=""display:grid; grid-template-columns: 1fr 1fr; grid-gap:10px;"">
        <!-- ko foreach: morePosts -->
        <div style=""margin-bottom:30px;"">
            <a data-bind=""attr: { href: url }"">
                <img style=""max-width:100%; border-radius:3px;"" data-bind=""attr: { src: image }"" />
                <span style=""font-size:20px;"" data-bind=""text: title""></span>
            </a>
        </div>
        <!-- /ko -->
    </div>

</div>
");
            EndContext();
            BeginContext(2591, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e50e9de69d6d40e7a1e55d516af56ee6", async() => {
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
            BeginContext(2638, 2, true);
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
