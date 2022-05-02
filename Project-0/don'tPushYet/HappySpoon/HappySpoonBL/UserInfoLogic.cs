using System.Collections.Generic;
using System;
using HappySpoonDL;
using HappySpoonModels;

namespace HappySpoonBL
{
    public class UserInfoLogic : IUser
    {
        private readonly IUser repo = new List<UserProfile>();

        public UserProfile AddUser(UserProfile user)
        {
            return repo.AddUser(user);
        }

        public List<UserProfile> GetUsers(char UserName, char UserPassword)
        {
            return repo.GetUsers(UserName, UserPassword);
        }

        public UserProfile GetUsers()
        {
            return repo.GetUsers();
        }

        public string SearchUsers(string name, string password)
        {
            UserProfile user = repo.GetUsers();
            string results = "";
            char filteredUser = Convert.ToChar(name);
            while (filteredUser == user.UserName)
            {
                //foreach (var target in filteredUser)
                //{
                    if (user.UserPassword == Convert.ToChar(password) && user.UserName == Convert.ToChar("El Jefe"))
                    {
                        results = "Admin";
                        break;
                    }
                    if (user.UserPassword == Convert.ToChar(password) && user.UserName != Convert.ToChar("El Jefe"))
                    {
                        results = "UserProfile";
                        break;
                    }
                    else
                    {
                        results = "Sorry, user was not found";
                    }
                //}
                return results;
            }
            
        }

        public void SearchUsers(UserProfile user)
        {
            var targetUser = repo.GetUsers();
            if (targetUser == user)
            {
                Console.WriteLine($"User ID: {user.UserID}\nUsername: {user.UserName}");
            }
            else
            {
                Console.WriteLine("Sorry, that user doesn't exist in our database");
            }

        }

        public void SearchUsers()
        {
            repo.SearchUsers();
        }

        public bool SearchUsers(char UserName)
        {
            return repo.SearchUsers(UserName);
        }
    }

}