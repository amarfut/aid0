using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DTOs
{
    public class CommentPreviewDto
    {
        public string CommentId { get; set; }

        public string Text { get; set; }

        public string UserId { get; set; }

        public string UserName { get; set; }

        public string PostTitle { get; set; }
    }
}
