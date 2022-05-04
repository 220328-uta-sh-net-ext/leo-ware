using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonUI;
using HappySpoonModels;

namespace HappySpoonUI
{
    internal class LoginMenu : IMenu
    {
        /*readonly UserInfoLogic logic;
        public LoginMenu(UserInfoLogic? logic)
        {
            this.logic = logic;
        }*/
        public void Display()
        {
            Console.WriteLine("Welcome back, user!");
            Console.WriteLine("Please log in to continue");
            Console.WriteLine("Press <1> Enter your user information");
            Console.WriteLine("Press <2> Back to Main Menu");
            Console.WriteLine("Press <0> Exit Program");
        }

        public string UserChoices()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    //Console.Write(Enter username: );
                    Console.WriteLine("Logging in...");
                    return "LoginMenu";
                case "2":
                Console.WriteLine("Returning to Main Menu.....");
                    return "MainMenu";
                case "0":
                    return "ExitProgram";
                default:
                    Console.WriteLine("Please enter a valid option.");
                    Console.WriteLine("Press <Enter> to continue");
                    Console.ReadLine();
                    return "LoginMenu";
            }
        }
    }
}
