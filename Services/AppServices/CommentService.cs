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

        private AnswerCommentHandler _answerCommentHandler = new AnswerCommentHandler();

        private SetCommentReactionHandler _setCommentReactionHandler = new SetCommentReactionHandler();

        

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

        public async Task<Result> AnswerCommentAsync(AnswerCommentDto dto, string userId, string userName)
        {
            return await _answerCommentHandler.HandleAsync(
                new AnswerCommentCommand(dto.ParentCommentId, dto.Text, userId, userName, DateTime.UtcNow)
            );
        }

        public async Task<Result<ReactionDto>> SetCommentReactionAsync(CommentReactionDto dto, string userId)
        {
            return await _setCommentReactionHandler.HandleAsync(new SetCommentReactionCommand(dto.CommentId, dto.Liked, userId));
        }



        public async Task<Result> DeleteCommentAsync()
        {
            //TODO: decrement Post.CommentsCount prop
            throw new NotImplementedException();
        }
    }
}
