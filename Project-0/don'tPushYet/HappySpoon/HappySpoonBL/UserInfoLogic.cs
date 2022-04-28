using System;
using HappySpoonDL;
using HappySpoonModels;

namespace HappySpoonBL
{
    public class UserInfoLogic : UserInterface
    {
        AddUserInterface repo = new UserRepo();
        
        public UserProfile AddUser(UserProfile user)
        {
            Signup signup = new Signup();

            switch (signup)
            {
                case 1:
                public string userName = Console.ReadLine();
                //userName = user.userName(string userName){get; set;}
                break;
                case 2:
                break;
                static string userEmail = Console.ReadLine();
                //userEmail = user.userEmail(string userEmail){get; set;}
                break;
                case 3:
                static string userPassword = Console.ReadLine();
                //userPassword = user.userPassword(){ get; private set; }
                repo = new UserRepo();
                break;
                
                default:
                throw new Exception($"Please enter a valid value to continue.");
                break;
                
            }
          }
        

        private static List<UserRepo> GetUser()
        {
            var users = repo.GetUser();
            //if (users)
            if (users == null)
            {
                throw new Exception("Please enter a username to continue");
            }
            else
            {
                Console.WriteLine("Sorry your login is incorrect.");
            }
        }
    }
}