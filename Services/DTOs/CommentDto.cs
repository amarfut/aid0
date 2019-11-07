using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DTOs
{
    public class CommentDto
    {
        public CommentDto(string id, string userName, string text, int likes, int dislikes, DateTime created)
        {
            Id = id;
            UserName = userName;
            Text = text;
            Likes = likes;
            Dislikes = dislikes;
            Created = created;
        }

        public string Id { get; set; }

        public string Text { get; set; }

        public string UserName { get; set; }

        public DateTime Created { get; set; }

        public int Likes { get; set; }

        public int Dislikes { get; set; }
    }
}
