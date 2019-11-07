using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class Comment
    {
        [BsonId]
        public ObjectId InternalId { get; set; }

        public string Text { get; set; }

        public DateTime Created { get; set; }

        public string PostId { get; set; }

        public string UserId { get; set; }

        public string UserName { get; set; }

        public int Likes { get; set; }

        public int Dislikes { get; set; }
    }
}
