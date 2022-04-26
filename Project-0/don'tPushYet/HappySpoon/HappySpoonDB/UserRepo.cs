using System.IO;
using System;
using HappySpoonModels;


namespace HappySpoonDL
{
    public class UserRepo : UserInfoLogicInterface
    {

        private string filePath = "../PokemonDL/Database";
        private string jsonString;
        public UserProfile AddUser(UserProfile user)
        {
            throw new System.NotImplementedException();
        }


        public void GetUsers()
        {
            jsonString = File.ReadAllText(filePath + "users.json");
        }

        List<UserProfile> UserInfoLogicInterface.GetUsers()
        {
            throw new System.NotImplementedException();
        }
    }
}