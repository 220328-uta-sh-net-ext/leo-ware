using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonModels;

namespace HappySpoonDL
{
    public interface UserInfoLogicInterface : UserRepo
    {
        UserRepo repository = new UserRepo();

        public void GetUsers()
        {
            repository.GetUsers();
        }

    }
}
