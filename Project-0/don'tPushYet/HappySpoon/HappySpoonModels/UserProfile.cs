namespace HappySpoonModels
{
	public class UserProfile
	{
		public string userName { get; set; }
		public string userEmail { get; set; }

		private string UserPassword;
		/*public string Password
		{
			int minLength = 9;
			string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXWZ";
			string lowercase = "abcdefghijklmnopqrstuvwxyz";
			string digits = "1,2,3,4,5,6,7,8,9,10";
			string specialChars = "~!@#$%^&*()-_`";
			userPassword = Console.ReadLine();

		get
            {
				return Password;
            }
			set
            {
				switch ()
				{
					case userPassword.Contains(speacialChars):
					case userPassword.Contains(uppercase):
					case userPassword.Contains(digits):
					case userPassword.Length >= minLength:
					case userPassword.Contains(lowercase):
						Console.WriteLine("Your password is EXTREMELY strong!");
						Password = userPassword;
						break;
					case userPassword.Contains(uppercase):
					case userPassword.Contains(digits):
					case userPassword.Length >= minLength:
					case userPassword.Contains(lowercase):
						Password = userPassword;
						Console.WriteLine("Congrats! Your password is strong.");
						break;
					case userPassword.Contains(speacialChars):
					case userPassword.Contains(digits):
					case userPassword.Length >= minLength:
					case userPassword.Contains(lowercase):
						Console.WriteLine("Congrats! Your password is strong.");
						Password = userPassword;
						break;
					case userPassword.Contains(digits):
					case userPassword.Length >= minLength:
					case userPassword.Contains(lowercase):
						throw new Exception("Your password is medium. You should choose a different password.");
						break;
					case userPassword.Length >= minLength:
					case userPassword.Contains(lowercase):
						throw new Exception("Your password is weak. You should definitely choose a different password.");
						break;
					default:
						throw new Exception("Your password is in valid. Hackers would have a field day.");
						break;
							}
					
            }
		}*/
		public UserProfile()
        {
			userName = "?";
			userEmail = "?";
			UserPassword = "?";
        }

        public override string ToString()
        {
			
            return $"Username: {userName}\nEmail: {userEmail}\nPassword {UserPassword}";

		}

    }
}