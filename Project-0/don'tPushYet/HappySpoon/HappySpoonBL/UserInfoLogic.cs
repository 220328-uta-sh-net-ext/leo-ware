using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using HappySpoonDL;
using HappySpoonModels;

namespace HappySpoonBL
{
    public class UserInfoLogic
    {

        public void AddUser(string userName, string userEmail, string userPassword)
        {

            var users = new UserRepo();
            
                userName = "?";
                userEmail = "?";
                userPassword = "?";
            users.AddUser();
            
        }

        static string userName { get; set; }
        static string userEmail { get; set; }

        private string userPassword { get; set; }


        public List<UserProfile> GetUsers { get; }
        
    }




}