using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonDL;
using HappySpoonModels;


namespace HappySpoonUI
{
    public class AddUserMenu : IMenu
    {
        //static non-access modifier is needed to keep this variable consistent to all objects we create out of our AddUserMenu
       
        readonly UserRepo repo = new UserRepo();
        UserProfile User = new UserProfile();


        IMenu menu = new AddUserMenu();


        public void Display()
        {
            Console.WriteLine("Enter user information");
            //feel free to add more options here....
            Console.WriteLine("<1> Username - ");// + User.UserName
            Console.WriteLine("<2> Email - ");// + User.UserEmail
            Console.WriteLine("<3> Password - ");//+ User.UserPassword
            Console.WriteLine("<4> Save");//+ User.UserID
            Console.WriteLine("<0> Back to MainMenu");
        }

        public string UserChoices()
        {
            int i = 0;
            i++;
            string userInput = Convert.ToString(Console.ReadLine());
          
            switch (userInput)
            {
                case "0":
                    return "MainMenu";
                case "4":
                    User.UserID = Convert.ToString(i);
                    try
                    {
                        Log.Information("Adding new user information" + User.AddUser);//.UserID + UserProfile.UserName + UserProfile.UserEmail + UserProfile.UserPassword);
                        Console.WriteLine("Welcome to the HappySpoon community!");
                        Log.Information("User added successfully");
                        
                        
                        return "AddUser";
                    }
                    catch (Exception ex)
                    {
                        Log.Warning("Failed to add user information");
                        Console.WriteLine(ex.Message);

                    }
                    return "AddUser";
                case "3":
                    Console.Write("Please enter 5 numbers.This will be your password going forward");
                    User.UserPassword = Console.ReadLine();
                    return "AddUser";
                case "2":
                    Console.Write("Please enter an email");
                   User.UserEmail = Console.ReadLine();
                    return "AddUser";
                case "1":
                    Console.Write("Please enter a username");
                    User.UserName = Console.ReadLine();
                    return "AddUser";
                /// Add more cases for any other attributes of pokemon
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press <Enter> to continue");
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
