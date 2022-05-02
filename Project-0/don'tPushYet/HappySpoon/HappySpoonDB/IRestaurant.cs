using HappySpoonModels;

namespace HappySpoonDL
{
    public interface IRestaurant
    {
        void AddRestaurant(RestaurantRepo Restaurants);


        List<RestaurantProfile> GetRestaurants { get; }


        List<RestaurantProfile> SearchRestaurants();

    }

}
