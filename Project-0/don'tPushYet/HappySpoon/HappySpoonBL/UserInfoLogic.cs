using System;
using HappySpoonDL;
using HappySpoonModels;

namespace HappySpoonBL
{
    public class UserInfoLogic : UserInterface
    {
        readonly UserInterface repo = new UserRepo();

        public void AddUser(int UserID, string UserEmail, int Userpassword)
        {
            UserProfile newUser = new UserProfile();
            newUser.UserID = new Random().Next(1, 200);
            Console.Write("Enter a username: ");
            newUser.UserName = Convert.ToString(Console.ReadLine());
            Console.Write("Enter a password containing only four numbers: ");
            newUser.UserPassword = Convert.ToString(Console.ReadLine());
           
            repo.AddUser(newUser);
        }
        
        
    }

}