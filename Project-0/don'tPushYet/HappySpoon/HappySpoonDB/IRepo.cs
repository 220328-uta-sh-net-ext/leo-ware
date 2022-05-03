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
        List<UserProfile> GetUsers(); 

        List<UserProfile> GetUsersConnected();

        void AddUser(UserProfile User);



        //**************************************~ RESTAURANT INTERFACE ~****************************************

        List<RestaurantProfile> GetRestaurants();
        void AddRestaurant(RestaurantProfile restaurant);
        List<RestaurantProfile> GetRestaurantsConnected();
        


        //***************************************~ REVIEW INTERFACE ~********************************************

        List<Review> GetReviews();
        Review AddReview(Review review);
    }

}
