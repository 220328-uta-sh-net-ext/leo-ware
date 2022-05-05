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
        void GetReview(string Comments, int Stars);
        List<RestaurantProfile> GetAllRestaurants();
    }

    public interface IUserLogic
    {
        UserProfile GetUsers(string UserName);
        void GetEmail(string UserEmail);
        void GetPassword(string UserPassword);
        List<UserProfile> GetAllUsers();

    }
       
}
