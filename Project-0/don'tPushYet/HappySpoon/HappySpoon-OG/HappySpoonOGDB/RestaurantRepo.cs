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
        readonly List<RestaurantProfile> restaurants = new List<RestaurantProfile>();
        private string connectionString;

        public RestaurantRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }
        /// <summary>
        /// Method to add a new restaurant
        /// </summary>
        /// <param name="restaurant"></param>
        /// <returns> Returns a new Restaurant Profile into the Restaurants database </returns>
        public RestaurantProfile AddRestaurant(RestaurantProfile restaurants)
        {
            string commandString = "INSERT INTO Restaurants (RestaurantId, Name, Description, Location, ContactInfo, AverageStars) VALUES " + "(@restaurantid, @restaurantname, @description, @location, @contactinfo, @averagestars)";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new SqlCommand(commandString, connection);
            command.Parameters.AddWithValue("@restaurantid", restaurants.RestaurantID);
            command.Parameters.AddWithValue("@restaurantname", restaurants.Name);
            command.Parameters.AddWithValue("@description", restaurants.Description);
            command.Parameters.AddWithValue("@location", restaurants.Location);
            command.Parameters.AddWithValue("@contactinfo", restaurants.ContactInfo);
            command.Parameters.AddWithValue("@averagestars", restaurants.AverageStars);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            return restaurants;
        }
        public List<RestaurantProfile> SearchRestaurants(RestaurantProfile restaurants)
        {
            return GetAllRestaurants();
        }

        public List<RestaurantProfile> GetAllRestaurants()
        {
            string commandString = "SELECT * FROM Restaurants;";
            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new SqlCommand(commandString, connection);
            using SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new();
            connection.Open();
            adapter.Fill(dataSet);
            connection.Close();
            var restaurant = new List<RestaurantProfile>();
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                restaurant.Add(new RestaurantProfile
                {
                    RestaurantID = (int)row[0],
                    Name = (string)row[1],
                    Description = (string)row[2],
                    Location = (string)row[3],
                    ContactInfo = (string)row[4],
                    AverageStars = (int)row[5]
                    /*RestaurantID = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Description = reader.GetString(2),
                    Location = reader.GetString(3),
                    ContactInfo = reader.GetString(4),
                    AverageStars = reader.GetInt32(5)*/

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
    }


}
//C:\Revature\leo-ware\Project-0\don'tPushYet\HappySpoon\HappySpoon.sln