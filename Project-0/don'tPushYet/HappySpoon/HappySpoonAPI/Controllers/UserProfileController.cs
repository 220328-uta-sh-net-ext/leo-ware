using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HappySpoonBL;
using HappySpoonDL;
using HappySpoonModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Caching.Memory;

namespace HappySpoonAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        readonly IRepo repo;
        readonly ILogic logic;
        private IMemoryCache mCache;
        public UserProfileController(IRepo repo, ILogic logic, IMemoryCache mCache)
        {
            this.repo = repo;
            this.logic = logic;
            this.mCache = mCache;
        }

        private static List<UserProfile> up = new List<UserProfile>();
        private static List<Admin> admin = new List<Admin>();

        //***********************~ USER LOGIN FEATURE ~***********************

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpGet("Login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<UserProfile>> GetUser(string name, string password)
        {
            string uName = name;
            string uPassword = password;
            List<UserProfile> up = logic.GetUser(uName, uPassword);
            foreach (UserProfile upItem in up)
            {
                if (upItem.UserName == uName && upItem.UserPassword == uPassword)
                    continue;
                
                if (up == null)
                    return NotFound($"Username and/or password is not in the HappySpoon database\n Would you like to sign up for an account?");
            }    
            
            return Ok(up);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpGet("Admin Login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<Admin>> GetAdmin(string name, string password)
        {
            List<Admin> up = logic.GetAdmin();
            foreach (var upItem in up)
            {
                if (upItem.AdminName == name && upItem.AdminPassword == password)
                    continue;
                if (up == null)
                    return NotFound($"Username and/or password is not in the HappySpoon database\n Would you like to sign up for an account?");
            }

            return Ok(up);
        }

        //*************************~ SEARCH USERS ~*************************

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        /// 
        [HttpGet("Search users by username")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<List<UserProfile>> SearchUsers(string username)
        {
            string uName = username;
            List<UserProfile> up = logic.SearchUsers(uName);
            if (up == null)
                return BadRequest($"Restaurant {username} is not in the HappySpoon database");
            return Ok(up);
        }

        //*************************~ VIEW ALL USERS ~*************************

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Authorize(Roles = "admin")]
        [HttpGet("See all users")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<UserProfile>> GetAllUsers()
        {
            List<UserProfile> up = repo.GetAllUsers();
            return Ok(up);
        }

        //**************************~ ADD A NEW USER ~**************************

        /// <summary>
        /// 
        /// </summary>
        /// <param name="User"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("Signup for a new account")]
        public ActionResult<UserProfile> AddUser(UserProfile User)
        {

            repo.AddUser(User);

            return CreatedAtAction("Get", User);
        }

    }
}
