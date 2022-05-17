using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HappySpoonBL;
using HappySpoonDL;
using HappySpoonModels;
using Microsoft.AspNetCore.Authorization;

namespace HappySpoonAPI.Controllers
{
    //routes are used to configure endpoints of the API. Can be kept predefined/default or customize it.
    [Route("api/[controller]")]

    //anything in [] are attributes
    [ApiController]
    public class RestaurantProfileController : ControllerBase
    {
        readonly IRepo repo;
        readonly ILogic logic;
        public RestaurantProfileController(IRepo repo, ILogic logic)
        {
            this.repo = repo;
            this.logic = logic;
        }

        private static List<RestaurantProfile> rp = new List<RestaurantProfile>();


        //Action Methods are used to access or manipulate resources.
        //They use the HTTP verbs: GET, PUT, POST DELETE, PATCH, HEAD, OPTIONS, TRACE, etc...

//***********************~ PRACTICE GET METHOD ~***********************

        
        

        //***********************~ SEARCH BY NAME ~***********************

        
        [HttpGet("Search by Name")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<List<RestaurantProfile>> Get(string name)
        {
            string rName = name;
            List<RestaurantProfile> restaurants = logic.SearchRestaurants(rName);
            if (restaurants == null)
                return BadRequest($"Restaurant {name} is not in the HappySpoon database");
            return Ok(restaurants);
        }

        //*************************~ VIEW ALL RESTAURANTS ~*************************

        
        [HttpGet("See all restaurants")]
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
           repo.AddRestaurant(rp);

            return CreatedAtAction("Get", rp);
        }

    }
}
