using DataAccess;
using Domain.Commands;
using Domain.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using Services.DTOs;
using Services.Utils;
using System.Threading.Tasks;

namespace Services.CommandHandlers
{
    public class SetCommentReactionHandler : ICommandHandler<SetCommentReactionCommand, Result<ReactionDto>>
    {
        protected DatabaseContext _db = new DatabaseContext();

        public async Task<Result<ReactionDto>> HandleAsync(SetCommentReactionCommand command)
        {

            return Result.Ok(new ReactionDto() { Likes = 66, Dislikes = 33 });
        }
    }
}
