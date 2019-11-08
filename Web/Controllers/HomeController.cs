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
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : BaseController
    {
        private PostService _postService = new PostService();

        public async Task<IActionResult> Index()
        {
            return View(await _postService.GetPostPreviews(skip: 0));
        }

        public async Task<IEnumerable<PostPreviewDto>> LoadPosts(int skip)
        {
            return await _postService.GetPostPreviews(skip);
        }

        public async Task<IActionResult> Post(string url)
        {
            var service = new PostService();
            return View(await service.GetPost(url));
        }

        public IActionResult Search(string term)
        {
            return View((object)term);
        }

       
        public IActionResult Privacy()
        {
            return View();
        }
    }
}