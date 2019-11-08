using DataAccess;
using Domain.Commands;
using Domain.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using Services.Utils;
using System.Threading.Tasks;

namespace Services.CommandHandlers
{
    public class AnswerCommentHandler : ICommandHandler<AnswerCommentCommand, Result>
    {
        protected DatabaseContext _db = new DatabaseContext();

        public async Task<Result> HandleAsync(AnswerCommentCommand command)
        {
            var answer = new CommentAnswer()
            {
                Text = command.Text,
                Created = command.Created,
                ParentCommentId = command.ParentCommentId,
                UserId = command.UserId,
                UserName = command.UserName
            };

            var filter = Builders<Comment>.Filter.And(
                    Builders<Comment>.Filter.Where(c => c.InternalId == ObjectId.Parse(command.ParentCommentId)));

            var update = Builders<Comment>.Update.Push("Answers", answer);

            await _db.Comments.FindOneAndUpdateAsync(filter, update);
            return Result.Ok();
        }
    }
}
