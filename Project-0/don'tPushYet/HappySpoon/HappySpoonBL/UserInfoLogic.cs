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

        public UserProfile AddUser(UserProfile User)
        {
            return urepo.AddUser(User);
        }


        public List<UserProfile> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public List<UserProfile> SearchAllUsers()
        {
            throw new NotImplementedException();
        }



    }

}