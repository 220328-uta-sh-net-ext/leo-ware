using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using HappySpoonModels;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using HappySpoonBL;

namespace HappySpoonAPI.Repo
{
    public class JWTRepo : IJWTRepo
    {
        private IConfiguration config;
        private ILogic logic;
        public JWTRepo(IConfiguration config, ILogic logic)
        {
            this.config = config;
            this.logic = logic;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Tokens RegAccount(UserProfile user)
        {
            var tokenhand = new JwtSecurityTokenHandler();
            var tKey = Encoding.UTF8.GetBytes(config["JWT:Key"]);

            if (logic.RegAccount(user) == false)
            {
                return null;
            }

            var tokenScribe = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim(ClaimTypes.Name, user.UserName)
                    }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tKey), SecurityAlgorithms.HmacSha256)
            };
            var token = tokenhand.CreateToken(tokenScribe);
            return new Tokens { Validation = tokenhand.WriteToken(token) };

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public Tokens AdminAccount(Admin admin)
        {
            var tokenhand = new JwtSecurityTokenHandler();
            var tKey = Encoding.UTF8.GetBytes(config["JWT:Key"]);

            if (logic.AdminAccount(admin) == false)
            {
                return null;
            }

            var tokenScribe = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim(ClaimTypes.Name, admin.AdminName)
                    }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tKey), SecurityAlgorithms.HmacSha256)
            };
            var token = tokenhand.CreateToken(tokenScribe);
            return new Tokens { Validation = tokenhand.WriteToken(token) };
        }
    }
}
