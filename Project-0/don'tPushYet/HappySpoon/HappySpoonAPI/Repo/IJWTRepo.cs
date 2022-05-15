using HappySpoonModels;
namespace HappySpoonAPI.Repo
{
    public interface IJWTRepo
    {
        Token Authenticate(UserProfile User);
    }
}
