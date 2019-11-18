using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Common;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.AppServices;
using Services.DTOs;
using Services.Utils;

namespace Web.Controllers
{
    public class ProfileViewModel
    {
        public List<CommentPreviewDto> Comments { get; set; }
        public List<PostPreviewDto> Posts { get; set; }
        public List<PostPreviewDto> Bookmarks { get; set; }


        public string Action { get; set; }

        public string UserPhoto { get; set; }
    }

    public class AccountController : BaseController
    {
        private UserService _userService = new UserService();

        public IActionResult SignInExternal(string externalProvider)
        {
            string returnUrl = Request.Headers["Referer"].ToString();

            return Challenge(new AuthenticationProperties()
            {
                RedirectUri = Url.Action(nameof(LoginCallback), new { returnUrl })
            },
            externalProvider);
        }

        public async Task<IActionResult> SignOut()
        {
            string returnUrl = Request.Headers["Referer"].ToString();
            
            await HttpContext.SignOutAsync();

            if (returnUrl.Contains("profile", StringComparison.InvariantCultureIgnoreCase))
            {
                return Redirect("/home/index");
            }
            else
            {
                return Redirect(returnUrl);
            }
        }

        public async Task<IActionResult> LoginCallback(string returnUrl)
        {
            Claim nameIdentifier = HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);
            Claim name = HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name);
            string type = HttpContext.User.Identity.AuthenticationType;

            Claim pictureClaim = HttpContext.User.FindFirst("userProfileImage");
            string userPictureUrl = pictureClaim != null ? 
                pictureClaim.Value :
                Constants.NoPhoto;

            Result<UserIdDto> result = await _userService.CreateUserAsync(nameIdentifier.Value, name.Value, type, userPictureUrl);

            var claims = new ClaimsIdentity(type);
            claims.AddClaims(HttpContext.User.Claims);
            claims.AddClaim(new Claim(ClaimTypes.PrimarySid, result.Value.UserID));

            await HttpContext.SignInAsync("Cookies", new ClaimsPrincipal(claims));

            return Redirect(returnUrl);
        }

        [Authorize]
        public async Task<IActionResult> Edit(string userName)
        {


            return View();
        }

        [Authorize]
        public async Task<IActionResult> Profile(string param = "comments")
        {
            var model = new ProfileViewModel()
            {
                Action = param, UserPhoto = base.UserPhotoUrl
            };

            //if (param == "comments")
            //    model.Comments = await new CommentService().GetUserCommentsAsync(UserId);
            //else 
            if (param == "archive")
                model.Bookmarks = await new PostService().GetUserBookmarksAsync(UserId);
            else if (param == "likedposts")
                model.Posts = await new UserService().GetLikedPosts(UserId);
          
            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> AddToBookmarks([FromBody]Test test)
        {
            var service = new PostService();
            var result = await service.AddPostToBookMarksAsync(test.PostId, UserId);
            return FromResult(result);
        }

        [Authorize]
        public async Task<IActionResult> GetProfileComments()
        {
            var comments = await new CommentService().GetUserCommentsAsync(UserId);
            return new JsonResult(comments);
        }

        [Authorize]
        public async Task<IActionResult> DeleteComment([FromBody]DeleteCommentDto comment)
        {
            var service = new PostService();
            var result = await service.DeleteCommentAsync(comment, UserId);
            return FromResult(result);
        }

        public class Test
        {
            public string PostId { get; set; }
        }
    }
}