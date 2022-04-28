using System.IO;
using System;
using HappySpoonModels;


namespace HappySpoonDL
{
    public class UserRepo
    {

        private string filePath = "../HappySpoonDL/Database";
        private string jsonString;
        public UserProfile AddUser(UserProfile user)
        {
            var users = GetUser();
            users.Add(user);
            var userString = jsonSerializer.Serialize<List<UserProfile>>(users, new jsonSerializerOptions { WriteIntended = true });
            File.WriteAllText(filePath + "Pokemon.json", userString);
        }


        

        private List<UserProfile> GetUser()
        {
            jsonString = File.ReadAllText(filePath + "users.json");
        }
    }
}