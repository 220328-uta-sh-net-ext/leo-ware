
namespace HappySpoonModels
{
    public class UserProfile
	{
		public string UserID;
		public string UserName;
		public string UserEmail;
		public string UserPassword;


		public UserProfile()
		{

            UserName = "";
			
			UserEmail = "";

			UserID = "";

			UserPassword = "";
			
		}

		public string AddUser
        {
			//return UserID + " " + UserName + " " + UserEmail;
			get
            {
				return UserID + UserName + UserEmail + UserPassword;
            }
            set
            {
				UserID = value;
				UserName = value;
				UserEmail = value;
				UserPassword = value;
            }
        }


		public override string ToString() => $"UserID: {UserID}\nUsername: {UserName}\nEmail: {UserEmail} \nPassword: {UserPassword}";

    }

	internal class Admin
    {
		private int UserID;
		private string UserName;
		private int UserPassword;

		private Admin()
		{
			UserID = 1;
			UserName = "El Jefe";
			UserPassword = 1234;
		}

		private string AdminUser()
        {
			return $"Welcome back, {UserName}!";

        }
	}

}

