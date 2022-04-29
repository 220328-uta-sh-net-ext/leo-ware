using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonBL;

namespace HappySpoonUI
{
    internal class SearchRestaurants : MenuInterface
    {
        RestaurantInterface repo = new RestaurantLogic();

        public void Display()
        {
            Console.WriteLine("Please enter input to search restaurants");
            Console.WriteLine("Press <1> By Name");
            Console.WriteLine("Press <0> Back to Main Menu");
        }

        public string UserChoices()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    return "MainMenu";
                case "1":
                    Console.Write("Please enter input");
                    string name = Console.ReadLine();
                    var results = repo.SearchRestaurants(name);
                    if (results.Count > 0)
                    {
                        foreach (var r in results)
                        {
                            Console.WriteLine("============");
                            Console.WriteLine(r.ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Restaurant with {name} not found.");
                    }
                    Console.WriteLine("Press <enter> to continue");
                    Console.ReadLine();
                    return "MainMenu";
                    default:
                    Console.WriteLine("Please enter a valid input");
                    Console.WriteLine("Press <enter> to continue");
                    Console.ReadLine();
                    return "SearchRestaurants";
            }
        }
    }
}
