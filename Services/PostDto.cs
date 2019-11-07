using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class PostDto
    {
        public PostDto(string id, string title, string url, string text, List<Comment> comments)
        {
            Id = id;
            Title = title;
            Url = url;
            Text = text;

            foreach (var comment in comments)
            {
                Comments.Add(new CommentDto() {
                    Created = comment.Created,
                    Dislikes = comment.Dislikes,
                    Likes = comment.Likes,
                    Text = comment.Text,
                    UserName = comment.UserName,
                    Id = comment.InternalId.ToString(),
                });
            }
        }

        public string Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Text { get; set; }

        public List<CommentDto> Comments { get; set; } = new List<CommentDto>();
    }
}
