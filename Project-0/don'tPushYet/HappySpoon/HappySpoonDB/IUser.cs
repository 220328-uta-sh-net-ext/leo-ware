using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonModels;

namespace HappySpoonDL
{
    public interface IUser
    {

        private void UserProfile(UserProfile User)
        {
            Console.WriteLine($"User ID: {User.UserID}\nUsername: {User.UserName}");
        }

        public void AddUser(UserProfile User)
        {
            GetUsers.Add(User);
        }

        public void SearchUsers(string ID, string UserName)
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
        
        private List<UserProfile> GetUsers { get; set; }

        public void SearchUsers()
        {
            foreach (var User in GetUsers)
            {
                UserProfile(User);
            }
        }
        //UserProfile GetUsers();
    }

}
