using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HappySpoonBL;
using HappySpoonDL;
using HappySpoonModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Caching.Memory;
using HappySpoonAPI.Repo;

namespace HappySpoonAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        readonly IRepo repo;
        readonly ILogic logic;
        private IMemoryCache mCache;
        private IJWTRepo jRepo;
        public UserProfileController(IRepo repo, ILogic logic, IMemoryCache mCache, IJWTRepo jRepo)
        {
            this.repo = repo;
            this.logic = logic;
            this.mCache = mCache;
            this.jRepo = jRepo;
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
        public ActionResult<UserProfile> GetUser(string name, string password)
        {
            string uName = name;
            string uPassword = password;
            var up = logic.GetUser(uName, uPassword);
            foreach (UserProfile upItem in up)
            {
                if (upItem.UserName == uName && upItem.UserPassword == uPassword)
                {
                    
                    return Ok(upItem);
                }

            }
            return NotFound($"Username and/or password is not in the HappySpoon database\n Would you like to sign up for an account?");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpGet("Admin Login")]
        //[Route("Get Admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult <UserProfile> GetAdmin(string name, string password)
        {
            var up = logic.GetAdmin();
            foreach (var upItem in up)
            {
                if (upItem.AdminName == name && upItem.AdminPassword == password)
                    return Ok(upItem);
            }
            return NotFound($"Username and/or password is not in the HappySpoon database\n Would you like to sign up for an account?");
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
            foreach (UserProfile upItem in up)
            {

                    return Ok(upItem);

            }
         return BadRequest($"Restaurant {username} is not in the HappySpoon database");
           
        }

        //*************************~ VIEW ALL USERS ~*************************

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>

        [HttpGet("See all users")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<UserProfile>> GetAllUsers()
        {
            List<UserProfile> up = repo.GetUser();
            return Ok(up);
        }

        //**************************~ ADD A NEW USER ~**************************

        /// <summary>
        /// Adding a new user to the database
        /// </summary>
        /// <param name="User"></param>
        /// <returns></returns>
        [HttpPost("Signup to add a new account")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult <UserProfile> AddUser(UserProfile user)
        {
            logic.AddUser(user);

            return CreatedAtAction("Get", user);
        }

    }
}
