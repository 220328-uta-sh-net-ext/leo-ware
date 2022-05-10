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
        public RestaurantProfile AddRestaurant(RestaurantProfile restaurant)
        {
            string commandString = "INSERT INTO Restaurants (RestaurantId, Name, Description, Location, ContactInfo, AverageStars) VALUES " + "(@restaurantid, @restaurantname, @description, @location, @contactinfo, @averagestars)";

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
        public List<RestaurantProfile> SearchRestaurants()
        {
            throw new NotImplementedException();
            return GetAllRestaurants();
        }

        public List<RestaurantProfile> GetAllRestaurants()
        {
            string commandString = "SELECT * FROM Restaurants;";
            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new SqlCommand(commandString, connection);
            IDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new();
            connection.Open();
            adapter.Fill(dataSet);
            connection.Close();
            var restaurants = new List<RestaurantProfile>();
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                restaurants.Add(new RestaurantProfile
                {
                    RestaurantID = (int)row[0],
                    Name = (string)row[1],
                    Description = (string)row[2],
                    Location = (string)row[3],
                    ContactInfo = (string)row[4],
                    AverageStars = (int)row[5]

                });
            }
            return restaurants;
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