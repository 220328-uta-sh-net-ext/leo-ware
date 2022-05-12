global using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonBL;
using HappySpoonDL;
using HappySpoonUI;

namespace HappySpoonUI
{
      //Main Menu display and Main Menu choice interaction
    class MainMenu : IMenu
    {
        
        public void Display()
        {
            Console.WriteLine("Welcome to Happy Spoon! ");
            Console.WriteLine("Ready to find your new favorite restaurant?");
            Console.WriteLine("Please choose from the following options");
            Console.WriteLine("Press <1> Search Restaurants");
            Console.WriteLine("Press <2> Login");
            Console.WriteLine("Press <3> Signup");
            Console.WriteLine("Press <0> Exit Program");
            //Console.WriteLine();
            //Console.WriteLine();
        }


        public string UserChoices()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    return "SearchRestaurantsMenu";
                case "2":
                    return "LoginMenu";
                case "3":
                    return "AddUserMenu";
                case "0":
                    return "ExitProgram";
                default:
                    Console.WriteLine("Please enter a valid option.");
                    Console.WriteLine("Press <Enter> to continue");
                    return "MainMenu";
            }

        }
            // ************************************End of Main Menu Program***************************************


    }
}
