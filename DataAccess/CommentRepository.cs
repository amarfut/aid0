using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver.Linq;

namespace DataAccess
{
    public class CommentRepository
    {
        private readonly DatabaseContext _context =  new DatabaseContext();

        public async Task<List<Comment>> GetComments(string postId)
        {
            return await _context.Comments.AsQueryable()
                        .Where(c => c.PostId == postId)
                        .OrderByDescending(c => c.Likes).ToListAsync();
        }

    }
}
