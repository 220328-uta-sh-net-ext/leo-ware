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
        
        public static UserProfile User = new UserProfile();
        private IUserLogic logic;

        public AddUserMenu(IUserLogic logic)
        {
            this.logic = logic;
        }

        public void Display()
        {
            Console.WriteLine("Enter user information");
            Console.WriteLine("<1> Enter your username        " + User.UserName);
            Console.WriteLine("<2> Enter your password        " + User.UserPassword);
            Console.WriteLine("<3> Enter your email           " + User.UserEmail);
            Console.WriteLine("<4> Save your information");
            Console.WriteLine("<0> Back to Main Menu");
        }

        public string UserChoices()
        {
            string userInput = Console.ReadLine();
          
            switch (userInput)
            {
                case "1":
                    try
                    {
                        Console.WriteLine("Creating new user profile...");
                        Log.Information("Prompting user to add a new user: " + User.UserName);
                        Console.Write("Enter your username: ");
                        User.UserName = Console.ReadLine();
                        Log.Information("Username accepted...");
                    }
                    catch (Exception ex)
                    {
                        Log.Warning("Failed to add new user :(");
                        Console.WriteLine(ex.Message);
                    }
                    return "AddUserMenu";
                    case "2":
                    try
                    {
                        Log.Information("Prompting user to add a new password: " + User.UserPassword);
                        Console.Write("Enter your password: ");
                        User.UserPassword = Console.ReadLine();
                        Log.Information("Password accepted...");
                    }
                    catch(Exception ex)
                    {
                        Log.Warning("Failed to add user's password :(");
                        Console.WriteLine(ex.Message);
                    }
                    return "AddUserMenu";
                    case"3":
                    try
                    {
                        Log.Information("Prompting user to add a new password: " + User.UserEmail);
                        Console.Write("Enter your email: ");
                        User.UserEmail = Console.ReadLine();
                        Log.Information("Email accepted...");
                    }
                    catch (Exception ex)
                    {
                        Log.Warning("Failed to add user's email :(");
                        Console.WriteLine(ex.Message);
                    }
                    return "AddUserMenu";
                    case "4":
                    try
                    {
                        Log.Information("Saving to HappySpoon User database");
                        Console.WriteLine($"User was saved! Welcome, {User.UserName}");
                        logic.AddUser(User);
                    }
                    catch (Exception ex)
                    {
                        Log.Warning("Failed to add new user :(");
                        Console.WriteLine(ex.Message);
                    }
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
