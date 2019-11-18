﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Comment : BaseComment
    {
        public string PostId { get; set; }

        [BsonIgnoreIfDefault]
        public Answer[] Answers { get; set; } = new Answer[0];
    }
}
