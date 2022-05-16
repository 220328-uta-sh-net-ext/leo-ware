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
        //public RestaurantProfile restaurant = new RestaurantProfile();
        public static List<RestaurantProfile> rp = new List<RestaurantProfile>();
        
        readonly ILogic logic;
        readonly IRepo repo;

        public SearchRestaurantsMenu(ILogic logic, IRepo repo)
        {
            this.logic = logic;
            this.repo = repo;
        }

        public void Display()
        {
            Console.WriteLine("Please enter input to search restaurants");
            Console.WriteLine("<1> See all restaurants");
            Console.WriteLine("<2> Search restaurants by name  ");
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
                    repo.GetAllRestaurants();
                    return "SearchRestaurants";
                case "2":
                    try
                    {
                        Log.Information("User is attempting to search for a restaurant by name.");
                        Console.WriteLine("**************************************");
                        Console.WriteLine("Search by name to view a restaurant");
                        Console.WriteLine("Enter restaurant's name: ");
                        Log.Information("Prompting user for restaurant search input.");
                        string rName = Console.ReadLine();
                        logic.SearchRestaurants(rName);
                    }
                    catch (Exception ex)
                    {
                        Log.Debug(ex.Message);
                        Console.WriteLine(ex.Message);
                    }
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
