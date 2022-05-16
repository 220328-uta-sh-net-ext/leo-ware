﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HappySpoonBL;
using HappySpoonDL;
using HappySpoonModels;

namespace HappySpoonAPI.Controllers
{
    //routes are used to configure endpoints of the API. Can be kept predefined/default or customize it.
    [Route("api/[controller]")]

    //anything in [] are attributes
    [ApiController]
    public class RestaurantProfileController : ControllerBase
    {
        readonly IRepo repo;
        public RestaurantProfileController(IRepo repo)
        {
            this.repo = repo;
        }

        private static List<RestaurantProfile> _profiles = new List<RestaurantProfile>();
        
        /*{
            new RestaurantProfile { Name = "Bob's Burgers", Description = "classic all-american", Location = "Boston", ContactInfo = "438579375998795", AverageStars = 0},
            new RestaurantProfile { Name = "Mrs. Lovette's Meat Pies", Description = "western european cusine that's to die for", Location = "London", ContactInfo = "9374569672396", AverageStars = 0}

        };*/
        
        //Action Methods are used to access or manipulate resources.
        //They use the HTTP verbs: GET, PUT, POST DELETE, PATCH, HEAD, OPTIONS, TRACE, etc...
        
        /*[HttpGet]
        public List<RestaurantProfile> Get()
        {
            return _profiles;
        }*/

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<List<RestaurantProfile>> Get(string name)
        {
            var restaurant = _profiles.Where(x => x.Name.Contains(name)).ToList();
            if (restaurant == null)
                return BadRequest($"Restaurant {name} is not in the HappySpoon database");
            return Ok(restaurant);
        }

        [HttpGet("restaurants")]
        public ActionResult<List<RestaurantProfile>> GetAllRestaurants()
        {

            List<RestaurantProfile> restaurants = repo.GetAllRestaurants();
            //if (resturaunts == null)
                //return NotFound("There are no existing restaurants in the HappySpoon database");
            return Ok(restaurants);
        }


    }
}