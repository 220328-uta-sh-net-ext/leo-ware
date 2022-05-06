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


        public RestaurantProfile AddRestaurant(RestaurantProfile Restaurant)
        {
            return RPrepo.AddRestaurant(Restaurant);
        }


        public void RestaurantProfile(string Comments, int Stars)
        {
            
        }

        public List<RestaurantProfile> GetRestaurants()
        {
            return RPrepo.GetAllRestaurants();
        }

        public List<RestaurantProfile> SearchRestaurants(string name)
        {
            throw new NotImplementedException();
        }

        public void AddReview(string Comments, int Stars)
        {
            throw new NotImplementedException();
        }

        public List<RestaurantProfile> GetAllRestaurants()
        {
            throw new NotImplementedException();
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
