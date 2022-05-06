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
        RestaurantProfile AddRestaurant(RestaurantProfile Restaurant);
        List<RestaurantProfile> GetAllRestaurants();
        


        //***************************************~ REVIEW ~********************************************

        //List<Review> GetReviews();
        void AddReview(string RestaurantID, int newReview);

        void RemoveReview(string RestaurantID);


    }

    public interface IUser
    {
        List<UserProfile> GetAllUsers();

        UserProfile AddUser(UserProfile User);
    }

}
