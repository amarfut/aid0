#pragma checksum "C:\Users\omarf\Desktop\site\Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f86ce30936a3513b11bce92f5ac766795d7fc76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f86ce30936a3513b11bce92f5ac766795d7fc76", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"243bef8901b38e9eef9e38f8c66b8f401f171c9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Services.DTOs.PostPreviewDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 3720, true);
            WriteLiteral(@"

<!-- ko foreach: posts -->
    <div class=""box content"">
        <img style=""max-width:100%"" data-bind=""attr: { src: imageUrl }"" />
        <div class=""post-button-wrapper"">
            <div><i class=""far fa-eye""></i> <span data-bind=""text: viewsCount""></span></div>
            <a data-bind=""click: $parent.showComments""> <div><i class=""far fa-comment""></i> <span data-bind=""text: commentsCount""></span></div></a>
            <a data-bind=""click: $parent.like""><div><i class=""far fa-thumbs-up""></i> <span data-bind=""text: likesCount""></span></div></a>
            <a data-bind=""click: $parent.dislike""><div><i class=""far fa-thumbs-down""></i> <span data-bind=""text: dislikesCount""></span></div></a>
    </div>
    <a data-bind=""attr: { href: postUrl }"">
        <h3 data-bind=""text: title""></h3>
    </a>
</div>
<!-- /ko -->

<div class=""box more-posts-button"">
    <a href=""#"" data-bind=""click: addPosts, visible: morePostsButtonVisible""><u>загрузить больше постов</u></a>
    <h3 data-bind=""visible: e");
            WriteLiteral(@"ndPostsTextVisible"">Извините, посты закончились</h3>
</div>

<script>

    class Post {
        constructor(id, title, postUrl, viewsCount, commentsCount, likesCount, dislikesCount) {
            this.id = id;
            this.title = title;
            this.viewsCount = viewsCount > 1000 ? Math.floor(viewsCount / 1000) + 'k' : viewsCount;
            this.commentsCount = commentsCount;
            this.likesCount = ko.observable(likesCount);
            this.dislikesCount = ko.observable(dislikesCount);
            this.imageUrl = 'https://storage.cloud.google.com/youit/' + postUrl + '/thumbnail.png';
            this.postUrl = '/home/post?url=' + postUrl;
        }
    }

    function AppViewModel() {
        let self = this;
        self.posts = ko.observableArray([]);
        self.morePostsButtonVisible = ko.observable(true);
        self.endPostsTextVisible = ko.observable(false);

        self.like = function (post) {
            self.setReaction(post.id, true);
        }

  ");
            WriteLiteral(@"      self.dislike = function (post) {
            self.setReaction(post.id, false);
        }

        self.showComments = function (post) {
            window.location.replace(post.postUrl + '#begin-comments');
        }

        self.setReaction = function (postId, liked) {
            $.ajax({
                url: '/home/setpostreaction',
                type: 'POST',
                contentType: ""application/json"",
                data: JSON.stringify({ PostId: postId, Liked: liked }),
                success: (data) => {
                    const post = self.posts().find(p => p.id === postId);
                    post.likesCount(data.likes);
                    post.dislikesCount(data.dislikes);
                },
                error: (error) => {
                    if (error.status === 403) {
                        $('#authorizeModal').modal(""show"");
                    }
                }
            });
        }

        self.addPosts = function () {
            let s");
            WriteLiteral(@"kip = self.posts().length;
            $.get('/home/loadposts?skip=' + skip, function (posts) {
                if (!posts || posts.length === 0) {
                    self.morePostsButtonVisible(false);
                    self.endPostsTextVisible(true);
                    return;
                }

                for (let post of posts) {
                    self.posts.push(new Post(post.id, post.title, post.url, post.viewsCount, post.commentsCount, post.likesCount, post.dislikesCount));
                }
            });
        };

        self.addPosts();
    }
    ko.applyBindings(new AppViewModel());
</script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Services.DTOs.PostPreviewDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
