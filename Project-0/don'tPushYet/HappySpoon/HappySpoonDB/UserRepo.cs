using System.IO;
using System;
using HappySpoonModels;


namespace HappySpoonDL
{
    public class UserRepo
    {

        private string userFilePath;
        private string userJsonString;
        public UserRepo AddUser(UserProfile user)
        {
            var users = GetUsers();//GetUser();
            
            /*var userString = jsonSerializer.Serialize<List<UserProfile>>(users, new jsonSerializerOptions { WriteIntended = true });
            File.WriteAllText(filePath + "users.json", userString);*/
            users.Add(user);
            return user;
        }

        List<UserProfile> GetUsers() => jsonString = File.ReadAllText(filePath + "users.json");

        List<UserProfile> SearchUsers()
        {
            try
            {
                userJsonString = File.ReadAllText(userFilePath + "users.json");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (userJsonString.Length > 0)
                return JsonSerializer.Deserialize<List<UserProfile>>(userJsonString);
            else
                return null;
            
        }
    }
}