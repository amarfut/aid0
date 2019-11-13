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
            Id = post.Id;
            Title = post.Title;
            Url = post.Url;
            TextPreview = post.Text.Length > 100 ? post.Text.Substring(0, 100).Remove(0, 3) + "..." : post.Text; //0, 3 - remove <p>
            ViewsCount = post.Views;
            CommentsCount = post.CommentsCount;
            LikesCount = post.WhoLiked.Length;
            DislikesCount = post.WhoDisliked.Length;
        }

        public string Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string TextPreview { get; set; }
        public int ViewsCount { get; set; }
        public int CommentsCount { get; set; }
        public int LikesCount { get; set; }
        public int DislikesCount { get; set; }
    }
}
