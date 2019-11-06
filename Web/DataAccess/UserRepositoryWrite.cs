using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Threading.Tasks;
using MongoDB.Driver.Linq;

namespace DataAccess
{
    public class UserRepositoryWrite
    {
        private readonly DatabaseContext _context = null;

        public UserRepositoryWrite()
        {
            _context = new DatabaseContext();
        }

        public async Task CreateUserAsync(string externalId, string name, string provider)
        {
            var exists = await _context.Users.AsQueryable().Where(u => u.ExternalId == externalId).AnyAsync();
            if (exists)
            {
                var nameUpdateDefinition = Builders<User>.Update.Set("Name", name);
                await _context.Users.UpdateOneAsync(u => u.ExternalId == externalId, nameUpdateDefinition);
            }
            else
            {
                await _context.Users.InsertOneAsync(new User { ExternalId = externalId, Name = name, Provider = provider });
            }
        }

    }
}
