using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonDL;
using HappySpoonModels;

namespace HappySpoonDL
{
    internal class SqlRepository : IRepo
    {
        readonly string connectionString;

        public SqlRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<RestaurantProfile> GetRestaurantsConnected()
        {
            string commandString = "SELECT * FROM RestaurantProfiles;";
            using SqlConnection connection = new(connectionString);
            using IDbCommand command = new SqlCommand(commandString, connection);
            connection.Open();
            using IDataReader reader = command.ExecuteReader();
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
                    AverageRating = reader.GetInt32(5)
                    
                });
            }
            return restaurants;
        }
        public List<RestaurantProfile> GetRestaurants()
        {
            string commandString = "SELECT * FROM RestaurantProfiles;";
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
                    AverageRating = (int)row[5]

                });
            }
            return restaurants;
        }

        public List<UserProfile> GetUsersConnected()
        {
            string commandString = "SELECT * FROM UserProfiles;";
            using SqlConnection connection = new(connectionString);
            using IDbCommand command = new SqlCommand(commandString, connection);
            connection.Open();
            using IDataReader reader = command.ExecuteReader();
            var user = new List<UserProfile>();
            while (reader.Read())
            {
                user.Add(new UserProfile
                {
                    UserID = (int)reader[0],
                    UserName = reader.GetString(0),
                    UserPassword = reader.GetString(1),
                    UserEmail = reader.GetString(2)
                });
            }
            return user;
        }
        public List<UserProfile> GetUsers()
        {
            string commandString = "SELECT * FROM UserProfiles;";
            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new SqlCommand(commandString, connection);
            IDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new();
            connection.Open();
            adapter.Fill(dataSet);
            connection.Close();
            var users = new List<UserProfile>();
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                users.Add(new UserProfile
                {
                    UserID= (int)row[0],
                    UserName = (string)row[1],
                    UserPassword = (string)row[2],
                    UserEmail = (string)row[3]
                });
            }
            return users;
        }

        public List<Review> GetReviews()
        {
            string commandString = "SELECT * FROM Reviews";
            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new SqlCommand(@commandString, connection);
            IDataAdapter adapter1 = new SqlDataAdapter(command);
            DataSet dataset = new();
            connection.Open(0);
            adapter1.Fill(dataset);
            connection.Close();
            var review = new List<Review>();
            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                review.Add(new Review
                {
                    UserName = (string)row[0],
                    Name = (string)row[1],
                    Comments = (string)row[2],
                    Rating = (int)row[3]
                });
            }
            return review;
        }

        public Review AddReview(Review review)
        {
            string commandString = "INSERT INTO dbo.Reviews VALUES (@username, @restaurantname, @review, @rating)";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new SqlCommand(commandString, connection);
            command.Parameters.AddWithValue("@username", review.UserName);
            command.Parameters.AddWithValue("@restaurantname", review.Name);
            command.Parameters.AddWithValue("@review", review.Comments);
            command.Parameters.AddWithValue("@rating", review.Rating);
            connection.Open();
            command.ExecuteNonQuery();

            return review;
        }

        public RestaurantProfile AddRestaurant(RestaurantProfile restaurant)
        {
            string commandString = "INSERT INTO dbo.RestaurantProfiles (Name, Description, Location, ContactInfo, AverageRating) VALUES (@restaurantname, @description, @location, @contactinfo, @averagerating)";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new SqlCommand(commandString, connection);
            command.Parameters.AddWithValue("@restaurantname", restaurant.Name);
            command.Parameters.AddWithValue("@description", restaurant.Description);
            command.Parameters.AddWithValue("@location", restaurant.Location);
            command.Parameters.AddWithValue("@contactinfo", restaurant.ContactInfo);
            command.Parameters.AddWithValue("@averagerating", restaurant.AverageRating);
            connection.Open();
            command.ExecuteNonQuery();

            return restaurant;
        }

        public UserProfile AddUser(UserProfile user)
        {
            string commandString = "INSERT INTO dbo.UserProfiles (Username, Password) VALUES (@username, @password)";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new SqlCommand(commandString, connection);
            command.Parameters.AddWithValue("@username", user.UserName);
            command.Parameters.AddWithValue("@password", user.UserPassword);
            connection.Open();
            command.ExecuteNonQuery();

            return user;
        }
    }

}
