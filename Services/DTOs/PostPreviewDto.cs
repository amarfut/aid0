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
            ViewsCount = post.Views;
            CommentsCount = post.CommentsCount;
            LikesCount = post.WhoLiked.Length;
            DislikesCount = post.WhoDisliked.Length;
        }

        public string Title { get; set; }
        public string Url { get; set; }
        public int ViewsCount { get; set; }
        public int CommentsCount { get; set; }
        public int LikesCount { get; set; }
        public int DislikesCount { get; set; }
    }
}
