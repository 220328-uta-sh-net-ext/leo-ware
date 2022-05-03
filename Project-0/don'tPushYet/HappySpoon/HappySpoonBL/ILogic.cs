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
        List<UserProfile> SearchAllUsers();
        List<UserProfile> SearchUsers();
        List<UserProfile> GetUsers(string username);
        List<UserProfile> GetPassword(string password);

        List<RestaurantProfile> SearchAllRestaurants();
        List<RestaurantProfile> SearchRestaurants();
        List<RestaurantProfile> AverageRating(int ratings);


        List<Review> GetReviews(string comments);
        List<Review> GetRatings(int stars);
    }
}
