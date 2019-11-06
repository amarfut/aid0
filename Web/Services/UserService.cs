using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserService
    {
        private UserRepositoryWrite _userRepositoryWrite { get; } = new UserRepositoryWrite();

        public async Task CreateUserAsync(string externalId, string name)
        {
            await _userRepositoryWrite.CreateUserAsync(externalId, name);
        }
    }
}
