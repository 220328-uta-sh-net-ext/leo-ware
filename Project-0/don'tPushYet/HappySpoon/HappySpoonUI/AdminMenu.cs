using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonBL;
using HappySpoonDL;
using HappySpoonUI;
using HappySpoonModels;

namespace HappySpoonUI
{
    public class AdminMenu : IMenu
    {
        private IUserLogic logic;
        private IRestaurantLogic logic2;

        public AdminMenu(IUserLogic logic, IRestaurantLogic logic2)
        {
            this.logic = logic;
            this.logic2 = logic2;
        }

        //readonly IUser urepo;

        public void Display()
        {
            Console.WriteLine("You have unlocked the Admin Menu.\nWhat would you like to do?");
            Console.WriteLine("<1> Enter Admin information");
            Console.WriteLine("<2>Search Users");
            Console.WriteLine("<3>Search Restaurants");
            Console.WriteLine("<4>Add Restaurant Profile");
            Console.WriteLine("<5>Back to Main Menu");
            Console.WriteLine("<0>Exit Program");
        }

        public string UserChoices()
        {
           
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("");
                    return "AdminMenu";
                case "2":
                    Console.WriteLine("Searching users...");
                    return "SearchUser";
                case "3":
                    Console.WriteLine("Searching restaurants.....");
                    return "SearchRestaurantsMenu";
                case "4":
                    Console.WriteLine("Adding new restaurant....");
                    return "AddRestaurant";
                case "5":
                    Console.WriteLine("Returning to Main Menu...");
                    return "MainMenu";
                case "0":
                    return "ExitProgram";
                default:
                    Console.WriteLine("Please enter a valid option.");
                    Console.WriteLine("Press <Enter> to continue");
                    Console.ReadLine();
                    return "AdminMenu";
            }
        }

    }
}
