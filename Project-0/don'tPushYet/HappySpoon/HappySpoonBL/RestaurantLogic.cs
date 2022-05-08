using HappySpoonBL;
using HappySpoonDL;
using HappySpoonModels;
using System.Collections.Generic;

namespace HappySpoonBL
{
    public class RestaurantLogic : IRestaurantLogic
    {
        readonly IRestaurant RPrepo;

        public RestaurantLogic()
        {

        }

        public RestaurantLogic(IRestaurant repo)
        {
            RPrepo = repo;
        }


        public RestaurantProfile AddRestaurant(RestaurantProfile restaurant)
        {
            return RPrepo.AddRestaurant(restaurant);
        }


        public List<RestaurantProfile> GetRestaurants()
        {
            return RPrepo.GetAllRestaurants();
        }

        public List<RestaurantProfile> SearchRestaurants(string name)
        {
            return RPrepo.GetAllRestaurants();
        }

        public Review AddReview(Review newReview)
        {
            throw new NotImplementedException();
            return RPrepo.AddReview(newReview);
        }

        public List<RestaurantProfile> GetAllRestaurants()
        {
            return RPrepo.GetAllRestaurants();
        }

        /*public void SearchRestaurants(string phrase)
        {
            var target = GetRestaurants.Where(r => r.Name.Contains(phrase)).ToList();
            foreach (var restaurant in target)
            {
                return RPrepo.GetRestaurants(restaurant);
            }
        }*/


        // ***************************************** TRYING TO CALCULATE RATING ************************************************

    }


}
