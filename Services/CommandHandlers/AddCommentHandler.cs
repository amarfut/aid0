using DataAccess;
using Domain.Commands;
using Domain.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using Services.Utils;
using System;
using System.Threading.Tasks;

namespace Services.CommandHandlers
{
    public class AddCommentHandler : ICommandHandler<AddCommentCommand, Result>
    {
        protected DatabaseContext _db = new DatabaseContext();

        public async Task<Result> HandleAsync(AddCommentCommand command)
        {
            if (string.IsNullOrEmpty(command.ParentCommentId))
            {
                var comment = new Comment()
                {
                    Text = command.Text,
                    Created = command.Created,
                    PostId = command.PostId,
                    UserId = command.UserId,
                    UserName = command.UserName
                };

                await _db.Comments.InsertOneAsync(comment);
            }
            else
            {
                var answer = new Answer()
                {
                    Text = command.Text,
                    Created = command.Created,
                    ParentCommentId = command.ParentCommentId,
                    UserId = command.UserId,
                    UserName = command.UserName,
                    PostId = command.PostId
                };

                await _db.Answers.InsertOneAsync(answer);
            }

            InsertInLatestComments(command);

            var increment = Builders<Post>.Update.Inc(p => p.CommentsCount, 1);
            await _db.Posts.UpdateOneAsync(p => p.InternalId == ObjectId.Parse(command.PostId), increment);

            return Result.Ok();
        }

        private async Task InsertInLatestComments(AddCommentCommand command)
        {
            var preview = new CommentPreview()
            {
                Created = DateTime.UtcNow,
                PostId = command.PostId,
                PostTitle = command.PostTitle,
                UserPhotoUrl = command.UserPhotoUrl,
                PostUrl = command.PostUrl,
                Text = command.Text,
                UserId = command.UserId,
                UserName = command.UserName,
            };

            await _db.LatestComments.InsertOneAsync(preview);
        }
    }
}


//else
//{
//    var answer = new Answer() { Text = command.Text,Created = command.Created,ParentCommentId = command.ParentCommentId,UserId = command.UserId,UserName = command.UserName };
//    answer.InternalId = ObjectId.GenerateNewId();
//    var filter = Builders<Comment>.Filter.And(Builders<Comment>.Filter.Where(c => c.InternalId == ObjectId.Parse(command.ParentCommentId)));
//    var update = Builders<Comment>.Update.Push("Answers", answer);
//    await _db.Comments.FindOneAndUpdateAsync(filter, update);
//}