using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonModels;
namespace HappySpoonUI
{
    internal class AddReviewMenu : IMenu
    {
        /*private static RestaurantProfile Name = Name;
        public static UserProfile UserName = UserName;
        private readonly Review newReview = new Review(Name, UserName);
        readonly ReviewLogic logic;
        readonly IRepo repo;
        public AddReviewMenu(IRepo? repo, ReviewLogic? logic)
        {
            this.repo = repo;
            this.logic = logic;
        }*/
        public void Display()
        {
            Console.WriteLine("Thank you for contributing your valuable feedbak to our platform!");

            Console.WriteLine("Press <1> Add Review");
            Console.WriteLine("Press <2> See Reviews");
            Console.WriteLine("Press <3> Back to Main Menu");
            Console.WriteLine("Press <0> Exit Program");
        }

        public string UserChoices()
        {
            string userInput = Convert.ToString(Console.ReadLine());

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Enter your username: ");
                    return "AddReviewMenu";
                case "2":
                    Console.WriteLine("Enter the restaurant's name:");
                    /*Name = Console.ReadLine();
                    Console.WriteLine("***********~ REVIEWS ~***********");
                    List<Review> Name = logic.GetRestaurants(Name);*/
                    return "AddReviewMenu";
                case "3":
                    return "MainMenu";
                case "0":
                    return "ExitProgram";
                default:
                    Console.WriteLine("Please enter a valid option.");
                    Console.WriteLine("Press <Enter> to continue");
                    Console.ReadLine();
                    return "AddReviewMenu";
            }
        }
    }
}
