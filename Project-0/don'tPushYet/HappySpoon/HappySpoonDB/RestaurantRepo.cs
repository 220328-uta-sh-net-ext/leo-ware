﻿using System;
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
            throw new NotImplementedException();
            return GetAllRestaurants();
        }


        public Review AddReview(Review newReview)
        {
            return AddReview(newReview);
        }
    }


}
