using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.AppServices;
using Services.DTOs;
using Services.Utils;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : BaseController
    {
        private PostService _postService = new PostService();

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IEnumerable<PostPreviewDto>> LoadPosts(int skip)
        {
            return await _postService.GetPostPreviews(skip);
        }

        public async Task<IActionResult> Post(string url)
        {
            var service = new PostService();
            var post = await service.GetPost(url);

            //TODO: introduce UI services layer and move it to there and refactor

            if (HttpContext.User.Identity.IsAuthenticated)
            {
                string userId = UserId;

                foreach (var comment in post.Comments)
                {
                    if (comment.WhoLiked.Contains(userId))
                        comment.UserReaction = UserReaction.Liked;
                    else if (comment.WhoDisliked.Contains(userId))
                        comment.UserReaction = UserReaction.Disliked;
                    else comment.UserReaction = UserReaction.None;

                    foreach (var answer in comment.Answers)
                    {
                        if (answer.WhoLiked.Contains(userId))
                            answer.UserReaction = UserReaction.Liked;
                        else if (answer.WhoDisliked.Contains(userId))
                            answer.UserReaction = UserReaction.Disliked;
                        else answer.UserReaction = UserReaction.None;
                    }
                }
            }

            return View(post);
        }

        public IActionResult Search(string term)
        {
            return View((object)term);
        }


        public async Task<IActionResult> SetPostReaction([FromBody] PostReactionDto dto)
        {
            Result<ReactionDto> result = await _postService.SetPostReaction(dto);
            return FromResult(result);
        }

       
        public IActionResult Privacy()
        {
            return View();
        }
    }
}