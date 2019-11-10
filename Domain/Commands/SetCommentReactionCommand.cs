using System;

namespace Domain.Commands
{
    public class SetCommentReactionCommand : IDomainCommand
    {
        public SetCommentReactionCommand(string commentId, bool liked, string userId)
        {
            CommentId = commentId;
            Liked = liked;
            UserId = userId;
        }

        public string CommentId { get; set; }

        public bool Liked { get; set; }

        public string UserId { get; set; }
    }
}
