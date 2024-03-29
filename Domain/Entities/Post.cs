﻿
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Post : Entity
    {
        public string Title { get; set; }

        public string Text { get; set; }

        public string Url { get; set; }

        public int Type { get; set; }

        public DateTime Created { get; set; }

        public int CommentsCount { get; set; }
        
        public int Views { get; set; }

        [BsonIgnoreIfDefault]
        public string[] WhoLiked { get; set; } = new string[] { };

        [BsonIgnoreIfDefault]
        public string[] WhoDisliked { get; set; } = new string[] { };
    }
}
