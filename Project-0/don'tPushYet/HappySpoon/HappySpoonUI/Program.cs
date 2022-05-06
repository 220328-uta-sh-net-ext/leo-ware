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
            Console.WriteLine("Restaurant search in progress...");
            menu = new SearchRestaurantsMenu();
            break;
        case "LoginMenu":
            Console.WriteLine("Login in progress...");
            menu = new LoginMenu();
            break;
        case "AddUserMenu":
            Console.WriteLine("Signup in progress...");
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
}


