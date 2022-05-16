using HappySpoonBL;
using HappySpoonDL;
using HappySpoonModels;
using System.Collections.Generic;
using System.Linq;

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
            /*RestaurantProfile restaurant = new RestaurantProfile
            {
                RestaurantID = rp.RestaurantID,
                Name = rp.Name,
                Description = rp.Description,
                Location = rp.Location,
                ContactInfo = rp.ContactInfo,
                AverageStars = 0
            };*/

            if (rp.Name == null || rp.Description == null || rp.Location == null)
            {
                throw new InvalidDataException("Restaurant name, description and/or location may not be null. Please enter valid input");
            }

            List<RestaurantProfile>? restaurants = repo.GetAllRestaurants();
            foreach (var userExists in restaurants)
            {
                if (rp.Name != userExists.Name)
                    continue;
                throw new Exception("This restaurant already exists. Please enter an alternate username or password.");
            }
            return repo.AddRestaurant(rp);
        }


        public List<RestaurantProfile> SearchRestaurants(string rName)
        {
            List<RestaurantProfile>? restaurants = repo.GetAllRestaurants();

            var filterRP = restaurants;
            filterRP = restaurants.Where(x => x.Name == rName).ToList();
            if (filterRP == null)
                throw new InvalidDataException("There are no restaurants by that name");
            else
            return repo.GetAllRestaurants();
        }


        public Review AddReview(Review newReview)
        {
            return repo.AddReview(newReview);
        }

        public List<Review> SearchReviews(string rName)
        {
            List<Review>? reviews = repo.GetReviews();

            var filterRP = reviews;
            filterRP = reviews.Where(x => x.Restaurant == rName).ToList();
            if (filterRP == null)
                throw new InvalidDataException("There are no restaurants by that name");
            else
                return repo.GetReviews();
        }

        // *****************************************~ USER ~************************************************

        public UserProfile AddUser(UserProfile User)
        {
            

            if (User.UserPassword == null || User.UserName == null || User.UserEmail == null)
            {
                throw new InvalidDataException("Username and/or password may not be null. Please enter valid input");
            }
            
            List<UserProfile>? users = repo.GetAllUsers();
            foreach (var userExists in users)
            {
                if (User.UserName != userExists.UserName || User.UserEmail != userExists.UserEmail)
                    continue;
                throw new Exception("This user already exists. Please enter an alternate username or password.");
            }
            //var userExists = users;
            //userExists = (List<UserProfile>)users.Where(x => (x.UserName.Equals(User.UserName) && (x.UserEmail.Equals(User.UserEmail))));
            //throw new Exception("This user already exists. Please enter an alternate username or password.");
            return repo.AddUser(User);
        }

        /// <summary>
        /// Method to let users login with their username and password
        /// </summary>
        /// <param name="uName"></param>
        /// <param name="uPassword"></param>
        /// <returns> name="users" </returns>
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
        public List<UserProfile> SearchUsers(string uName)
        {
            List<UserProfile>? users = repo.GetAllUsers();
            var filterRP = users;
                filterRP = users.Where(x => x.UserName.Contains(uName)).ToList();
            return filterRP;
        }


    }


}
