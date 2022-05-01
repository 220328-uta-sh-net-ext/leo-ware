using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonDL;

namespace HappySpoonUI
{
    internal class AddReviewMenu : MenuInterface
    {
        private static Rev
        public void Display()
        {
            Console.WriteLine("Thank you for contributing your valuable feedbak to our platform!");

            Console.WriteLine("Press <1> Add Review");
            Console.WriteLine("Press <2> Add Rating");
            Console.WriteLine("Press <0> Exit Program");
        }

        public string UserChoices()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    return "AddReview";
                case "2":
                    return "AddRating";
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
