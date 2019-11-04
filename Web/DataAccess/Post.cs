using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class Post
    {
        [BsonId]
        public ObjectId InternalId { get; set; }
        public string title { get; set; }
        public string text { get; set; }
        public string url { get; set; }
        public int type { get; set; }


        [BsonDateTimeOptions]
        public DateTime created { get; set; }
    }
}
