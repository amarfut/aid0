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
    public class UserService
    {
        private CreateUserCommandtHandler _createUserCommandtHandler { get; } = new CreateUserCommandtHandler();

        public async Task<Result<UserIdDto>> CreateUserAsync(string externalId, string name, string provider)
        {
            Result<UserIdDto> dto = await _createUserCommandtHandler
                .HandleAsync(new CreateUserCommand(externalId, name, provider));

            return dto;
        }
    }
}
