using HappySpoonBL;
using HappySpoonDL;
using HappySpoonModels;
using System.Collections.Generic;

namespace HappySpoonBL
{
    public class RestaurantLogic : IRestaurantLogic
    {
        readonly IRestaurant RPrepo;
        public RestaurantLogic(IRestaurant repo)
        {
            RPrepo = repo;
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
            return RPrepo.AddRestaurant(rp);
        }


        public List<RestaurantProfile> SearchRestaurants(string name, string input)
        {
            List<RestaurantProfile>? restaurants = RPrepo.GetAllRestaurants();
            var filterRP = restaurants;
            if(input == name)
                filterRP = restaurants.Where(x => x.Name == input).ToList();
            return filterRP;
        }

        public Review AddReview(Review newReview)
        {
            return RPrepo.AddReview(newReview);
        }

        public List<RestaurantProfile> GetAllRestaurants()
        {
           List<RestaurantProfile> restaurants = RPrepo.GetAllRestaurants();
            foreach(var restaurant in restaurants)
            {
                return restaurants;
            }

            throw new Exception("There are no restaurants by that name");
        }


        // ***************************************** TRYING TO CALCULATE RATING ************************************************

    }


}
