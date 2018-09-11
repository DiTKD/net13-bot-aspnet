using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;


namespace SimpleBot.Repository
{
    public class UserProfileSqlRepository : IUserProfileRepository
    {
        public UserProfile GetProfile(string id)
        {
            throw new NotImplementedException();
        }

        public bool InsertMessage(Message message)
        {
            throw new NotImplementedException();
        }

        public UserProfile SetProfile(string id, UserProfile profile)
        {
            throw new NotImplementedException();
        }
    }
}