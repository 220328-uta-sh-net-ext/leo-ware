using HappySpoonModels;
namespace HappySpoonAPI.Repo
{
    public interface IJWTRepo
    {
        Tokens RegAccount(UserProfile user);
        Tokens AdminAccount(Admin admin);
    }
}
