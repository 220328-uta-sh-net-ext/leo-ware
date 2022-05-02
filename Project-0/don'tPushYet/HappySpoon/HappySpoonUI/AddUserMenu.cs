using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonDL;
using HappySpoonModels;


namespace HappySpoonUI
{
    internal class AddUserMenu : IMenu
    {
        //static non-access modifier is needed to keep this variable consistent to all objects we create out of our AddUserMenu
        //static readonly UserProfile users = new UserProfile();  //(object userName, object userEmail);

        //private IRepository _repository = new Repository(); //UpCasting
        readonly UserRepo repo = new UserRepo();

        public int UserID { get; set; }
        public char UserName { get; set; }
        public char UserPassword { get; set; }
        public char UserEmail { get; set; }
        
        IMenu menu = new AddUserMenu();

        public string UserChoices()
        {
            throw new NotImplementedException();
        }

        void IMenu.Display()
        {
            Console.WriteLine("Enter user information");
            //feel free to add more options here....
            Console.WriteLine("<1> Username - " + UserName);
            Console.WriteLine("<2> Email - " + UserEmail);
            Console.WriteLine("<3> Password - " + UserPassword);
            Console.WriteLine("<4> Save" + UserID);
            Console.WriteLine("<0> Back to MainMenu");
        }

        string IMenu.UserChoices()
        {
            int i = 0;
            i++;
            var userInput = Console.ReadLine();
          
            switch (userInput)
            {
                case "0":
                    return "MainMenu";
                case "4":
                    UserID = i;
                    try
                    {
                        Log.Information("Adding new user information" + UserID + UserName + UserEmail + UserPassword);
                        return repo.AddUser();
                        Log.Information("User added successfully");
                    }
                    catch (Exception ex)
                    {
                        Log.Warning("Failed to add user information");
                        Console.WriteLine(ex.Message);

                    }
                    return "AddUser";
                case "3":
                    Console.Write("Please enter 5 numbers.This will be your password going forward");
                    UserPassword = Convert.ToChar(Console.ReadLine());
                    return "AddUser";
                case "2":
                    Console.Write("Please enter an email");
                    UserEmail = Convert.ToChar(Console.ReadLine());
                    return "AddUser";
                case "1":
                    Console.Write("Please enter a username");
                    UserName = Convert.ToChar(Console.ReadLine());
                    return "AddUser";
                /// Add more cases for any other attributes of pokemon
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
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
