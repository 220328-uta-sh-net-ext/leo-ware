using System;
using HappySpoonDL;

namespace HappySpoonBL
{
    public class UserInfoLogic
    {
        UserRepo repository = new UserRepo();

        public void GetAllUsers()
        {
            repository.GetAllUsers();
        }
    }
}