using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver.Linq;

namespace DataAccess
{
    public class PostRepositoryRead
    {
        private readonly DatabaseContext _context = null;

        public PostRepositoryRead()
        {
            _context = new DatabaseContext();
        }

        //db.getCollection('posts').find().sort({id:-1}).skip(1).limit(1)
        public async Task<IEnumerable<Post>> GetPostPreviews(int skip, int limit)
        {
            return await _context.Posts.AsQueryable()
                .OrderByDescending(x => x.created)
                .Skip(skip)
                .Take(limit)
                .Select(x => new Post()
                {
                    InternalId = x.InternalId,
                    title = x.title,
                    url = x.url
                }).ToListAsync();
        }

        public async Task<IEnumerable<Post>> GetRandomPostPreviews(int type, int number)
        {
            return await _context.Posts.AsQueryable().Where(x => x.type == type).Sample(number).ToListAsync();
        }

        //TODO: create index for url
        public async Task<Post> GetPost(string url)
        {
            return await _context.Posts.Find(x => x.url == url).FirstOrDefaultAsync();
        }


    }
}
