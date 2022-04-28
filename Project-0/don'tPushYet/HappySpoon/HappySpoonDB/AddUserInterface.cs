using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonModels;

namespace HappySpoonDL
{
    public interface AddUserInterface
    {
        UserProfile AddUser(UserProfile user);



        List<UserProfile> GetUsers();
        

    }
}
