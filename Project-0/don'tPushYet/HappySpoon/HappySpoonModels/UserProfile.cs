
namespace HappySpoonModels
{
    public class UserProfile
	{
		public int UserID { get; set; }
		public char UserName { get; set; }
		public char UserEmail { get; set; }
		public char UserPassword { get; set; }


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
		private string UserName { get; set; }
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

