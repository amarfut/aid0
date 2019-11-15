using DataAccess;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
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


            var userIds = comments.Select(c => ObjectId.Parse(c.UserId)).ToList();
            var userIdAnswers = comments.SelectMany(x => x.Answers.Select(y => ObjectId.Parse(y.UserId)));
            userIds.AddRange(userIdAnswers);

            var filter = Builders<User>.Filter.In(x => x.InternalId, userIds);
            var userPhotos = await _db.Users.Find(filter).Project(x => new { x.Id, x.PhotoUrl }).ToListAsync();
            var userPhotoMap = userPhotos.ToDictionary(x => x.Id, x => x.PhotoUrl);

            return new PostDto(post, comments, userPhotoMap);
        }
    }
}
