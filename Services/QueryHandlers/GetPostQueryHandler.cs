using DataAccess;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using Services.Queries;
using Services.DTOs;

namespace Services.QueryHandlers
{
    public class GetPostQueryHandler : IQueryHandler<GetPostQuery, PostDto>
    {
        private DatabaseContext _db = new DatabaseContext();

        public async Task<PostDto> HandleAsync(GetPostQuery query)
        {
            var post = await
                 _db.Posts.Find(x => x.Url == query.Url)
                .FirstOrDefaultAsync();

            var comments = await 
                _db.Comments.AsQueryable()
                .Where(c => c.PostId == post.Id)
                .ToListAsync();

            return new PostDto(post, comments);
        }
    }
}
