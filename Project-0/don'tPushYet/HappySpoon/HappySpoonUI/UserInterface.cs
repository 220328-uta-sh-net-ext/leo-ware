using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonDL;

namespace HappySpoonUI
{
    public interface UserInterface
    {
        public interface UserInterface
        {
            UserRepo AddUser(string username, string useremail, string password);


            List<UserRepo> GetUsers();

        }
    }
}
