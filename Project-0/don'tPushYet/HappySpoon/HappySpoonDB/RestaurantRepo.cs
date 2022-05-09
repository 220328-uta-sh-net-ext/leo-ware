using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using HappySpoonDL;
using HappySpoonModels;

namespace HappySpoonDL
{
    
    public class RestaurantRepo : IRestaurant
    {
        private string connectionString;

        public RestaurantRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public RestaurantProfile AddRestaurant(RestaurantProfile Restaurant)
        {
            throw new NotImplementedException();
            return AddRestaurant(Restaurant);
        }
        public List<RestaurantProfile> SearchRestaurants()
        {
            throw new NotImplementedException();
            return GetAllRestaurants();
        }

        public List<RestaurantProfile> GetAllRestaurants()
        {
            throw new NotImplementedException();
            return GetAllRestaurants();
        }


        public Review AddReview(Review newReview)
        {
            return AddReview(newReview);
        }
    }


}
