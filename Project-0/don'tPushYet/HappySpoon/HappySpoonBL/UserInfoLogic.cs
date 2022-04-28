using System;
using HappySpoonDL;
using HappySpoonModels;

namespace HappySpoonBL
{
    public class UserInfoLogic
    {
        AddUserInterface repo = new UserRepo();
        public UserProfile AddUser(UserProfile user)
        {
            user.userName
            var users = repo.GetUser();
            return repo.AddUser(user);
        }
        private List<UserRepo> GetUser()
        {
            var users = repo.GetUser();
            if (users == null)
            {
                throw new Exception("Please enter a username to continue.");
            }
                
        }
    }
}