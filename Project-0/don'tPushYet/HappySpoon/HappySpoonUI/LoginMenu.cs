﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappySpoonUI
{
    internal class LoginMenu : IMenu
    {
        IMenu menu = new LoginMenu();
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

                    Console.ReadLine();
                    return "LoginMenu";
                case "2":
                    
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