using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonModels;

namespace HappySpoonBL
{
    
    public interface IRestaurantLogic
    {
        RestaurantProfile AddRestaurant(RestaurantProfile rp);
        Review AddReview(Review newReview);
        List<RestaurantProfile> GetAllRestaurants();
        List<RestaurantProfile> SearchRestaurants(string rName, string input);
    }

    public interface IUserLogic
    {
        UserProfile AddUser(UserProfile User);
        List<UserProfile> GetAllUsers();
        List<UserProfile> SearchAllUsers(string uName, string input);
        List<UserProfile> GetUser(string uName, string uPassword);
        void AddRestaurant(RestaurantProfile rp);
    }
       
}
