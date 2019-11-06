using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class User
    {
        [BsonId]
        public ObjectId InternalId { get; set; }

        public string ExternalId { get; set; }

        public string Name { get; set; }

        public string Provider { get; set; }
    }
}
