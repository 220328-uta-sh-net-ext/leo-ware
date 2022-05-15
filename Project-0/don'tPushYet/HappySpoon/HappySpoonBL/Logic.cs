using HappySpoonBL;
using HappySpoonDL;
using HappySpoonModels;
using System.Collections.Generic;

namespace HappySpoonBL
{
    public class Logic : ILogic
    {
        readonly IRepo repo;
        public Logic(IRepo repo)
        {
            this.repo = repo;
        }


        public RestaurantProfile AddRestaurant(RestaurantProfile rp)
        {
            RestaurantProfile restaurant = new RestaurantProfile
            {
                RestaurantID = rp.RestaurantID,
                Name = rp.Name,
                Description = rp.Description,
                Location = rp.Location,
                ContactInfo = rp.ContactInfo,
                AverageStars = 0
            };
            return repo.AddRestaurant(rp);
        }


        public List<RestaurantProfile> SearchRestaurants(string rName)
        {
            List<RestaurantProfile>? restaurants = repo.GetAllRestaurants();
            var filterRP = restaurants;
            filterRP = restaurants.Where(x => x.Name == rName).ToList();
            if (! rName.Equals(rName))
                throw new InvalidDataException("There are no restaurants by that name");
            else
            return repo.GetAllRestaurants();
        }

        public List<RestaurantProfile> GetRestaurant(RestaurantProfile rp)
        {
           
            return repo.GetAllRestaurants();
        }

        public Review AddReview(Review newReview)
        {
            Review review = new Review()
            {
                Restaurant = newReview.Restaurant,
                UserName = newReview.UserName,
                Comments = newReview.Comments,
                Stars = newReview.Stars
            };
            return repo.AddReview(newReview);
        }

        public List<RestaurantProfile> GetAllRestaurants()
        {
            
            return repo.GetAllRestaurants();

            //throw new InvalidDataException("There are no restaurants by that name");
        }


        // *****************************************~ USER ~************************************************

        public UserProfile AddUser(UserProfile User)
        {

            return repo.AddUser(User);
        }

        public List<UserProfile> GetAllUsers()
        {
            return repo.GetAllUsers();
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
            List<UserProfile>? users = repo.GetAllUsers();
            foreach (var u in users)
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
            List<UserProfile>? users = repo.GetAllUsers();
            var filterRP = users;
            if (input == "name")
                filterRP = users.Where(x => x.UserName == input).ToList();
            return filterRP;
        }


    }


}
