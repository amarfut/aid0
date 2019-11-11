using Microsoft.AspNetCore.Mvc;
using Services.AppServices;
using Services.QueryHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Views.Shared.Components.MobileMenu
{
    public class RealTimeCommentsViewComponent : ViewComponent
    {
        public RealTimeCommentsViewComponent() { }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var service = new CommentService();
            return View("Default", await service.GetTopCommentPreviews());
        }
    }
}
