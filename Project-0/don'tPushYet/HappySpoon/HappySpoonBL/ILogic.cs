using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonModels;

namespace HappySpoonBL
{
    
    public interface ILogic
    {
        RestaurantProfile AddRestaurant(RestaurantProfile rp);
        List<RestaurantProfile> GetAllRestaurants();
        List<RestaurantProfile> SearchRestaurants(string rName);
        List<RestaurantProfile> GetRestaurant(RestaurantProfile rp);
        Review AddReview(Review newReview);

        //*************************************************~ USER ~*************************************************

        UserProfile AddUser(UserProfile User);
        List<UserProfile> GetAllUsers();
        List<UserProfile> SearchAllUsers(string uName, string userInput);
        List<UserProfile> GetUser(string uName, string uPassword);

    }
       
}
