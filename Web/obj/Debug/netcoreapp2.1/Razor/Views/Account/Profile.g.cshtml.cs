#pragma checksum "C:\Users\omarf\Desktop\site\Web\Views\Account\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fc2c02fa61c925cb996556a7e87ec619c16df63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Profile), @"mvc.1.0.view", @"/Views/Account/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Profile.cshtml", typeof(AspNetCore.Views_Account_Profile))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fc2c02fa61c925cb996556a7e87ec619c16df63", @"/Views/Account/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"243bef8901b38e9eef9e38f8c66b8f401f171c9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.Controllers.ProfileViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-param", "comments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-param", "likedposts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-param", "editprofile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pure-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\omarf\Desktop\site\Web\Views\Account\Profile.cshtml"
  Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(87, 29, true);
            WriteLiteral("\r\n<div class=\"full-post\">\r\n\r\n");
            EndContext();
#line 6 "C:\Users\omarf\Desktop\site\Web\Views\Account\Profile.cshtml"
     if (User.Identity.IsAuthenticated)
    {
        string c1 = Model.Action == "comments" ? "bold" : "";
        string c3 = Model.Action == "likedposts" ? "bold" : "";
        string c4 = Model.Action == "editprofile" ? "bold" : "";


#line default
#line hidden
            BeginContext(360, 56, true);
            WriteLiteral("        <div class=\"account-menu-wrapper\">\r\n            ");
            EndContext();
            BeginContext(416, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bed1b959152948b19607d6b813885c6c", async() => {
                BeginContext(492, 4, true);
                WriteLiteral("<div");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 496, "\"", 507, 1);
#line 13 "C:\Users\omarf\Desktop\site\Web\Views\Account\Profile.cshtml"
WriteAttributeValue("", 504, c1, 504, 3, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(508, 18, true);
                WriteLiteral(">Комментарии</div>");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-param", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["param"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(530, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(544, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e9db1d5122e4475ab010787a5965fb1", async() => {
                BeginContext(622, 4, true);
                WriteLiteral("<div");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 626, "\"", 637, 1);
#line 14 "C:\Users\omarf\Desktop\site\Web\Views\Account\Profile.cshtml"
WriteAttributeValue("", 634, c3, 634, 3, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(638, 20, true);
                WriteLiteral(">Понравившееся</div>");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-param", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["param"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(662, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(676, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0afc0e9d4d7a4ff69dc8c5179d64d512", async() => {
                BeginContext(755, 4, true);
                WriteLiteral("<div");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 759, "\"", 770, 1);
#line 15 "C:\Users\omarf\Desktop\site\Web\Views\Account\Profile.cshtml"
WriteAttributeValue("", 767, c4, 767, 3, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(771, 14, true);
                WriteLiteral(">Профиль</div>");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-param", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["param"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(789, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
            BeginContext(809, 42, true);
            WriteLiteral("        <div style=\"margin-top:20px;\">\r\n\r\n");
            EndContext();
#line 20 "C:\Users\omarf\Desktop\site\Web\Views\Account\Profile.cshtml"
             if (Model.Action == "comments")
            {
                foreach (var comment in Model.Comments)
                {

#line default
#line hidden
            BeginContext(988, 87, true);
            WriteLiteral("                    <div style=\"margin-bottom:20px;\">\r\n                        <div><b>");
            EndContext();
            BeginContext(1076, 17, false);
#line 25 "C:\Users\omarf\Desktop\site\Web\Views\Account\Profile.cshtml"
                           Write(comment.PostTitle);

#line default
#line hidden
            EndContext();
            BeginContext(1093, 80, true);
            WriteLiteral("</b></div>\r\n                        <div style=\"font-size:13px; color:#808080;\">");
            EndContext();
            BeginContext(1174, 15, false);
#line 26 "C:\Users\omarf\Desktop\site\Web\Views\Account\Profile.cshtml"
                                                               Write(comment.Created);

#line default
#line hidden
            EndContext();
            BeginContext(1189, 67, true);
            WriteLiteral("</div>\r\n                        <div>\r\n                            ");
            EndContext();
            BeginContext(1257, 12, false);
#line 28 "C:\Users\omarf\Desktop\site\Web\Views\Account\Profile.cshtml"
                       Write(comment.Text);

#line default
#line hidden
            EndContext();
            BeginContext(1269, 159, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div style=\"color:red; font-size:13px; font-weight:bold;\">удалить</div>\r\n                    </div>\r\n");
            EndContext();
#line 32 "C:\Users\omarf\Desktop\site\Web\Views\Account\Profile.cshtml"
                }
            }
            else if (Model.Action == "likedposts")
            {
                foreach (var post in Model.Posts)
                {
                    string imagePath = $"https://storage.googleapis.com/youit/{post.Url}/mini.png";
                    string postUrl = "/home/post?=" + post.Url;


#line default
#line hidden
            BeginContext(1767, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1789, "\"", 1804, 1);
#line 41 "C:\Users\omarf\Desktop\site\Web\Views\Account\Profile.cshtml"
WriteAttributeValue("", 1796, postUrl, 1796, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1805, 31, true);
            WriteLiteral(">\r\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1836, "\"", 1852, 1);
#line 42 "C:\Users\omarf\Desktop\site\Web\Views\Account\Profile.cshtml"
WriteAttributeValue("", 1842, imagePath, 1842, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1853, 118, true);
            WriteLiteral(" style=\"float:left; margin-right:15px; margin-bottom:40px;\" />\r\n                        <span style=\"font-size:22px;\">");
            EndContext();
            BeginContext(1972, 10, false);
#line 43 "C:\Users\omarf\Desktop\site\Web\Views\Account\Profile.cshtml"
                                                 Write(post.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1982, 39, true);
            WriteLiteral("</span><br />\r\n                        ");
            EndContext();
            BeginContext(2022, 26, false);
#line 44 "C:\Users\omarf\Desktop\site\Web\Views\Account\Profile.cshtml"
                   Write(Html.Raw(post.TextPreview));

#line default
#line hidden
            EndContext();
            BeginContext(2048, 81, true);
            WriteLiteral("\r\n                    </a>\r\n                    <div style=\"clear:both;\"></div>\r\n");
            EndContext();
#line 47 "C:\Users\omarf\Desktop\site\Web\Views\Account\Profile.cshtml"
                }
            }
            else if (Model.Action == "editprofile")
            {

#line default
#line hidden
            BeginContext(2231, 88, true);
            WriteLiteral("                <div id=\"profile-view\" style=\"position:relative;\">\r\n                    ");
            EndContext();
            BeginContext(2319, 581, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1151927a2c1244d0b81533f9d19ffc2a", async() => {
                BeginContext(2386, 195, true);
                WriteLiteral("\r\n                        <fieldset>\r\n                            <legend>Ваши данные</legend>\r\n                            <p>\r\n                                <input type=\"text\" name=\"userName\"");
                EndContext();
                BeginWriteAttribute("placeholder", " placeholder=\"", 2581, "\"", 2614, 1);
#line 56 "C:\Users\omarf\Desktop\site\Web\Views\Account\Profile.cshtml"
WriteAttributeValue("", 2595, User.Identity.Name, 2595, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2615, 278, true);
                WriteLiteral(@" />
                            </p>

                            <p>
                                <button type=""submit"" class=""pure-button pure-button-active"">Сохранить</button>
                            </p>
                        </fieldset>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2900, 132, true);
            WriteLiteral("\r\n                    <div id=\"photoBox\" style=\"position:absolute; top:50px; right:0;\">\r\n                        <img id=\"userPhoto\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3032, "\"", 3054, 1);
#line 65 "C:\Users\omarf\Desktop\site\Web\Views\Account\Profile.cshtml"
WriteAttributeValue("", 3038, Model.UserPhoto, 3038, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3055, 57, true);
            WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 81 "C:\Users\omarf\Desktop\site\Web\Views\Account\Profile.cshtml"
                           

            }

#line default
#line hidden
            BeginContext(3697, 16, true);
            WriteLiteral("        </div>\r\n");
            EndContext();
#line 85 "C:\Users\omarf\Desktop\site\Web\Views\Account\Profile.cshtml"
    }

#line default
#line hidden
            BeginContext(3720, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.Controllers.ProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
