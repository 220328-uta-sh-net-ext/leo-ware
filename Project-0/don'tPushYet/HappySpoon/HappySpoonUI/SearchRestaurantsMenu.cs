using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonBL;
using HappySpoonModels;
using HappySpoonUI;

namespace HappySpoonUI
{
    public class SearchRestaurantsMenu : IMenu
    {
        private RestaurantLogic rLogic;

        public SearchRestaurantsMenu(RestaurantLogic rLogic)
        {
            this.rLogic = rLogic;
        }

        public void Display()
        {
            Console.WriteLine("Please enter input to search restaurants");
            Console.WriteLine("<1> See all restaurants");
            Console.WriteLine("<2> Search restaurants by name");
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
                    return "SearchRestaurants";
                case "2":
                    Console.WriteLine("**************************************");
                    Console.WriteLine("Search by Type for restaurant");
                    Console.WriteLine("Enter: Name, City, State or Zipcode to search by that option");
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
