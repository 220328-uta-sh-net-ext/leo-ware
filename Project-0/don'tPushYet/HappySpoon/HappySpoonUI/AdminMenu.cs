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
        public static RestaurantProfile rp = new RestaurantProfile();
        
        private ILogic logic;

        public AdminMenu(ILogic logic)
        {
            this.logic = logic;
        }

        //readonly IUser urepo;

        public void Display()
        {
            Console.WriteLine("You have unlocked the Admin Menu.\nWhat would you like to do?");
            Console.WriteLine("<1>Search Users");
            Console.WriteLine("<2>Search Restaurants");
            Console.WriteLine("<3>Add Restaurant Profile\n" + rp.RestaurantID + rp.Name + rp.Description + rp.Location + rp.ContactInfo + rp.AverageStars);
            Console.WriteLine("<4>Back to Main Menu");
            Console.WriteLine("<0>Exit Program");
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
                    return "SearchRestaurantsMenu";
                case "3":
                    try
                    {
                        Log.Information("Adding new restaurant...." + rp.RestaurantID + rp.Name + rp.Description + rp.Location + rp.ContactInfo + rp.AverageStars);
                        //Console.WriteLine("Enter Restaurant ID:    ");
                        //rp.RestaurantID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the restaurant's name:   ");
                        rp.Name = Console.ReadLine();
                        Console.WriteLine("Enter restaurant description:   ");
                        rp.Description = Console.ReadLine();
                        Console.WriteLine("Enter restaurant location:   ");
                        rp.Location = Console.ReadLine();
                        Console.WriteLine("Enter restaurant's contact information:    ");
                        rp.ContactInfo = Console.ReadLine();
                        Console.WriteLine("Restaurant has been saved!");
                        logic.AddRestaurant(rp);
                    }
                    catch (Exception ex)
                    {
                        Log.Warning("Failed to add a new restaurant profile");
                        Console.WriteLine(ex.Message);
                    }
                    return "AdminMenu";
                case "4":
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
