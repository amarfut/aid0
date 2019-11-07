using DataAccess;
using Services.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserService
    {
        private UserRepositoryWrite _userRepositoryWrite { get; } = new UserRepositoryWrite();

        public async Task<Result<string>> CreateUserAsync(string externalId, string name, string provider)
        {
            User user = await _userRepositoryWrite.CreateUserAsync(externalId, name, provider);
            return Result.Ok<string>(user.InternalId.ToString());
        }
    }
}
