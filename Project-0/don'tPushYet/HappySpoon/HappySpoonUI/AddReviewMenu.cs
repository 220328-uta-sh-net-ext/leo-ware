using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonDL;
using HappySpoonModels;
namespace HappySpoonUI
{
    internal class AddReviewMenu : IMenu
    {
        
        void IMenu.Display()
        {
            Console.WriteLine("Thank you for contributing your valuable feedbak to our platform!");

            Console.WriteLine("Press <1> Add Review");
            Console.WriteLine("Press <2> Add Rating");
            Console.WriteLine("Press <3> Save");
            Console.WriteLine("Press <4> Back to Main Menu");
            Console.WriteLine("Press <0> Exit Program");
        }

        public string UserChoices()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Comments = Console.ReadLine();
                    return "AddReview";
                case "2":
                    Rating = Console.ReadLine();
                    return "AddRating";
                case "3":
                    try
                    {
                        Log.Information("Adding your user" + Comments + Rating);
                        return repo.AddReview();
                        Log.Information("User feedback added successfully");
                    }
                    catch (Exception ex)
                    {
                        Log.Warning("Failed to add user feedback");
                        Console.WriteLine(ex.Message);

                    }
                    return "AddReviewMenu";
                case "4":
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
