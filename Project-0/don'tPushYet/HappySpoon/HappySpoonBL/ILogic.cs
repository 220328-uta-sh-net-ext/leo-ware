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
        UserProfile GetUsers(string username);
        List<UserProfile> SearchAllUsers();

    }
        
   
        List<UserProfile> SearchUsers();
        
        List<UserProfile> GetPassword(string password);

        List<RestaurantProfile> SearchAllRestaurants();
        List<RestaurantProfile> SearchRestaurants();
       
    }
