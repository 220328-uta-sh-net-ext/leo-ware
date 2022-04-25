using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappySpoonDL
{
    public interface UserInterface
    {
        User AddUser(string username, string useremail, string password);


        List<User> GetUsers();

    }
}
