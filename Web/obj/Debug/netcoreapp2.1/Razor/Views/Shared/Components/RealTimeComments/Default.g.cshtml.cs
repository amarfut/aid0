#pragma checksum "C:\Users\omarf\Desktop\site\Web\Views\Shared\Components\RealTimeComments\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17fb0362555fabbc6444935d3d5d55be1c193ef2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_RealTimeComments_Default), @"mvc.1.0.view", @"/Views/Shared/Components/RealTimeComments/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/RealTimeComments/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_RealTimeComments_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17fb0362555fabbc6444935d3d5d55be1c193ef2", @"/Views/Shared/Components/RealTimeComments/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"243bef8901b38e9eef9e38f8c66b8f401f171c9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_RealTimeComments_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Services.DTOs.CommentPreviewDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 82, true);
            WriteLiteral("\r\n    <span style=\"font-size:22px;\">&nbsp; Что сейчас обсуждают?</span>\r\n<p></p>\r\n");
            EndContext();
#line 5 "C:\Users\omarf\Desktop\site\Web\Views\Shared\Components\RealTimeComments\Default.cshtml"
 foreach (var comment in Model)
{

#line default
#line hidden
            BeginContext(164, 270, true);
            WriteLiteral(@"    <div style=""margin-top:30px;"">
        <img class=""comment-ava"" style=""float:left;margin-right:10px; margin-top:5px;"" src=""https://storage.googleapis.com/youit/users/nophoto.jpg"" />
        <span style=""font-size:15px; "">
            <span style=""color:#2d66a3;"">");
            EndContext();
            BeginContext(435, 16, false);
#line 10 "C:\Users\omarf\Desktop\site\Web\Views\Shared\Components\RealTimeComments\Default.cshtml"
                                    Write(comment.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(451, 34, true);
            WriteLiteral("</span> <br />\r\n            <span>");
            EndContext();
            BeginContext(486, 17, false);
#line 11 "C:\Users\omarf\Desktop\site\Web\Views\Shared\Components\RealTimeComments\Default.cshtml"
             Write(comment.PostTitle);

#line default
#line hidden
            EndContext();
            BeginContext(503, 68, true);
            WriteLiteral("</span>\r\n        </span>\r\n        <div style=\"clear:both\"></div>\r\n\r\n");
            EndContext();
#line 15 "C:\Users\omarf\Desktop\site\Web\Views\Shared\Components\RealTimeComments\Default.cshtml"
          
            int last = comment.Text.Length > 120 ? 120 : comment.Text.Length;
            string url = $"/home/post/?url={comment.PostUrl}#{comment.CommentId}";
        

#line default
#line hidden
            BeginContext(757, 89, true);
            WriteLiteral("        <div style=\"font-size:14px; padding-top:5px; font-style:italic;\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 846, "\"", 857, 1);
#line 20 "C:\Users\omarf\Desktop\site\Web\Views\Shared\Components\RealTimeComments\Default.cshtml"
WriteAttributeValue("", 853, url, 853, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(858, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(860, 31, false);
#line 20 "C:\Users\omarf\Desktop\site\Web\Views\Shared\Components\RealTimeComments\Default.cshtml"
                      Write(comment.Text.Substring(0, last));

#line default
#line hidden
            EndContext();
            BeginContext(891, 37, true);
            WriteLiteral("...</a>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 23 "C:\Users\omarf\Desktop\site\Web\Views\Shared\Components\RealTimeComments\Default.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Services.DTOs.CommentPreviewDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
