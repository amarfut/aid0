using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DTOs
{
    public enum UserReaction
    {
        None = 1,
        Liked = 2,
        Disliked = 3
    }


    public class CommentDto
    {
        public CommentDto(Comment comment)
        {
            Id = comment.Id;
            UserName = comment.UserName;
            Text = comment.Text;
            Likes = comment.WhoLiked.Length;
            Dislikes = comment.WhoDisliked.Length;
            Created = comment.Created;
            WhoLiked = comment.WhoLiked;
            WhoDisliked = comment.WhoDisliked;

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

        public string[] WhoLiked { get; set; }
        public string[] WhoDisliked { get; set; }
        
        public List<CommentAnswerDto> Answers { get; set; } = new List<CommentAnswerDto>();

        public UserReaction UserReaction { get; set; }
    }


    public class CommentAnswerDto
    {
        public CommentAnswerDto(CommentAnswer answer)
        {
            Id = answer.Id;
            ParentCommentId = answer.ParentCommentId;
            UserName = answer.UserName;
            Text = answer.Text;
            Likes = answer.WhoLiked.Length;
            Dislikes = answer.WhoDisliked.Length;
            Created = answer.Created;
            WhoLiked = answer.WhoLiked;
            WhoDisliked = answer.WhoDisliked;
        }

        public string Id { get; set; }
        public string ParentCommentId { get; set; }
        public string Text { get; set; }
        public string UserName { get; set; }
        public DateTime Created { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public string[] WhoLiked { get; set; }
        public string[] WhoDisliked { get; set; }
        public UserReaction UserReaction { get; set; }

    }
}
