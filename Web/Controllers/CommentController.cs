using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.AppServices;
using Services.DTOs;
using Services.Utils;

namespace Web.Controllers
{
    [Authorize]
    public class CommentController : BaseController
    {
        private CommentService _commentService = new CommentService();

        public async Task<IActionResult> AddComment([FromBody]AddCommentDto dto)
        {
            Result result = await _commentService.AddCommentAsync(dto, UserId, UserName);
            return FromResult(result);
        }
    }
}