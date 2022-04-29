using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonModels;

namespace HappySpoonBL
{
    public interface UserInterface
    {
       UserProfile AddUser(UserProfile user);

       

    }


    interface ISearchUsers
    {
        List<UserProfile> GetUsers();
    }
}
