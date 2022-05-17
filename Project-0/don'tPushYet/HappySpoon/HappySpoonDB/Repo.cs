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

    public class Repo : IRepo
    {
        public Repo(string connectionString)
        {
            this.connectionString = File.ReadAllText(connectionStringFilePath);
        }
        private const string connectionStringFilePath = "C:/Revature/leo-ware/Project-0/don'tPushYet/HappySpoon/HappySpoonDB/Secrets.txt";
        readonly string connectionString;
        readonly List<RestaurantProfile> rp = new List<RestaurantProfile>();

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

        //**************************************************************

        public List<RestaurantProfile> GetAllRestaurants()
        {
            string commandString = "SELECT * FROM Restaurants;";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            IDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new();
            try
            {
                connection.Open();
                adapter.Fill(dataSet); // this sends the query. DataAdapter uses a DataReader to read.}
            }
            catch (SqlException ex)
            {
                throw;//rethrow the exception
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            // TODO: 
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

        //**************************************************

        /// <summary>
        /// Method to add a new review
        /// </summary>
        /// <param name="newReview"></param>
        /// <returns> A new review in the form of comments and stars </returns>
        public Review AddReview(Review newReview)
        {
            string commandString = "INSERT INTO Reviews (Restaurant, Username, Stars, Comments) VALUES " + "(@restaurant, @username, @stars, @comments)";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new SqlCommand(commandString, connection);
            command.Parameters.AddWithValue("@restaurant", newReview.Restaurant);
            command.Parameters.AddWithValue("@username", newReview.UserName);
            command.Parameters.AddWithValue("@stars", newReview.Stars);
            command.Parameters.AddWithValue("@comments", newReview.Comments);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            return newReview;
        }


        public List<Review> GetReviews()
        {
            string commandString = "SELECT * FROM Reviews;";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            IDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new();
            try
            {
                connection.Open();
                adapter.Fill(dataSet); // this sends the query. DataAdapter uses a DataReader to read.}
            }
            catch (SqlException ex)
            {
                throw;//rethrow the exception
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            var reviews = new List<Review>();
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                reviews.Add(new Review
                {
                    Restaurant = (string)row[0],
                    UserName = (string)row[1],
                    Stars = (int)row[2],
                    Comments = (string)row[3]
                });
            }
            return reviews;

        }


        //*************************************~ USER ~*************************************

        /// <summary>
        /// Method to add new users to the UserProfile collection
        /// </summary>
        /// <param name="User"></param>
        /// <returns> a new row to Users database</returns>
        public UserProfile AddUser(UserProfile User)
        {
            string commandString = "INSERT INTO Users (AccessID, UserId, Username, Email, Password) VALUES " + "(@access, @userid, @username, @useremail, @password);";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new SqlCommand(commandString, connection);
            command.Parameters.AddWithValue("@access", User.UserAccess);
            command.Parameters.AddWithValue("@userid", User.UserID);
            command.Parameters.AddWithValue("@username", User.UserName);
            command.Parameters.AddWithValue("@useremail", User.UserEmail);
            command.Parameters.AddWithValue("@password", User.UserPassword);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            return User;

        }
        /// <summary>
        /// Displays aaaall of the users
        /// </summary>
        /// <params> </params>
        /// <returns>Gets all existing users from the database</returns>
        public List<UserProfile> GetUser()
        {
            string commandString = "SELECT * FROM Users;";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            IDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new();
            try
            {
                connection.Open();
                adapter.Fill(dataSet); // this sends the query. DataAdapter uses a DataReader to read.}
            }
            catch (SqlException ex)
            {
                throw;//rethrow the exception
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            var users = new List<UserProfile>();
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                users.Add(new UserProfile
                {
                    UserAccess = (string)row[0],
                    UserID = (int)row[1],
                    UserName = (string)row[2],
                    UserEmail = (string)row[3],
                    UserPassword = (string)row[4]
                });
            }
            return users;

        }

        public List<Admin> GetAdmin()
        {
            string commandString = "SELECT * FROM Users;";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            IDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new();
            try
            {
                connection.Open();
                adapter.Fill(dataSet); // this sends the query. DataAdapter uses a DataReader to read.}
            }
            catch (SqlException ex)
            {
                throw;//rethrow the exception
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            var admin = new List<Admin>();
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                admin.Add(new Admin
                {
                    AdminAccess = (string)row[0],
                    AdminID = (int)row[1],
                    AdminName = (string)row[2],
                    AdminPassword = (string)row[4]
                });
            }
            return admin;

        }

    }

}