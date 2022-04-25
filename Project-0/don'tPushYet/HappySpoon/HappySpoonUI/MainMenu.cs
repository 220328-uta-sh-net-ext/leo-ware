using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappySpoonUI
{
      //Main Menu display and Main Menu choice interaction
    class MainMenu : MenuInterface
    {
            public void Display()
            {
                  Console.WriteLine("Welcome to Happy Spoon! ");
                  Console.WriteLine("Ready to find your new favorite restaurant?");
                  Console.WriteLine("Press <1>  Search Restaurants");
                  Console.WriteLine("Press <2> Login / Signup");
                  Console.WriteLine("Press <0> Exit Program");
                  //Console.WriteLine();
                  //Console.WriteLine();
            }


            public string UserChoices()
            {
                  string userInput = Console.ReadLine();

                  switch (userInput)
                  {
                        case "1":
                              return "SearchRestaurants";
                        case "2":
                              return "LoginSignup";
                        case "0":
                              return "ExitProgram";
                        default:
                              Console.WriteLine("Please enter a valid option.");
                              Console.WriteLine("Press <Enter> to continue");
                              Console.ReadLine();
                              return "MainMenu";
                  }
            }
            // ~***********************************End of Main Menu Program***************************************
    }
}
