using MongoDB.Driver;
using SimpleBot.Connection;
using SimpleBot.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBot
{

    public class SimpleBotUser
    {
        private static IUserProfileRepository _userProfileRepository;

        public SimpleBotUser()
        {
            _userProfileRepository = new UserProfileMongoRepository();
            _userProfileRepository = new UserProfileSqlRepository();
        }

        public static string Reply(Message message)
        {
            _userProfileRepository.InsertMessage(message);
            var user = _userProfileRepository.GetProfile(message.Id);
            _userProfileRepository.SetProfile(message.Id, user);

            return $"{message.User} disse '{message.Text}' e mandou { user.Visitas } mensagens";
        }

    }
}