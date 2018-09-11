using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SimpleBot.Repository
{
    [BsonIgnoreExtraElements]
    public class UserProfileMongo
    {
        [BsonElement]
        public string _id { get; set; }
        [BsonElement]
        public int Visitas { get; set; }
    }
}