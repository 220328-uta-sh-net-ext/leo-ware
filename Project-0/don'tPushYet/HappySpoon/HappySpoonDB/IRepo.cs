using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonModels;

namespace HappySpoonDL
{
    public interface IRepo
    {
        //*********************************~ RESTAURANT INTERFACE ~************************************
        RestaurantProfile AddRestaurant(RestaurantProfile Restaurant);
        List<RestaurantProfile> GetAllRestaurants();

        /*public List<RestaurantProfile> SearchRestaurants(string rName);*/

        //***************************************~ REVIEW ~********************************************
        Review AddReview(Review newReview);
        List<Review> GetReviews();

        //***************************************~ USERS ~*********************************************
        List<UserProfile> GetAllUsers();

        UserProfile AddUser(UserProfile User);

        List<Admin> GetAdmin();
    }

}
