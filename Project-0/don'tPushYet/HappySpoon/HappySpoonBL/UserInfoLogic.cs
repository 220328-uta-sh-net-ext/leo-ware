using HappySpoonDL;
using HappySpoonModels;

namespace HappySpoonBL
{
    public class UserInfoLogic : UserInterface
    {
        readonly UserInterface repo;

        public UserInfoLogic(UserInterface repo)
        {
            this.repo = repo;
        }
        public UserProfile AddUser(UserProfile user)
        {
            var random = new Random();

            user.UserID = random.Next(0, 200);

            return repo.AddUser(user);

            //return repo.AddUser(user);
        }

    }

}