using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonDL;
using HappySpoonModels;

namespace HappySpoonUI
{
    public interface UserInterface
    {
        UserProfile User();

        List<UserProfile> GetUser();

    }
}
