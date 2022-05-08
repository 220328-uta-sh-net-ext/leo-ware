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
        RestaurantProfile AddRestaurant(RestaurantProfile restaurant);
        Review AddReview(Review newReview);
        List<RestaurantProfile> GetAllRestaurants();
    }

    public interface IUserLogic
    {
        UserProfile AddUser(UserProfile User);
        List<UserProfile> GetAllUsers();


    }
       
}
