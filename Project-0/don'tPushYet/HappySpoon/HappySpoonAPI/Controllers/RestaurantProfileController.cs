using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HappySpoonBL;
using HappySpoonDL;
using HappySpoonModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Caching.Memory;

namespace HappySpoonAPI.Controllers
{
    //routes are used to configure endpoints of the API. Can be kept predefined/default or customize it.
    [Route("[controller]")]

    //anything in [] are attributes
    [ApiController]
    public class RestaurantProfileController : ControllerBase
    {
        readonly IRepo repo;
        readonly ILogic logic;
        private IMemoryCache mCache;
        public RestaurantProfileController(IRepo repo, ILogic logic, IMemoryCache mCache)
        {
            this.repo = repo;
            this.logic = logic;
            this.mCache = mCache;
        }

        private static List<RestaurantProfile> rp = new List<RestaurantProfile>();


        //Action Methods are used to access or manipulate resources.
        //They use the HTTP verbs: GET, PUT, POST DELETE, PATCH, HEAD, OPTIONS, TRACE, etc...

        //***********************~ PRACTICE GET METHOD ~***********************

        //***********************~ SEARCH BY NAME ~***********************

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet("Search by Name")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<RestaurantProfile>> Get(string name)
        {
            string rName = name;
            List<RestaurantProfile> restaurants = logic.SearchRestaurants(rName);
            if (restaurants == null)
                return NotFound($"Restaurant {name} is not in the HappySpoon database");
            return Ok(restaurants);
        }

        //*************************~ VIEW ALL RESTAURANTS ~*************************

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("See all restaurants")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<RestaurantProfile>> GetAllRestaurants()
        {

            List<RestaurantProfile> restaurants = repo.GetAllRestaurants();
            return Ok(restaurants);
        }

        //**************************~ ADD A RESTAURANT ~**************************

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rp"></param>
        /// <returns></returns>
        [HttpPost("Add a new restaurant")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<RestaurantProfile> AddRestaurant(RestaurantProfile rp)
        {
           repo.AddRestaurant(rp);

            return CreatedAtAction("Get", rp);
        }

    }
}
