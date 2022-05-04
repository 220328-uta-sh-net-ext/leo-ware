using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonUI;
using HappySpoonModels;


namespace HappySpoonUI
{
    public class AddUserMenu : IMenu
    {
        //static non-access modifier is needed to keep this variable consistent to all objects we create out of our AddUserMenu

        /*private readonly UserProfile newUser = new UserProfile();
        readonly IRepo repo;
        readonly UserInfoLogic logic;
        
        public AddUserMenu(IRepo? repo, UserInfoLogic? logic)
        {
            this.repo = repo;
            this.logic = logic;
        }*/

        public void Display()
        {
            Console.WriteLine("<1> Enter user information");
            Console.WriteLine("<0> Back to Main Menu");
        }

        public string UserChoices()
        {
            int i = 0;
            i++;
            string userInput = Convert.ToString(Console.ReadLine());
          
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Creating new user profile...");
                    /*while (true)
                    {
                        Console.WriteLine("Enter a username: ");
                        newUser.UserName = Console.ReadLine();
                        if (newUser.UserName != "")
                        {
                            List<UserProfile> User = logic.GetConnectedUsers(newUser.UserName);
                            foreach (var user in User)
                            {
                                if (user.UserName == newUser.UserName)
                                {
                                    Console.WriteLine("Sorry. That username is taken...");
                                    goto case "1";
                                }
                                else break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Username can not be Empty");
                            goto case "1";
                        }
                        CreatePassword:
                        Console.WriteLine("Enter a password: ");
                        newUser.UserPassword = Console.ReadLine();
                        if (newUser.UserPassword.Length > 3 && newUser.UserPassword.Length < 10)
                        {
                            List<UserProfile> UserProfile = logic.GetUser(newUser.UserPassword);
                            foreach (var user in UserProfile)
                            {
                                if (user.UserPassword == newUser.UserPassword)
                                {
                                    Console.WriteLine("Sorry. That password is taken...");
                                    goto CreatePassword;
                                }
                                else break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Password length may not be less than 4 or greater than 10");
                            goto CreatePassword;
                        }
                        
                    EnterEmail:
                        Console.WriteLine("Enter your email: ");
                        newUser.UserEmail = Console.ReadLine();
                        if (newUser.UserEmail.Contains("@."))
                        {
                            List<UserProfile> UserProfile = logic.GetUser(newUser.UserPassword);
                            Console.WriteLine($"Congratulations {newUser.UserName}! Your account has been created :D");
                            try
                            {
                                Log.Information("Creating new user profile: " + newUser.UserName);
                                repo.AddUser(newUser);
                                return "LoginMenu";
                            }
                            catch (Exception ex)
                            {
                                Log.Information("Failed to Create Account");
                                Console.WriteLine(ex.Message);
                                goto case "1";
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid email address");
                            goto EnterEmail;

                        }
                    }*/
                    return "AddUserMenu";
                case "0":
                    Console.Write("*************~ Loading Main Menu ~*************");
                    return "MainMenu";
                default:
                    Console.WriteLine("Please input a valid response\nPress <Enter> to continue");
                    return "AddUserMenu";
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
