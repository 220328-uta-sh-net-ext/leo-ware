using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonUI;
using HappySpoonModels;
using HappySpoonBL;

namespace HappySpoonUI
{
    public class AddUserMenu : IMenu
    {
        private UserInfoLogic uLogic;

        public AddUserMenu(UserInfoLogic uLogic)
        {
            this.uLogic = uLogic;
        }

        public void Display()
        {
            Console.WriteLine("<1> Enter user information");
            Console.WriteLine("<0> Back to Main Menu");
        }

        public string UserChoices()
        {
            string userInput = Console.ReadLine();
          
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Creating new user profile...");
                    
                    return "AddUserMenu";
                case "0":
                    Console.Write("*************~ Loading Main Menu ~*************");
                    return "MainMenu";
                default:
                    Console.WriteLine("Please input a valid response\nPress <Enter> to continue");
                    return "AddUserMenu";
            }
        }
    }
}
