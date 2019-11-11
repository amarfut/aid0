using DataAccess;
using Domain.Commands;
using Domain.Entities;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using Services.DTOs;
using Services.Utils;
using System.Threading.Tasks;
using MongoDB.Driver.Linq;
using System;

namespace Services.CommandHandlers
{
    public class SetCommentReactionHandler : ICommandHandler<SetCommentReactionCommand, Result<ReactionDto>>
    {
        protected DatabaseContext _db = new DatabaseContext();

        public async Task<Result<ReactionDto>> HandleAsync(SetCommentReactionCommand command)
        {
            Comment comment = await _db.Comments.AsQueryable()
                .Where(c => c.InternalId == ObjectId.Parse(command.ParentCommandId)).FirstOrDefaultAsync();

            if (comment == null) return Result.Fail<ReactionDto>("");

            if (!string.IsNullOrEmpty(command.CommentId))
            {
                return await HandleCommentAnswer(command, comment);
            }

            var userReaction = GetUserReaction(command.UserId, command.Liked, comment.WhoLiked, comment.WhoDisliked);

            var update = Builders<Comment>.Update.Set(x => x.WhoLiked, userReaction.WhoLiked).Set(x => x.WhoDisliked, userReaction.WhoDisliked);

            await _db.Comments.FindOneAndUpdateAsync(c => c.InternalId == ObjectId.Parse(command.ParentCommandId), update);

            return Result.Ok(new ReactionDto() { Likes = userReaction.WhoLiked.Length, Dislikes = userReaction.WhoDisliked.Length });
        }

        private async Task<Result<ReactionDto>> HandleCommentAnswer(SetCommentReactionCommand command, Comment comment)
        {
            CommentAnswer answer = comment.Answers.FirstOrDefault(c => c.InternalId == ObjectId.Parse(command.CommentId));
            if (comment == null) return Result.Fail<ReactionDto>("");

            var userReaction = GetUserReaction(command.UserId, command.Liked, comment.WhoLiked, comment.WhoDisliked);

            var filter = Builders<Comment>.Filter;
            var commentAnswerFilter = filter.And(
                  filter.Eq(x => x.InternalId, ObjectId.Parse(command.ParentCommandId)),
                  filter.ElemMatch(x => x.Answers, c => c.InternalId == ObjectId.Parse(command.CommentId)));

            var update = Builders<Comment>.Update
                .Set("Answers.$.WhoLiked", userReaction.WhoLiked)
                .Set("Answers.$.WhoDisliked", userReaction.WhoDisliked);

            await _db.Comments.UpdateOneAsync(commentAnswerFilter, update);

            return Result.Ok(new ReactionDto() { Likes = userReaction.WhoLiked.Length, Dislikes = userReaction.WhoDisliked.Length });
        }


        public class UserReaction
        {
            public string UserId { get; set; }

            public bool Liked { get; set; }

            public string[] WhoLiked{ get; set; }

            public string[] WhoDisliked { get; set; }

        }

        //TODO: to domain service
        public UserReaction GetUserReaction(string userId, bool liked, string[] whoLiked, string[] whoDisliked)
        {
            var userReaction = new UserReaction();

            var userIds = new string[] { userId };
            if (liked)
            {
                userReaction.WhoDisliked = whoDisliked.Except(userIds).ToArray();

                if (whoLiked.Contains(userId))
                    userReaction.WhoLiked = whoLiked.Except(userIds).ToArray();
                else
                    userReaction.WhoLiked = whoLiked.Concat(userIds).ToArray();
            }
            else
            {
                userReaction.WhoLiked = whoLiked.Except(userIds).ToArray();

                if (whoDisliked.Contains(userId))
                    userReaction.WhoDisliked = whoDisliked.Except(userIds).ToArray();
                else
                    userReaction.WhoDisliked = whoDisliked.Concat(userIds).ToArray();
            }

            return userReaction;
        }

    }
}


