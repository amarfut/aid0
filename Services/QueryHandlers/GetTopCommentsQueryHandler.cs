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

            var commentIds = comments.Select(c => c.InternalId).ToList();

            var result = comments.Select(c => new CommentPreviewDto()
            {
                CommentId = c.Id,
                Text = c.Text,
                UserId = c.UserId,
                PostTitle = "Post title here",
                UserName = c.UserName
            }).ToList();

            return result;
        }
    }
}
