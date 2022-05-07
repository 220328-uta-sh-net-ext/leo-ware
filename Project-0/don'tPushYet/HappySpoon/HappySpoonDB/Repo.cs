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

        public RestaurantProfile AddRestaurant(RestaurantProfile Restaurants)
        {
            string selectCommandString = "INSERT INTO";
            using SqlConnection connection = new (connectionString);
            using SqlCommand command = new(selectCommandString, connection);
            command.Parameters.AddWithValue("@name", Restaurants.Name);
            connection.Open();
            command.ExecuteNonQuery();
            return Restaurants;
        }

        public Review AddReview(Review newReview)
        {
            string selectCommandString = $"INSERT INTO Review (Stars, Comments, Restaurant)" + "VALUES (@stars, @comments, @restaurant;";
            //string selectCommandString = $"UPDATE Restaurants SET AverageStars = AverageStars + @stars WHERE Restaurants = '{AverageStars}";
            using SqlConnection connection = new (connectionString);
            using SqlCommand command = new(selectCommandString, connection);
            command.Parameters.AddWithValue("@stars", newReview.Stars);
            command.Parameters.AddWithValue("@comments", newReview.Comments);
            command.Parameters.AddWithValue("@restaurant", newReview.Restaurant);
            connection.Open();
            command.ExecuteNonQuery();
            return newReview;
        }

        public List<Review> AverageStars
        {
            get
            {
                string selectCommandString = $"SELECT AVG(Stars) as AverageStarRating FROM Review GROUP BY Restaurant";
                using SqlConnection connection = new(connectionString);
                using SqlCommand command = new SqlCommand(selectCommandString, connection);
                connection.Open();
                using SqlDataReader reader = command.ExecuteReader();

                var averageStars = new List<RestaurantProfile>();

                while (reader.Read())
                {
                    averageStars.Add(new RestaurantProfile
                    {
                        AverageStars = reader.GetDouble(0),//Change the number here to the column of AverageStars in the RestaurantProfile table
                    });
                }
                return AverageStars;
            }
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
