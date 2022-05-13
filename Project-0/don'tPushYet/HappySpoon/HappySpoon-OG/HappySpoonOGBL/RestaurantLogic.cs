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


        public List<RestaurantProfile> SearchRestaurants(string rName, string input)
        {
            List<RestaurantProfile>? restaurants = RPrepo.GetAllRestaurants();
            var filterRP = restaurants;
            if (input == rName)
                return filterRP;
            filterRP = restaurants.Where(x => x.Name == input).ToList();
            return filterRP;
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
            return RPrepo.AddReview(newReview);
        }

        public List<RestaurantProfile> GetAllRestaurants()
        {
            var restaurants = new List<RestaurantProfile>();
            if (restaurants.Count > 0)
            foreach (RestaurantProfile? restaurant in restaurants)
            {
                return restaurants;
            }
            throw new Exception("There are no restaurants by that name");
        }


        // ***************************************** TRYING TO CALCULATE RATING ************************************************

    }


}
