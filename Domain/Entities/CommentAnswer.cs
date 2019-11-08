using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class CommentAnswer : BaseComment
    {
        public string ParentCommentId { get; set; }
    }
}
