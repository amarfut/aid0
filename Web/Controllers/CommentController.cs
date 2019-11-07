using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.DTOs;
using Services.Utils;

namespace Web.Controllers
{
    public class CommentController : BaseController
    {
        private CommentService _commentService = new CommentService();

        [Authorize]
        public async Task<IActionResult> AddComment([FromBody]AddCommentDto dto)
        {
            dto.UserId = UserId;
            dto.UserName = UserName;
            Result result = await _commentService.AddCommentAsync(dto);
            return FromResult(result);
        }

       
    }
}