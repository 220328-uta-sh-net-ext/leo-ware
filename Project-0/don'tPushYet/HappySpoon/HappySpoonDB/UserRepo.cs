using System;
using System.Collections.Generic;
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
            return User;

        }

        public List<UserProfile> GetAllUsers()
        {
            return new List<UserProfile>();
        }

        public List<UserProfile> GetUser()
        {
            return new List<UserProfile>();
        }
    }
}
