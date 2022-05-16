using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HappySpoonBL;
using HappySpoonDL;
using HappySpoonModels;


namespace HappySpoonAPI.Controllers
{
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

        //***********************~ SEARCH BY NAME ~***********************

        [HttpGet("Login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<UserProfile>> GetUser(string name, string password)
        {
            string uName = name;
            string uPassword = password;
            List<UserProfile> up = logic.GetUser(uName, uPassword);
            if (up == null)
                return NotFound($"Username and/or password is not in the HappySpoon database\n Would you like to sign up for an account?");
            return Ok(up);
        }

        //*************************~ VIEW ALL RESTAURANTS ~*************************

        [HttpGet("See all users")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<RestaurantProfile>> GetAllRestaurants()
        {

            List<RestaurantProfile> restaurants = repo.GetAllRestaurants();
            return Ok(restaurants);
        }

        //**************************~ ADD A RESTAURANT ~**************************

        [HttpPost("Add a new restaurant")]
        public ActionResult<RestaurantProfile> AddRestaurant(RestaurantProfile rp)
        {
            if (rp.Name == null || rp.Description == null || rp.Location == null)
                return BadRequest("Name, Description and/or Location fields may not be empty. Please enter valid input");
            repo.AddRestaurant(rp);

            return CreatedAtAction("Get", rp);
        }

    }
}
