using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HappySpoonBL;
using HappySpoonDL;
using HappySpoonModels;
using Microsoft.AspNetCore.Authorization;

namespace HappySpoonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        readonly IRepo repo;
        readonly ILogic logic;
        public UserProfileController(IRepo repo, ILogic logic)
        {
            this.repo = repo;
            this.logic = logic;
        }

        private static List<UserProfile> up = new List<UserProfile>();
        private static List<Admin> admin = new List<Admin>();

        //***********************~ USER LOGIN FEATURE ~***********************

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
        
        [HttpGet("See all users")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<UserProfile>> GetAllUsers()
        {
            List<UserProfile> up = repo.GetAllUsers();
            return Ok(up);
        }

        //**************************~ ADD A NEW USER ~**************************

        
        [HttpPost("Signup for a new account")]
        public ActionResult<UserProfile> AddUser(UserProfile User)
        {

            repo.AddUser(User);

            return CreatedAtAction("Get", User);
        }

    }
}
