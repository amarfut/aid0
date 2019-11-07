using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class CommentDto
    {
        public string Id { get; set; }

        public string Text { get; set; }

        public string UserName { get; set; }

        public DateTime Created { get; set; }

        public int Likes { get; set; }

        public int Dislikes { get; set; }
    }
}
