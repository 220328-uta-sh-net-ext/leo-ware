using System.IO;
using System;
using HappySpoonModels;


namespace HappySpoonDL
{
    public class UserRepo
    {

        /*private*/ string filePath = "../HappySpoonDL/Database";
        /*private*/ string jsonString;
        public UserProfile AddUser()
        {
            var users = GetUser();
            users.AddUser();
            var userString = jsonSerializer.Serialize<List<UserProfile>>(users, new jsonSerializerOptions { WriteIntended = true });
            File.WriteAllText(filePath + "Pokemon.json", userString);
        }



        public static List<UserProfile> GetUser() => jsonString = File.ReadAllText(filePath + "users.json");
    }
}