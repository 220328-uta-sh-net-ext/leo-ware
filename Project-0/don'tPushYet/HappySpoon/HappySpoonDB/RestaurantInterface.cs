using HappySpoonModels;

namespace HappySpoonUI
{
    public interface RestaurantInterface
    {
        RestaurantProfile AddRestaurant(RestaurantProfile restaurant);


        RestaurantProfile AddReview(RestaurantProfile review);


        List<RestaurantProfile> SearchRestaurants(string name);

    }

    interface ISearchRestaurants
    {
        List<RestaurantProfile> GetRestaurants();

    }
}
