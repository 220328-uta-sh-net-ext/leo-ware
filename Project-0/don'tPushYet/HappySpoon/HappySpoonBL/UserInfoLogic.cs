using System.Collections.Generic;
using System;
using HappySpoonBL;
using HappySpoonDL;
using HappySpoonModels;

namespace HappySpoonBL
{
    public class UserInfoLogic : IUserLogic
    {
       readonly IUser urepo;
        
        public UserInfoLogic()
        {
        }

        public UserInfoLogic(IUser repo)
        {
            urepo = repo;
        }

        public UserInfoLogic AddUser(UserProfile User)
        {
            throw new NotImplementedException();
        }

        public List<UserProfile> SearchAllUSers()
        {
            throw new NotImplementedException();
        }

        public List<UserProfile> SearchAllUsers()
        {
            throw new NotImplementedException();
        }

        UserProfile IUserLogic.AddUser(UserProfile User)
        {
            throw new NotImplementedException();
        }
    }

}