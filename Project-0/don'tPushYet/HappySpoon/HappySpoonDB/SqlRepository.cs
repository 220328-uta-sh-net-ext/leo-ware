using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonDL;
using HappySpoonModels;

namespace HappySpoonDL
{
    public class SqlRepository : IRestaurant//, IUser
    {
        private SqlRepository(string connectionString)
        {
            this.connectionString = File.ReadAllText(connectionStringFilePath);
        }
        private const string connectionStringFilePath = "C:/Revature/leo-ware/Project-0/don'tPushYet/HappySpoon/HappySpoonDB/Secrets.txt";
        readonly string connectionString;

        public List<RestaurantProfile> GetRestaurants()
        {

            string commandString = "SELECT * FROM Restaurants;";
            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new SqlCommand(commandString, connection);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();
            var restaurants = new List<RestaurantProfile>();
            while (reader.Read())
            {
                restaurants.Add(new RestaurantProfile
                {
                    RestaurantID = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Description = reader.GetString(2),
                    Location = reader.GetString(3),
                    ContactInfo = reader.GetString(4),
                    AverageStars = reader.GetInt32(5)
                    
                });
            }
            connection.Close();
            return restaurants;
        }





        public List<RestaurantProfile> GetAllRestaurants()
        {
            string commandString = "SELECT * FROM Restaurants;";
            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new SqlCommand(commandString, connection);
            using SqlDataReader reader = command.ExecuteReader();
            connection.Open();
            
            var restaurants = new List<RestaurantProfile>();
            while (reader.Read())
            {
                restaurants.Add(new RestaurantProfile
                {
                    RestaurantID = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Description = reader.GetString(2),
                    Location = reader.GetString(3),
                    ContactInfo = reader.GetString(4),
                    AverageStars = reader.GetDouble(5)

                });
            }
            connection.Close();
            return restaurants;
        }

        public List<Review> GetReviews()
        {
            string commandString = "SELECT * FROM Review GROUP BY Restaurant;";
            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new SqlCommand(@commandString, connection);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();

            var reviews = new List<Review>();
            while (reader.Read())
            {
                reviews.Add(new Review
                {
                    UserName = reader.GetString(1),
                    Restaurant = reader.GetString(2),
                    Comments = reader.GetString(3),
                    Stars = reader.GetDouble(4)
                });
            }
            connection.Close();
            return reviews;
        }


        public Review AddReview(Review newReview)
        {
            string commandString = "INSERT INTO Reviews (Restaurant, UserName, Comments, Stars) VALUES (@username, @restaurant, @comments, @stars)";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new SqlCommand(commandString, connection);
            command.Parameters.AddWithValue("@restaurant", newReview.Restaurant);
            command.Parameters.AddWithValue("@username", newReview.UserName);
            command.Parameters.AddWithValue("@comments", newReview.Comments);
            command.Parameters.AddWithValue("@stars", newReview.Stars);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            return newReview;
        }

        public RestaurantProfile AddRestaurant(RestaurantProfile restaurant)
        {
            string commandString = "INSERT INTO Restaurants (RestaurantId, Name, Description, Location, ContactInfo, AverageStars) VALUES " + "(@restaurantname, @description, @location, @contactinfo, @averagestars)";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new SqlCommand(commandString, connection);
            command.Parameters.AddWithValue("@restaurantid", restaurant.RestaurantID);
            command.Parameters.AddWithValue("@restaurantname", restaurant.Name);
            command.Parameters.AddWithValue("@description", restaurant.Description);
            command.Parameters.AddWithValue("@location", restaurant.Location);
            command.Parameters.AddWithValue("@contactinfo", restaurant.ContactInfo);
            command.Parameters.AddWithValue("@averagestars", restaurant.AverageStars);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            return restaurant;
        }

        public List<RestaurantProfile> GetRestaurant(RestaurantProfile rp)
        {
            throw new NotImplementedException();
        }

        public List<RestaurantProfile> SearchRestaurants(string rName)
        {
            throw new NotImplementedException();
        }
    }

}
