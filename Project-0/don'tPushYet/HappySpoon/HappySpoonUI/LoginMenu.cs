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
    public class LoginMenu : IMenu
    {
        readonly IUserLogic logic;

        public LoginMenu(IUserLogic logic)
        {
            this.logic = logic;
        }

        public void Display()
        {
            Console.WriteLine("Welcome back, user!");
            Console.WriteLine("Please log in to continue");
            Console.WriteLine("Press <1> Enter your account information");
            Console.WriteLine("Press <2> Back to Main Menu");
            Console.WriteLine("Press <0> Exit Program");
        }

        public string UserChoices()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Log.Debug("Prompting login username");
                    Console.WriteLine("Enter your username: ");
                    string uName = Console.ReadLine();
                    Log.Debug("Prompting password");
                    Console.WriteLine("Enter Password: ");
                    string uPassword = Console.ReadLine();
                    List<UserProfile> info = logic.GetUser(uName, uPassword);
                    if (uName.Equals(info) && uPassword.Equals(info))
                    {
                        if (uName == "El Jefe" && uPassword == "1234")
                        {
                            Log.Debug($"Admin {uName}, has logged in.");
                            return "AdminMenu";
                        }
                        Log.Debug($"User, {uName}, has logged in");
                        return "AddReviewMenu";
                    }
                    else
                    {
                        Log.Debug("User login failed");
                        Console.WriteLine("UserName or Password is invalid. Try again...");
                        return "LoginMenu";
                    }
                case "2":
                    Log.Debug("Returning user to main menu");
                Console.WriteLine("Returning to Main Menu.....");
                    return "MainMenu";
                case "0":
                    Log.Debug("User has exited program");
                    return "ExitProgram";
                default:
                    Log.Debug("User input was invalid. Returning to Login Menu");
                    Console.WriteLine("Please enter a valid option.");
                    Console.WriteLine("Press <Enter> to continue");
                    Console.ReadLine();
                    return "LoginMenu";
            }
        }

    }
}
