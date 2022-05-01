
namespace HappySpoonModels
{
    public class UserProfile
	{
		public int UserID { get; set; }
		public string UserName { get; set; }
		public string UserEmail { get; set; }
		private int UserPassword { get; set; }


		public UserProfile()
		{

            _ = UserName;
			
			_ = UserEmail;

			_ = UserID;

			_ = UserPassword;
			
		}

		


		public override string ToString() => $"UserID: {UserID}\nUsername: {UserName}\nEmail: {UserEmail} \nPassword: {UserPassword}";

    }

	public class Admin
    {
		public string UserName { get; set; }
		private int UserPassword { get; set; }

		public Admin()
		{
			UserName = "El Jefe";
			UserPassword = 1234;
		}

		public string ToString()
        {
			return $"Welcome back, {UserName}!";
        }
	}

}

