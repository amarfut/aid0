﻿using System;
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
using Services.InternalCommandHandlers;
using Domain.Commands;
using Services.CommandHandlers;
using Services.Utils;

namespace Services.AppServices
{
    public class PostService
    {

        private GetPostQueryHandler _getPostQueryHandler = new GetPostQueryHandler();
        private GetRandomPostPreviewsQueryHandler _getRandomPostPreviewsQueryHandler = new GetRandomPostPreviewsQueryHandler();
        private SetPostReactionCommandHandler _setPostReactionCommandHandler = new SetPostReactionCommandHandler();
        private GetPostPreviewsQueryHandler _getPostPreviewsQueryHandler = new GetPostPreviewsQueryHandler();
        private AddPostToBookmarksCommandHandler _addPostToBookmarksCommandHandler = new AddPostToBookmarksCommandHandler();

        private GetUserBookmarksQueryHandler _getUserBookmarksQueryHandler = new GetUserBookmarksQueryHandler();


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
            new IncrementPostViewCount().HandleAsync(post.Id);
            return post;
        }

        public async Task<Result<ReactionDto>> SetPostReaction(PostReactionDto dto, string userId)
        {
            var result = await _setPostReactionCommandHandler
                .HandleAsync(new SetPostReactionCommand(dto.PostId, userId, dto.Liked));

            return result;
        }

        public async Task<Result> AddPostToBookMarksAsync(string postId, string userId)
        {
            return await _addPostToBookmarksCommandHandler
                .HandleAsync(new AddPostToBookmarksCommand()
                {
                    PostId = postId,
                    UserId = userId,
                    Created = DateTime.UtcNow
                });
        }

        public async Task<List<PostPreviewDto>> GetUserBookmarksAsync(string userId)
        {
            return await _getUserBookmarksQueryHandler.HandleAsync(new GetUserBookmarksQuery(userId));
        }
    }
}
