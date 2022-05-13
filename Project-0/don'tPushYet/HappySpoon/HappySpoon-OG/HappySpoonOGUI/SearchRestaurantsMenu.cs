using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonDL;
using HappySpoonBL;
using HappySpoonModels;
using HappySpoonUI;

namespace HappySpoonUI
{
    public class SearchRestaurantsMenu : IMenu
    {
        public static RestaurantProfile rName = new RestaurantProfile();

        readonly IRestaurantLogic logic;

        public SearchRestaurantsMenu(IRestaurantLogic logic)
        {
            this.logic = logic;
        }

        public void Display()
        {
            Console.WriteLine("Please enter input to search restaurants");
            Console.WriteLine("<1> See all restaurants\n  ");
            Console.WriteLine("<2> Search restaurants by name\n   " + rName.Name);
            Console.WriteLine("<0> Back to Main Menu");
        }

        public string UserChoices()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine(" ");
                    Console.WriteLine("********************~ SHOWING ALL RESTAURANTS ~**********************");
                    logic.GetAllRestaurants();
                    return "SearchRestaurants";
                case "2":
                    Console.WriteLine("**************************************");
                    Console.WriteLine("Search by name view a restaurant");
                    Console.WriteLine("Enter restaurant's name: ");
                    string rName = Console.ReadLine();
                    logic.SearchRestaurants(rName, userInput);
                    return "SearchRestaurants";
                case "0":
                    return "MainMenu";
                default:
                    Console.WriteLine("Please enter a valid input");
                    Console.WriteLine("Press <enter> to continue");
                    return "SearchRestaurants";
            }
        }
    }
}
