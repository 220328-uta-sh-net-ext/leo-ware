using System.Collections.Generic;
using System;
using HappySpoonBL;
using HappySpoonDL;
using HappySpoonModels;

namespace HappySpoonBL
{
    public class UserInfoLogic : IUserLogic
    {
        
        readonly IUser urepo;
        public UserInfoLogic(IUser repo)
        {
            urepo = repo;
        }

        public void AddRestaurant(RestaurantProfile rp)
        {
            throw new NotImplementedException();
        }

        public UserProfile AddUser(UserProfile User)
        {

            return urepo.AddUser(User);
        }

        public List<UserProfile> GetAllUsers()
        {
            return urepo.GetAllUsers();
        }
        /// <summary>
        /// Method to 
        /// </summary>
        /// <param name="uName"></param>
        /// <param name="uPassword"></param>
        /// <returns></returns>
        /// <exception cref="InvalidDataException"></exception>
        public List<UserProfile> GetUser(string uName, string uPassword)
        {
            List<UserProfile>? users = urepo.GetAllUsers();
            foreach(var u in users)
            {
                if (uName == u.UserName && uPassword == u.UserPassword)
                {
                    return users;
                }
                else if (u.AdminName.Equals("El Jefe") && u.AdminPassword.Equals(1234))
                {
                        return users;
                }
                else
                    throw new InvalidDataException("Please input a valid username and password to use this feature");

            }
            return users;
        }

        /// <summary>
        /// Search users by username.
        /// </summary>
        /// <param name="uName"></param>
        /// <param name="input"></param>
        /// <returns>
        /// filters users by username.
        /// </returns>
        public List<UserProfile> SearchAllUsers(string uName, string input)
        {
            List<UserProfile>? users = urepo.GetAllUsers();
            var filterRP = users;
            if (input == "name")
                filterRP = users.Where(x => x.UserName == input).ToList();
            return filterRP;
        }



    }

}