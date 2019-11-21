#pragma checksum "C:\Users\omarf\Desktop\site\Web\Views\Shared\_CommentForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7a54c63122849bdfcedf474104cd1e6d4953596"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CommentForm), @"mvc.1.0.view", @"/Views/Shared/_CommentForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_CommentForm.cshtml", typeof(AspNetCore.Views_Shared__CommentForm))]
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
#line 1 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_CommentForm.cshtml"
using Web.Utils;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7a54c63122849bdfcedf474104cd1e6d4953596", @"/Views/Shared/_CommentForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"243bef8901b38e9eef9e38f8c66b8f401f171c9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CommentForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<string, string, bool, string>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pure-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(62, 66, true);
            WriteLiteral("        <!-- postId, commentId?, isAnswer, parentCommentId -->\r\n\r\n");
            EndContext();
#line 5 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_CommentForm.cshtml"
   
    string commentId = string.IsNullOrEmpty(Model.Item4) ? Model.Item2 : Model.Item4;
    string commentBoxClass = Model.Item3 ? "asnwer-comment-box" : "root-comment-box";

#line default
#line hidden
            BeginContext(310, 6, true);
            WriteLiteral("\r\n<div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 316, "\"", 345, 2);
#line 10 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_CommentForm.cshtml"
WriteAttributeValue("", 321, Model.Item2, 321, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 333, "-comment-box", 333, 12, true);
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 346, "\"", 370, 1);
#line 10 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_CommentForm.cshtml"
WriteAttributeValue("", 354, commentBoxClass, 354, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(371, 71, true);
            WriteLiteral(">\r\n\r\n    <div style=\"display:grid; grid-template-columns: 1fr 10fr;\">\r\n");
            EndContext();
#line 13 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_CommentForm.cshtml"
          string url = Helper.GetUserPhotoUrl(User); 

#line default
#line hidden
            BeginContext(498, 34, true);
            WriteLiteral("        <div class=\"user-ava\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 532, "\"", 542, 1);
#line 14 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_CommentForm.cshtml"
WriteAttributeValue("", 538, url, 538, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(543, 38, true);
            WriteLiteral(" /></div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(581, 651, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4ba29b86888447792b6f87ca293bdeb", async() => {
                BeginContext(605, 181, true);
                WriteLiteral("\r\n                <textarea class=\"pure-input-1\" placeholder=\"Комментировать...\"></textarea>\r\n                <div class=\"comment-button\" data-bind=\"click: function() { addComment(\'");
                EndContext();
                BeginContext(787, 11, false);
#line 18 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_CommentForm.cshtml"
                                                                                  Write(Model.Item1);

#line default
#line hidden
                EndContext();
                BeginContext(798, 4, true);
                WriteLiteral("\', \'");
                EndContext();
                BeginContext(803, 11, false);
#line 18 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_CommentForm.cshtml"
                                                                                                  Write(Model.Item3);

#line default
#line hidden
                EndContext();
                BeginContext(814, 109, true);
                WriteLiteral("\') }\" style=\"float:left; margin-right:15px;\">\r\n                    Комментировать\r\n                </div>\r\n\r\n");
                EndContext();
#line 22 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_CommentForm.cshtml"
                 if (!string.IsNullOrEmpty(Model.Item2))
                {

#line default
#line hidden
                BeginContext(1000, 194, true);
                WriteLiteral("                    <div style=\"font-size:11px; margin-top:9px; font-weight:bold; cursor:pointer;\"\r\n                         data-bind=\"click: closeAllAnswerCommentBox\">Не комментировать</div>\r\n");
                EndContext();
#line 26 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_CommentForm.cshtml"
                }

#line default
#line hidden
                BeginContext(1213, 12, true);
                WriteLiteral("            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1232, 38, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<string, string, bool, string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
