using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonUI;
using HappySpoonModels;

namespace HappySpoonUI
{
    internal class AdminMenu : IMenu
    {
        /*readonly UserInfoLogic logic;
        readonly IRepo repo;

        public AdminMenu(IRepo? repo, UserInfoLogic? logic)
        {
            this.repo = repo;
            this.logic = logic;
        }*/
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
                    Console.WriteLine("Searching users...");
                    return "SearchUser";
                case "2":
                    Console.WriteLine("Searching restaurants.....");
                    return "SearchRestaurants";
                case "3":
                    Console.WriteLine("Adding new restaurant....");
                    return "AddRestaurant";
                case "0":
                    Console.WriteLine("Returning to Main Menu...");
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
