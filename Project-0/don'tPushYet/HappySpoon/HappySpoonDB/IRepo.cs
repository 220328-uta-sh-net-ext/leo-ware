using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonModels;

namespace HappySpoonDL
{
    public interface IRestaurant
    {
        //**************************************~ RESTAURANT INTERFACE ~****************************************

        List<RestaurantProfile> GetRestaurants();
        RestaurantProfile AddRestaurant(RestaurantProfile newRestaurant);
        List<RestaurantProfile> GetAllRestaurants();
        


        //***************************************~ REVIEW ~********************************************

        //List<Review> GetReviews();
        void AddReview(string RestaurantID, int newReview);
    }

    public interface IUser
    {
        List<UserProfile> GetUsers();

        List<UserProfile> GetAllUsers();

        UserProfile AddUser(UserProfile newUser);
    }

}
