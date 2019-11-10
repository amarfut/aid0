using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DTOs
{
    public class CommentReactionDto
    {
        public string CommentId { get; set; }

        public bool Liked { get; set; }
    }
}
