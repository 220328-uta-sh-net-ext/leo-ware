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
        List<RestaurantProfile> SearchRestaurants(string rName);
        Review AddReview(Review newReview);
        List<Review> SearchReviews(string rName);

        //*************************************************~ USER ~*************************************************

        UserProfile AddUser(UserProfile User);
        List<UserProfile> SearchUsers(string uName);
        List<UserProfile> GetUser(string uName, string uPassword);

    }
       
}
