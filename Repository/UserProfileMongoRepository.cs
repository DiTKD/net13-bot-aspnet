using MongoDB.Driver;
using SimpleBot.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBot.Repository
{
    public class UserProfileMongoRepository : IUserProfileRepository
    {
        public UserProfile GetProfile(string id) =>
             MongoConnection.getDocument(id);
        
        public bool InsertMessage(Message message) =>
            MongoConnection.postDocument(new MessageBson(message.Id, message.User, message.Text));

        
        public UserProfile SetProfile(string id, UserProfile profile)
        {
            if (profile == null)
            {
                profile = new UserProfile { Id = id, Visitas = 1 };
                MongoConnection.postDocumentPerfil(profile);
            }
            else
            {
                UpdateDefinition<UserProfile> update = Builders<UserProfile>.Update.Set("Visitas", profile.Visitas++);
                MongoConnection.putDocument(profile.Id, update);
            }

            return profile;
        }



    }
}