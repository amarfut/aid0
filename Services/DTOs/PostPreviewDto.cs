using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DTOs
{
    public class PostPreviewDto
    {
        public PostPreviewDto(Post post)
        {
            Title = post.Title;
            Url = post.Url;
            ViewsCount = 1;
            CommentsCount = post.CommentsCount;
            LikesCount = 1;
            DislikesCount = 1;
        }

        public string Title { get; set; }
        public string Url { get; set; }
        public int ViewsCount { get; set; }
        public int CommentsCount { get; set; }
        public int LikesCount { get; set; }
        public int DislikesCount { get; set; }
    }
}
