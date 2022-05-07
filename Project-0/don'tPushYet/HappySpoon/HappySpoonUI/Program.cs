global using Serilog;
using HappySpoonBL;
using HappySpoonDL;
using HappySpoonUI;


//Implementing main menu options with menu interface
bool repeat = true;
IMenu menu = new MainMenu();
//string connect server string stuff from text file goes her. PLEASE PUT THIS STRING IN THE .GITIGNORE FILE FIRST!!!
//LoginSignupInterface loginSignupMenu = new LoginSignupMenu();
//adding

while (repeat)
{
    menu.Display();
    string answer = menu.UserChoices();
    
    switch (answer)
    {
        case "SearchRestaurantsMenu":
            menu = new SearchRestaurantsMenu();
            break;
        case "LoginMenu":
            menu = new LoginMenu();
            break;
        case "AddUserMenu":
            menu = new AddUserMenu();
            break;
        case "MainMenu":
            menu = new MainMenu();
            break;
        case "ExitProgram":
            repeat = false;
            break;
        default:
            Console.WriteLine("View not found \nPlease press <enter> to continue.");
            break;
    }
    
    answer = Console.ReadLine();

    ///<summary>
    ///* I set the "answer" variable outside of the while loop so that it would stop repeating my main menu and being weird.
    ///* Make sure that the cases match what you've named your cases in the Main Menu class
    ///</summary>
}


