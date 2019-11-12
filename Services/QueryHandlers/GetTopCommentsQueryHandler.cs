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
using Services.Utils;

namespace Services.QueryHandlers
{
    public class GetTopCommentsQueryHandler : IQueryHandler<GetTopCommentsQuery, List<CommentPreviewDto>>
    {
        private DatabaseContext _db = new DatabaseContext();

        public async Task<List<CommentPreviewDto>> HandleAsync(GetTopCommentsQuery query)
        {
            var comments = await _db.Comments.AsQueryable()
                .OrderByDescending(c => c.Created)
                .Take(query.Number).ToListAsync();


            List<Post> posts = new List<Post>();
            comments.Select(c => c.PostId).ToList().ForEach( id => 
            {
                var _posts =  _db.Posts.AsQueryable()
                .Where(p => p.InternalId == ObjectId.Parse(id))
                .Select(p => new Post() { InternalId = p.InternalId, Title = p.Title, Url = p.Url}).ToList();
                posts.AddRange(_posts);
            });

            var postMap = posts.ToDictionary(p => p.InternalId.ToString(), p => new Tuple<string, string>(p.Title, p.Url));

            var result = comments.Select(c => new CommentPreviewDto()
            {
                CommentId = c.Id,
                Text = c.Text,
                UserId = c.UserId,
                PostTitle = postMap[c.PostId.ToString()].Item1,
                PostUrl = postMap[c.PostId.ToString()].Item2,
                UserName = c.UserName
            }).ToList();

            return result;
        }
    }
}
