namespace HappySpoonModels
{
    public class UserProfile
	{
		public int UserID { get; set; }
		public string UserName { get; set; }
		private string UserEmail { get; set; }
		private string UserPassword { get; set; }

		private int AdminID { get; set; }
		private string AdminName { get; set; }
		private int AdminPassword { get; set; }


		public UserProfile()
		{

            UserName = "";
			
			UserEmail = "";

			UserID = ++ UserID;

			UserPassword = "";

			AdminID = ++AdminID;
			AdminName = "El Jefe";
			AdminPassword = 1234;

		}

        public override string ToString()
        {
            return $"UserID: {UserID}\nUsername: {UserName}\nEmail: {UserEmail} \nPassword: {UserPassword}";
        }

        public string AdminToString()
        {
			return $"Welcome back, {AdminName}!";
		}

	}

}

