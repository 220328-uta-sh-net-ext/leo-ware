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
        void User();

        void AddUser();

        List<UserProfile> GetUser();


     }
    
}
