using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using MongoDB.Bson;

namespace SimpleBot
{
    public class SimpleBotUser
    {
        public static string Reply(Message message)
        {
            var msg = $"{message.User} disse '{message.Text}'";

            var client = new MongoClient("mongodb://localhost:27017");
            var db = client.GetDatabase("db01");
            var col = db.GetCollection<BsonDocument>("tabela01");
            var doc = new BsonDocument()
            {
                { "id", message.Id },
                { "texto", msg },
                { "app", "SimpleBot"}
            };
            col.InsertOne(doc);
            return msg;
        }

        public static UserProfile GetProfile(string id)
        {
            return null;
        }

        public static void SetProfile(string id, UserProfile profile)
        {
        }
    }
}