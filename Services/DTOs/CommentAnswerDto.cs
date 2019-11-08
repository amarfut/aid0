using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DTOs
{
    public class CommentDto
    {
        public CommentDto(Comment comment)
        {
            Id = comment.Id;
            UserName = comment.UserName;
            Text = comment.Text;
            Likes = comment.Likes;
            Dislikes = comment.Dislikes;
            Created = comment.Created;

            foreach (CommentAnswer answer in comment.Answers)
            {
                Answers.Add(new CommentAnswerDto(answer));
            }
        }

        public string Id { get; set; }

        public string Text { get; set; }

        public string UserName { get; set; }

        public DateTime Created { get; set; }

        public int Likes { get; set; }

        public int Dislikes { get; set; }

        public List<CommentAnswerDto> Answers { get; set; } = new List<CommentAnswerDto>();
    }
}
