using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var service = new PostService();
            return View(await service.GetPostPreviews(0, 10));
        }


        public async Task<IActionResult> GetPost(string url)
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
