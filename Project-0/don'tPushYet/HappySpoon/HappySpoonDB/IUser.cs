using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonModels;

namespace HappySpoonDL
{
    public interface IUser
    {
        UserProfile AddUser(UserProfile user);

        //string SearchUsers(/*string userName, string password*/);
        void SearchUsers();
        bool SearchUsers(char UserName);
        
        List<UserProfile> GetUsers(char UserName, char UserPassword);
        UserProfile GetUsers();
    }

}
