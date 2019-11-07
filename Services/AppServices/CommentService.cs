using DataAccess;
using Domain.Commands;
using Services.CommandHandlers;
using Services.DTOs;
using Services.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.AppServices
{
    public class CommentService
    {
        private AddCommentHandler _addCommentHandler = new AddCommentHandler();

        public async Task<Result> AddCommentAsync(AddCommentDto dto, string userId, string userName)
        {
            //todo: validate command

            return await _addCommentHandler.HandleAsync(new AddCommentCommand()
            {
                Created = DateTime.UtcNow,
                UserName = userName,
                PostId = dto.PostId,
                UserId = userId,
                Text = dto.Text
            });
        }

        public async Task<Result> DeleteCommentAsync()
        {
            //TODO: decrement Post.CommentsCount prop
            throw new NotImplementedException();
        }
    }
}
