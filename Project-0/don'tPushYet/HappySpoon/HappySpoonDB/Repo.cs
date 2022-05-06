using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using HappySpoonModels;

namespace HappySpoonDL
{
    
    public class RestaurantRepo : IRestaurant
    {
        readonly string connectionString;
        RestaurantRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public RestaurantProfile AddRestaurant(RestaurantProfile Restaurant)
        {
            string selectCommandString = "INSERT INTO";
            using SqlConnection connection = new (connectionString);
            using SqlCommand command = new(selectCommandString, connection);
            command.Parameters.AddWithValue("@name", Restaurant.Name);
            connection.Open();
            command.ExecuteNonQuery();
            return Restaurant;
        }

        public void AddReview(string RestaurantID, int newReview)
        {
            throw new NotImplementedException();
            string selectCommandString = $"UPDATE ResstaurantProfiile SET Review = Review + @stars, NumStars = NumStars + 1 WHERE RestaurantId = '{RestaurantID}'";
            using SqlConnection connection = new (connectionString);
            using SqlCommand command = new(selectCommandString, connection);
            command.Parameters.AddWithValue("@stars", newReview);
            connection.Open();
            command.ExecuteNonQuery();
        }

        public List<RestaurantProfile> GetAllRestaurants()
        {
            string selectCommandString = "SELECT * FROM ";
            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(selectCommandString, connection);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();
            
            var restaurants = new List<RestaurantProfile>();
            while (reader.Read())
            {
                restaurants.Add(new RestaurantProfile
                {
                    Name = reader.GetString(0),
                });
            }
            return restaurants;
        }

        public List<RestaurantProfile> GetRestaurants()
        {
            throw new NotImplementedException();
        }

        public void RemoveReview(string RestaurantID)
        {
            throw new NotImplementedException();
        }


    }

    public class UserRepo : IUser
    {
        readonly string connectionString;

        UserRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public UserProfile AddUser(UserProfile User)
        {
            throw new NotImplementedException();
        }

        public List<UserProfile> GetAllUsers()
        {
            throw new NotImplementedException();
        }


    }

}
