namespace HappySpoonModels
{
	public class UserProfile
	{
		public int UserID { get; set; }
		public string UserName { get; set; }
		public string UserEmail { get; set; }
		public string UserPassword { get; set; }
		public string UserAccess { get; set; }

		
		public UserProfile()
		{
			UserAccess = "B";
			UserName = "";
			UserEmail = "";
			UserID = ++UserID;
			UserPassword = "";

		}

		

		

		public override string ToString()
		{
			return $"UserID: {UserID}\nUsername: {UserName}\nEmail: {UserEmail} \nPassword: {UserPassword}";
		}


	}
	



}

	





