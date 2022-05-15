using Microsoft.IdentityModel.Tokens;
using HappySpoonModels;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace HappySpoonAPI.Repo
{
    public class JWTRepo : IJWTRepo
    {
        private IConfiguration config;
        public JWTRepo(IConfiguration config)
        {
            this.config = config;
        }

        public Token Authenticate(UserProfile User)
        {
            if (!UserProfile.Equals(a => a.Key == User.UserName && a.Value == User.UserPassword))
            {
                return null;
            }

            var tokenhand = new JwtSecurityTokenHandler();
            var tKey = Encoding.UTF8.GetBytes(config["JWT:Key"]);

            var tokenScribe = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim(ClaimTypes.Name, User.UserName)
                    }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tKey), SecurityAlgorithms.HmacSha256)
            };
        }
    }
}
