using DataAccess;
using Domain.Commands;
using Services.CommandHandlers;
using Services.DTOs;
using Services.QueryHandlers;
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

        private GetLikedPostsQueryHandler _getLikedPostsQueryHandler { get; } = new GetLikedPostsQueryHandler();

        
        


        public async Task<Result<UserIdDto>> CreateUserAsync(string externalId, string name, string provider, string userPictureUrl)
        {
            Result<UserIdDto> dto = await _createUserCommandtHandler
                .HandleAsync(new CreateUserCommand(externalId, name, provider, userPictureUrl));

            return dto;
        }

        public async Task<List<PostPreviewDto>> GetLikedPosts(string userId)
        {
            return await _getLikedPostsQueryHandler.HandleAsync(new Queries.GetLikedPostsQuery(userId));
        }

        public async Task<string> GetUser(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
