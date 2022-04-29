using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonBL;
using HappySpoonDL;

namespace HappySpoonUI
{
    internal class AdminMenu : MenuInterface
    {
        public void Display()
        {
            Console.WriteLine("You have unlocked the Admin Menu.\nWhat would you like to do?");
            Console.WriteLine("Search Users");
            Console.WriteLine("Search Restaurants");
            Console.WriteLine("Add Restaurant Profile");
            Console.WriteLine("Back to Main Menu");
            Console.WriteLine("Exit Program");
        }

        public string UserChoices()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    return "SearchUser";
                case "2":
                    return "SearchRestaurants";
                case "3":
                    return "AddRestaurant";
                case "0":
                    return "MainMenu";
                case "":
                    return "ExitProgram";
                default:
                    Console.WriteLine("Please enter a valid option.");
                    Console.WriteLine("Press <Enter> to continue");
                    Console.ReadLine();
                    return "Admin";
            }
        }
    }
}
