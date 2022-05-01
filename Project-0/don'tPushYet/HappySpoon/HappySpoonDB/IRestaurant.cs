using HappySpoonModels;

namespace HappySpoonDL
{
    public interface IRestaurant
    {
        RestaurantRepo AddRestaurant(RestaurantProfile restaurantName);


        


        List<RestaurantRepo> SearchRestaurants();

    }

    interface ISearchRestaurants
    {
        List<RestaurantRepo> GetRestaurants();

    }
}
