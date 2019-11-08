﻿using DataAccess;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DTOs
{
    public class PostDto
    {
        public PostDto(Post post, List<Comment> comments)
        {
            Id = post.Id;
            Title = post.Title;
            Url = post.Url;
            Text = post.Text;
            CommentsCount = post.CommentsCount;

            foreach (var comment in comments)
            {
                Comments.Add(new CommentDto(comment));
            }
        }

        public string Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Text { get; set; }
        public int CommentsCount { get; set; }

        public List<CommentDto> Comments { get; set; } = new List<CommentDto>();
    }
}