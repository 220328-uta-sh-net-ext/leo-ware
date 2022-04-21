using System;
using HappySpoonUI;

//Implementing main menu options with menu interface
bool repeat = true;
MainMenuInterface menu = new MainMenu();
LoginSignupInterface loginSignupMenu = new LoginSignupMenu();


while (repeat)
{
      menu.MainMenuDisplay();
      string answer = menu.MainMenuChoices();

      switch (answer)
      {
            case "SearchRestaurants":
                  Console.WriteLine("Restaurant search in progress...");
                  break;
            case "LoginSignup":
                  Console.WriteLine("Login / Signup in progress...");
                  loginSignupMenu.LoginSignupMenuDisplay();
                  break;
            //case "MainMenu":
            //menu = new MainMenu(); 
              //    break;
            case "Exit":
                  repeat = false;
                  break;
            default:
                  Console.WriteLine("View not found");
                  Console.WriteLine("Please press <enter> to continue.");
                  Console.ReadLine();
                  menu.MainMenuChoices();
                  break;
      }
}




while (repeat)
{
    loginSignupMenu.LoginSignupMenuDisplay();
    //string answer = loginNavigation(loginSignup);
    string answer = loginSignupMenu.LoginSignupChoices();

    switch (answer)
    {
        case "Login":
            loginSignupMenu = new LoginSignupMenu();
            break;

        case "Signup":
            break;

        case "MainMenu":
            menu.MainMenuDisplay();
            break;

        default:
            Console.WriteLine("View not found");
            Console.WriteLine("Please press <enter> to continue.");
            Console.ReadLine();
            loginSignupMenu.LoginSignupChoices();
            break;
    }
}