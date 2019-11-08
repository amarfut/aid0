using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DTOs
{
    public class CommentAnswerDto
    {
        public CommentAnswerDto(CommentAnswer answer)
        {
            Id = answer.Id;
            ParentCommentId = answer.ParentCommentId;
            UserName = answer.UserName;
            Text = answer.Text;
            Likes = answer.Likes;
            Dislikes = answer.Dislikes;
            Created = answer.Created;
        }

        public string Id { get; set; }
        public string ParentCommentId { get; set; }
        public string Text { get; set; }
        public string UserName { get; set; }
        public DateTime Created { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
    }
}
