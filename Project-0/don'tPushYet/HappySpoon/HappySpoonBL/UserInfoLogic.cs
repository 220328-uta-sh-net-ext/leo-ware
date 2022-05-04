using System.Collections.Generic;
using System;
using HappySpoonDL;
using HappySpoonModels;

namespace HappySpoonBL
{
    public class UserInfoLogic : IUserLogic
    {
       readonly IUser urepo;
        public UserInfoLogic(IUser repo)
        {
            urepo = repo;
        }
        public UserProfile GetUsers(UserProfile User)
        {
            return User.UserName
        }

        List<UserProfile> IUserLogic.SearchAllUsers()
        {
            throw new NotImplementedException();
        }
    }

}