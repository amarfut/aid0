﻿using DataAccess;
using Domain.Commands;
using Domain.Entities;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using Services.DTOs;
using Services.Utils;
using System.Threading.Tasks;

namespace Services.CommandHandlers
{
    public class CreateUserCommandtHandler : ICommandHandler<CreateUserCommand, Result<UserIdDto>>
    {
        protected DatabaseContext _db = new DatabaseContext();

        public async Task<Result<UserIdDto>> HandleAsync(CreateUserCommand command)
        {
            var exists = await _db.Users.AsQueryable().Where(u => u.ExternalId == command.ExternalId).AnyAsync();
            if (exists)
            {
                var nameUpdateDefinition = Builders<User>.Update.Set("Name", command.Name);
                await _db.Users.UpdateOneAsync(u => u.ExternalId == command.ExternalId, nameUpdateDefinition);
            }
            else
            {
                await _db.Users.InsertOneAsync(new User
                {
                    ExternalId = command.ExternalId,
                    Name = command.Name,
                    Provider = command.Provider
                });
            }

            var user = await _db.Users.Find(u => u.ExternalId == command.ExternalId).FirstOrDefaultAsync();
            return Result.Ok(new UserIdDto(user.Id));
        }

    }
}