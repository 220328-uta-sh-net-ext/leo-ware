global using Serilog;
using HappySpoonBL;
using HappySpoonDL;
using HappySpoonUI;


//Implementing main menu options with menu interface

IMenu menu = new MainMenu();
bool repeat = true;

//string connect server string stuff from text file goes here. PLEASE PUT THIS STRING IN THE .GITIGNORE FILE FIRST!!!
string connectionStringFilePath = "C:/Revature/leo-ware/Project-0/don'tPushYet/HappySpoon/HappySpoonDB/Secrets.txt";
string connectionString = File.ReadAllText(connectionStringFilePath);


IUser urepo = new UserRepo(connectionString);
IRestaurant RPrepo = new RestaurantRepo(connectionString);
IUserLogic uLogic = new UserInfoLogic(urepo);
IRestaurantLogic rLogic = new RestaurantLogic(RPrepo);


Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.File("C:/Revature/leo-ware/Project-0/don'tPushYet/HappySpoon/HappySpoonUI/LogCabin.txt")
    .CreateLogger();


while (repeat)
{
    menu.Display();
    string userInput = menu.UserChoices();

    switch (userInput)
    {
        case "SearchRestaurantsMenu":
            menu = new SearchRestaurantsMenu(rLogic, RPrepo);
            break;
        case "AddReviewMenu":
            menu = new AddReviewMenu(rLogic);
            break;
        case "LoginMenu":
            menu = new LoginMenu(uLogic);
            break;
        case "AddUserMenu":
            menu = new AddUserMenu(uLogic);
            break;
        case "AdminMenu":
            menu = new AdminMenu(uLogic, rLogic);
            break;
        case "MainMenu":
            menu = new MainMenu();
            break;
        case "ExitProgram":
            repeat = false;
            break;
        default:
            Console.WriteLine("View not found \nPlease press <enter> to continue.");
            Console.ReadLine();
            menu = new MainMenu();
            break;
    }
    
    //userInput = Console.ReadLine();

    ///<summary>
    ///* I set the "answer" variable outside of the while loop so that it would stop repeating my main menu and being weird.
    ///* Make sure that the cases match what you've named your cases in the Main Menu class
    ///</summary>
}


