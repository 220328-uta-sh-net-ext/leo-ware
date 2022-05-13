using System;
using System.IO;
using System.Data;
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
        readonly List<RestaurantProfile> rp = new List<RestaurantProfile>();

        private string connectionString;

        public RestaurantRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }
        /// <summary>
        /// Method to add a new restaurant
        /// </summary>
        /// <param name="rp"></param>
        /// <returns> Returns a new Restaurant Profile into the Restaurants database </returns>
        public RestaurantProfile AddRestaurant(RestaurantProfile rp)
        {
            string commandString = "INSERT INTO Restaurants (RestaurantId, Name, Description, Location, ContactInfo, AverageStars) VALUES " + "(@restaurantid, @restaurantname, @description, @location, @contactinfo, @averagestars)";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new SqlCommand(commandString, connection);
            command.Parameters.AddWithValue("@restaurantid", rp.RestaurantID);
            command.Parameters.AddWithValue("@restaurantname", rp.Name);
            command.Parameters.AddWithValue("@description", rp.Description);
            command.Parameters.AddWithValue("@location", rp.Location);
            command.Parameters.AddWithValue("@contactinfo", rp.ContactInfo);
            command.Parameters.AddWithValue("@averagestars", rp.AverageStars);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            return rp;
        }
        public List<RestaurantProfile> SearchRestaurants(string rName)
        {
            var retsaurants = GetAllRestaurants();
            var filterRP = from restaurant in retsaurants
                           where restaurant.Name.ToLower().Contains(rName.ToLower())
                           select restaurant;
            return filterRP.ToList();
        }

        public List<RestaurantProfile> GetAllRestaurants()
        {
            string commandString = "SELECT * FROM Restaurants;";
            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new SqlCommand(commandString, connection);
            using SqlDataReader reader = command.ExecuteReader();
            connection.Open();
            
            var restaurant = new List<RestaurantProfile>();
            while (reader.Read())
            {
                restaurant.Add(new RestaurantProfile
                {
                    RestaurantID = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Description = reader.GetString(2),
                    Location = reader.GetString(3),
                    ContactInfo = reader.GetString(4),
                    AverageStars = reader.GetDouble(5)

                });
            }
            return restaurant;
        }

        /// <summary>
        /// Method to add a new review
        /// </summary>
        /// <param name="newReview"></param>
        /// <returns> A new review in the form of comments and stars </returns>
        public Review AddReview(Review newReview)
        {
            return AddReview(newReview);
        }

        public List<RestaurantProfile> GetRestaurant(RestaurantProfile rp)
        {
            return GetRestaurant(rp);
        }
    }


}
//C:\Revature\leo-ware\Project-0\don'tPushYet\HappySpoon\HappySpoon.sln