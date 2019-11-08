﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class User : Entity
    {
        public string ExternalId { get; set; }

        public string Name { get; set; }

        public string Provider { get; set; }
    }
}