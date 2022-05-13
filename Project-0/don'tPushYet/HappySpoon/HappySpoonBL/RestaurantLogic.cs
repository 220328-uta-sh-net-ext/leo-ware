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


        public List<RestaurantProfile> SearchRestaurants(string rName)
        {
            List<RestaurantProfile>? restaurants = RPrepo.GetAllRestaurants();
            var filterRP = restaurants;
            filterRP = restaurants.Where(x => x.Name == rName).ToList();
            if (! rName.Equals(rName))
                throw new InvalidDataException("There are no restaurants by that name");
            else
            return filterRP;
        }

        /*public List<RestaurantProfile> GetRestaurant()
        {
            RestaurantRepo repo = new RestaurantRepo();
            var restaurant = repo.GetAllRestaurants();
            return restaurant;
        }*/

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



            IRestaurant RPrepo = new List<RestaurantProfile>();
            var restaurant = RPrepo.GetAllRestaurants();
            //if (restaurant.Count > 0)
                return restaurant;
            throw new InvalidDataException("There are no restaurants by that name");
        }


        // ***************************************** TRYING TO CALCULATE RATING ************************************************

    }


}
