using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonModels;
using HappySpoonUI;

namespace HappySpoonUI
{
    internal class SearchRestaurantsMenu : IMenu
    {
        //readonly RestaurantLogic logic;
        //readonly IRepo repo;

        /*public SearchRestaurantsMenu(RestaurantLogic? logic, IRepo? repo)
        {
            this.logic = logic;
            this.repo = repo;
        }*/
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
                    /*List<RestaurantProfile>  restaurants= repo.GetRestaurantsConnected();
                    foreach (var restaurant in restaurants)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine(restaurant);
                    }*/
                    return "SearchRestaurants";
                case "2":
                    Console.WriteLine("**************************************");
                    Console.WriteLine("Search by Type for restaurant");
                    Console.WriteLine("Enter: Name, City, State or Zipcode to search by that option");
                    /*string searchType = Console.ReadLine().ToLower().Trim();
                    if (searchType == "name")
                    {
                        Console.WriteLine("Enter Name of Restaurant");
                        string restaurantName = Console.ReadLine().Trim();
                        List<RestaurantProfile> restaurant = logic.GetRestaurants(restaurantName);
                        if (restaurant.Count > 0)
                        {
                            foreach (var result in restaurant)
                            {
                                Console.WriteLine("**************************************");
                                Console.WriteLine(result);
                                return "Search Restaurants";
                            }
                        }
                        else
                        {
                            Console.WriteLine($"No Restaurants with the name {restaurantName}");
                            goto case "2";
                        }
                    }*/
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
