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
        private const string connectionStringFilePath = "C:/Revature/leo-ware/Project-0/don'tPushYet/HappySpoon/HappySpoonDB/Secrets.txt";
        private readonly string connectionString;

        public SqlRepository(string connectionString)
        {
            connectionString = File.ReadAllText(connectionStringFilePath);
        }

        public List<RestaurantProfile> GetRestaurants()
        {
            string commandString = "SELECT * FROM Restaurants;";
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
                    AverageStars = reader.GetInt32(5)
                    
                });
            }
            return restaurants;
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

        public List<Review> GetReviews()
        {
            string commandString = "SELECT * FROM dbo.Review GROUP BY Restaurant;";
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
            return reviews;
        }


        public Review AddReview(Review newReview)
        {
            string commandString = "INSERT INTO dbo.Reviews (Restaurant, UserName, Comments, Stars) VALUES (@username, @restaurant, @comments, @stars)";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new SqlCommand(commandString, connection);
            command.Parameters.AddWithValue("@restaurant", newReview.Restaurant);
            command.Parameters.AddWithValue("@username", newReview.UserName);
            command.Parameters.AddWithValue("@comments", newReview.Comments);
            command.Parameters.AddWithValue("@stars", newReview.Stars);
            connection.Open();
            command.ExecuteNonQuery();

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

            return restaurant;
        }
        /*public List<UserProfile> GetAllUsers()
        {
            string commandString = "SELECT * FROM Users;";
            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new SqlCommand(commandString, connection);
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
        }*/
        /*public List<UserProfile> GetUser()
        {
            string commandString = "SELECT * FROM Users;";
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
                    UserEmail = (string)row[2],
                    UserPassword = (string)row[3]
                });
            }
            return users;
        }*/
       

       /* public UserProfile AddUser(UserProfile user)
        {
            string commandString = "INSERT INTO Users (AccessID, UserId, Username, Email, Password) VALUES " + "(@access, @userid, @username, @useremail, @password);";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new SqlCommand(commandString, connection);
            command.Parameters.AddWithValue("@access", user.UserAccess);
            command.Parameters.AddWithValue("@userid", user.UserID);
            command.Parameters.AddWithValue("@username", user.UserName);
            command.Parameters.AddWithValue("@useremail", user.UserEmail);
            command.Parameters.AddWithValue("@password", user.UserPassword);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            return user;
        }*/
    }

}
