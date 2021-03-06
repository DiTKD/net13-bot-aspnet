﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SimpleBot.Repository
{
    public interface IUserProfileRepository 
    {
        UserProfile GetProfile(string id);
        UserProfile SetProfile(string id, UserProfile profile);

        bool InsertMessage(Message message);
    }
}