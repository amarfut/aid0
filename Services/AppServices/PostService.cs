using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using DataAccess;
using Domain;
using MongoDB.Driver.Linq;
using Services.QueryHandlers;
using Domain.Entities;
using Services.DTOs;
using Services.Queries;

namespace Services.AppServices
{
    public class PostService
    {

        private GetPostQueryHandler _getPostQueryHandler 
            = new GetPostQueryHandler();

        private GetRandomPostPreviewsQueryHandler _getRandomPostPreviewsQueryHandler 
            = new GetRandomPostPreviewsQueryHandler();


        private GetPostPreviewsQueryHandler _getPostPreviewsQueryHandler = new GetPostPreviewsQueryHandler();

        public async Task<IEnumerable<PostPreviewDto>> GetPostPreviews(int skip)
        {
            var posts = await _getPostPreviewsQueryHandler.HandleAsync(new GetPostPreviewQuery(skip));
            return posts;
        }

        public async Task<IEnumerable<PostPreviewDto>> GetRandomPostPreviews(PostType type, int number)
        {
            var posts = await _getRandomPostPreviewsQueryHandler.HandleAsync(new GetRandomPostPreviewsQuery(type, number));
            return posts;
        }

        public async Task<PostDto> GetPost(string url)
        {
            var post = await _getPostQueryHandler.HandleAsync(new GetPostQuery(url));
            return post;
        }
    }
}
