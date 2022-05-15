using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HappySpoonModels;

namespace HappySpoonAPI.Controllers
{
    //routes are used to configure endpoints of the API. Can be kept predefined/default or customize it.
    [Route("api/[controller]")]

    //anything in [] are attributes
    [ApiController]
    public class RestaurantProfileController : ControllerBase
    {

        private static List<RestaurantProfile> _profiles = new List<RestaurantProfile> {
            new RestaurantProfile { Name = "Bob's Burgers", Description = "classic all-american", Location = "Boston", ContactInfo = "438579375998795", AverageStars = 0},
            new RestaurantProfile { Name = "Mrs. Lovette's Meat Pies", Description = "western european cusine that's to die for", Location = "London", ContactInfo = "9374569672396", AverageStars = 0}

            };
        //Action Methods are used to access or manipulate resources.
        //They use the HTTP verbs: GET, PUT, POST DELETE, PATCH, HEAD, OPTIONS, TRACE, etc...
        
        /*[HttpGet]
        public List<RestaurantProfile> Get()
        {
            return _profiles;
        }*/

        [HttpGet]
        public ActionResult<List<RestaurantProfile>> Get()
        {
            return Ok(_profiles);
        }

        /*[HttpGet("name")]
        public List<RestaurantProfile> Get(string name)
        {
            var restaurant = _profiles.Where(x => x.Name.Contains(name)).ToList();
            if (restaurant == null)
                return null;
            return restaurant;
        }*/

        [HttpGet("name")]
        public ActionResult<List<RestaurantProfile>> Get(string name)
        {
            var restaurant = _profiles.Where(x => x.Name.Contains(name)).ToList();
            if (restaurant == null)
                return BadRequest($"Restaurant {name} is not in the Happy Spoon database");
            return Ok(restaurant);
        }
    }
}
