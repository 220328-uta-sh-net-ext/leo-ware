namespace HappySpoonModels
{
    public class UserProfile
	{
		public int UserID { get; set; }
		public string UserName { get; set; }
		public string UserEmail { get; set; }
		public string UserPassword { get; set; }


		public UserProfile()
		{

            UserName = "";
			
			UserEmail = "";

			UserID = UserID++;

			UserPassword = "";
			
		}

		public override string ToString() => $"UserID: {UserID}\nUsername: {UserName}\nEmail: {UserEmail} \nPassword: {UserPassword}";

    }

	internal class Admin
    {
		private int UserID { get; set; }
		private string UserName { get; set; }
		private int UserPassword { get; set; }

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

