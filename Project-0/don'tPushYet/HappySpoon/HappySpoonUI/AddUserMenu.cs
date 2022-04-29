using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonBL;
using HappySpoonDL;
using HappySpoonModels;


namespace HappySpoonUI
{
    internal class AddUserMenu : MenuInterface
    {
        //static non-access modifier is needed to keep this variable consistent to all objects we create out of our AddPokeMenu
        static readonly UserProfile newUser = new UserProfile();  //(object userName, object userEmail);

        //private IRepository _repository = new Repository(); //UpCasting
        readonly UserInterface logic;

        public AddUserMenu(UserInterface logic)
        {
            this.logic = logic;
        }

        public static object userName { get; set; }

        public static object userEmail { get; set; }
        public void Display()
        {
            Console.WriteLine("Enter user information");
            //feel free to add more options here....
            Console.WriteLine("<1> Username - " + newUser.userName);
            Console.WriteLine("<2> Email - " + newUser.userEmail);
            Console.WriteLine("<3> Save");
            Console.WriteLine("<0> Back to MainMenu");
        }

        public string UserChoices()
        {
            string userInput = Console.ReadLine();
          
            switch (userInput)
            {
                case "0":
                    return "MainMenu";
                case "3":
                    try
                    {
                        Log.Information("Adding your user" + newUser.userName);
                        return logic.AddUser(newUser);
                        Log.Information("User added successfully");
                    }
                    catch (Exception ex)
                    {
                        Log.Warning("Failed to add user information");
                        Console.WriteLine(ex.Message);

                    }
                    return "MainMenu";
                case "2":
                    Console.Write("Please enter an email");
                    newUser.userEmail = Console.ReadLine();
                    return "AddUser";
                case "1":
                    Console.Write("Please enter a username");
                    newUser.userName = Console.ReadLine();
                    return "AddUser";
                /// Add more cases for any other attributes of pokemon
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "AddUser";
            }
        }
    }

    /* Search User?
    internal class SearchUsersMenu
    {
       UserInterface repo = new UserInfoLogic();
    }
    */
}
