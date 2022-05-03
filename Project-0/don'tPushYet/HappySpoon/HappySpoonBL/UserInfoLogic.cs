using System.Collections.Generic;
using System;
using HappySpoonDL;
using HappySpoonModels;

namespace HappySpoonBL
{
    public class UserInfoLogic : IUser
    {
        private List<UserProfile> GetUsers { get; set; }

        public void UserProfile(UserProfile User)
        {
            Console.WriteLine($"User ID: {User.UserID}\nUsername: {User.UserName}");
        }

        public void UserProfile(List<UserProfile> Users)
        {
            foreach (var user in GetUsers)
            {
                UserProfile(user);
            }
        }

        public void AddUser(UserProfile User)
        {
            GetUsers.Add(User);
        }

        public void SearchAllUsers(string ID, string UserName)
        {
            var User = GetUsers.FirstOrDefault(u => u.UserName == UserName);
            if (User == null)
            {
                Console.WriteLine($"Sorry, {User} was not found.\nPlease check your input and try again.");
            }
            else
            {
                UserProfile(User);
            }
        }

        public void SearchAllUsers()
        {
            foreach (var user in GetUsers)
            {
                UserProfile(user);
            }
        }

        public void SearchUsers(string phrase)
        {
            var targetUser = GetUsers.Where(u => u.UserName.Contains(phrase)).ToList();
            foreach (var user in targetUser)
            {
                UserProfile(targetUser);
            }
        }

    }

}