using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappySpoonUI
{
      public class LoginSignupMenu : LoginSignupInterface
      {
            // Login / Signup Menu and Login / Signup Menu interaction program
            public void LoginSignupMenuDisplay()
            {
                  Console.WriteLine("Press <1> Login");
                  Console.WriteLine("Press <2> Signup");
                  Console.WriteLine("Press <0> Back to Main Menu");
            }

            public string LoginSignupChoices()
            {
                  string userInput = Console.ReadLine();
                  switch (userInput)
                  {
                        case "1":
                              return "Login";

                        case "2":
                              return "Signup";

                        case "0":
                              return "MainMenu";

                        default:
                              Console.WriteLine("Please enter a valid option.");
                              Console.WriteLine("Press <Enter> to continue");
                              Console.ReadLine();
                              return "LoginSignup";
                  }
            }
      }
}
