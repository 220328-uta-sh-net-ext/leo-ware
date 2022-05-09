using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonBL;
using HappySpoonModels;
namespace HappySpoonUI
{
    internal class AddReviewMenu : IMenu
    {
        public static Review newReview = new Review();
        readonly IRestaurantLogic logic;
        public AddReviewMenu(IRestaurantLogic logic)
        {
            this.logic = logic;
        }
        public void Display()
        {
            Console.WriteLine("Thank you for contributing your valuable feedbak to our platform!");
            Console.WriteLine("What type of feedback would you like to add?");
            Console.WriteLine("Press <1> Add Comments" + newReview.Comments);
            Console.WriteLine("Press <2> Add Stars" + newReview.Stars);
            Console.WriteLine("Press <3> Back to Main Menu");
            Console.WriteLine("Press <0> Exit Program");
        }

        public string UserChoices()
        {
            string userInput = Convert.ToString(Console.ReadLine());

            switch (userInput)
            {
                case "1":
                    try
                    {
                        Log.Information("Prompting user to add username to review" + newReview.UserName);
                        Console.WriteLine("Enter your username: ");
                        newReview.UserName = Console.ReadLine();
                        Log.Information("Prompting user to add comments" + newReview.Comments);
                        Console.WriteLine("Enter your comments: ");
                        newReview.Comments = Console.ReadLine();
                        Log.Information("Saving user's review");
                        logic.AddReview(newReview);
                    }
                    catch (Exception ex)
                    {
                        Log.Warning("Failed to add review");
                        Console.WriteLine(ex.Message);
                    }
                    return "AddReviewMenu";
                case "2":
                    try
                    {
                        Log.Information("Prompting user to add username to review" + newReview.UserName);
                        Console.WriteLine("Enter your username: ");
                        newReview.UserName = Console.ReadLine();
                        Log.Information("Prompting user to add comments" + newReview.Stars);
                        Console.WriteLine("Enter your comments: ");
                        newReview.Stars = Convert.ToDouble(Console.ReadLine());
                        Log.Information("Saving user's review");
                        logic.AddReview(newReview);
                    }
                    catch (Exception ex)
                    {
                        Log.Warning("Failed to add review");
                        Console.WriteLine(ex.Message);
                    }
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
