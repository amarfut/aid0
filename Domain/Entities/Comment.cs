using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Comment : Entity
    {
        public string Text { get; set; }

        public DateTime Created { get; set; }

        public string PostId { get; set; }

        public string UserId { get; set; }

        public string UserName { get; set; }

        public int Likes { get; set; }

        public int Dislikes { get; set; }
    }
}
