using DataAccess;
using Services.DTOs;
using Services.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CommentService
    {
        private readonly DatabaseContext _context = new DatabaseContext();

        public async Task<Result> AddCommentAsync(AddCommentDto dto)
        {
            //todo: validate

            var comment = new Comment()
            {
                Text = dto.Text,
                Created = DateTime.UtcNow,
                PostId = dto.PostId,
                UserId = dto.UserId,
                UserName = dto.UserName
            };

            await _context.Comments.InsertOneAsync(comment);
            return Result.Ok();
        }
    }
}
