global using Serilog;
using HappySpoonBL;
using HappySpoonDL;
using HappySpoonUI;


ILogic logic;


//Implementing main menu options with menu interface
bool repeat = true;
    IMenu menu = new MainMenu();
//LoginSignupInterface loginSignupMenu = new LoginSignupMenu();


while (repeat)
{
    menu.Display();
    string answer = menu.UserChoices();
    
    switch (answer)
    {
        case "SearchRestaurants":
            Console.WriteLine("Restaurant search in progress...");
            menu = new SearchRestaurantsMenu(repo, logic);
            break;
        case "Login":
            Console.WriteLine("Login in progress...");
            menu = new LoginMenu(UserInfoLogic logic);
            break;
        case "AddUser":
            Console.WriteLine("Signup in progress...");
            menu = new AddUserMenu(repo);
            break;
        case "MainMenu":
            menu = new MainMenu();
            break;
        case "Exit":
            repeat = false;
            break;
        default:
            Console.WriteLine("View not found \nPlease press <enter> to continue.");
            break;
    }
    Console.WriteLine("Please choose from the following options");
    answer = Console.ReadLine();
}


