using HappySpoonDL;
using HappySpoonModels;

namespace HappySpoonBL
{
    public class UserInfoLogic : UserInterface
    {
        UserInterface repo = new SqlRepo();
        public UserProfile AddUser(UserProfile user)
        {

            Random ID = new Random();

            user.userID = ID.Next(1, 200);

            //Validation of new user information
            //What are the constraints???
            var users = repo.GetUsers();
            //foreach (var user in users)
            //{ }
            //or
            //if statement?
            return repo.AddUser(user);
            
        }

        static string userName { get; set; }
        static string userEmail { get; set; }

        private string userPassword { get; set; }


        public List<UserProfile> GetUsers { get; }
        


    }




}