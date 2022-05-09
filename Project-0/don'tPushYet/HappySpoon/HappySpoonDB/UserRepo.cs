using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonDL;
using HappySpoonModels;

namespace HappySpoonDL
{
    public class UserRepo : IUser
    {
        readonly string connectionString;
        public UserRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }


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

        public List<UserProfile> GetAllUsers()
        {
            string commandString = "SELECT * FROM Users;";
            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new SqlCommand(commandString, connection);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();
            var user = new List<UserProfile>();
            while (reader.Read())
            {
                user.Add(new UserProfile
                {
                    UserAccess = reader.GetString(0),
                    UserID = reader.GetInt32(1),
                    UserName = reader.GetString(2),
                    UserEmail = reader.GetString(3),
                    UserPassword = reader.GetString(4)
                });
            }
            return user;
        }

        public List<UserProfile> GetUser()
        {
            throw new NotImplementedException();
        }

        /*public List<UserProfile> GetUser()
        {
            string commandString = "SELECT * FROM Users;";
            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new SqlCommand(commandString, connection);
            //IDataAdapter adapter = new SqlDataAdapter(command);
            //DataSet dataSet = new();
            connection.Open();
            adapter.Fill(dataSet);
            connection.Close();
            var users = new List<UserProfile>();
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                users.Add(new UserProfile
                {
                    UserID = (int)row[0],
                    UserName = (string)row[1],
                    UserEmail = (string)row[2],
                    UserPassword = (string)row[3]
                });
            }
            return users;
        }*/
    }
}
