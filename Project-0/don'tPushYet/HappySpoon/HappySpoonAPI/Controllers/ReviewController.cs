using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HappySpoonDL;
using HappySpoonBL;
using HappySpoonModels;

namespace HappySpoonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        readonly IRepo repo;
        readonly ILogic logic;
        public ReviewController(IRepo repo, ILogic logic)
        {
            this.repo = repo;
            this.logic = logic;
        }

        private static List<Review> rv = new List<Review>();


        //Action Methods are used to access or manipulate resources.
        //They use the HTTP verbs: GET, PUT, POST DELETE, PATCH, HEAD, OPTIONS, TRACE, etc...

        //***********************~ SEARCH BY NAME ~***********************

        /*[HttpGet("Search reviews by restaurant name")]
        public List<Review> SearchReviews(string Name)
        {
            string rName = Name;
            List<Review>? rv = logic.SearchReviews(rName);
            
            if (rv == null)
                throw new InvalidDataException("There are no restaurants by that name");
                return Ok(rv);
        }*/

        //*************************~ VIEW ALL REVIEWS ~*************************


        [HttpGet("See all reviews")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<Review>> GetReviews()
        {
            List<Review> restaurants = repo.GetReviews();
            return Ok(restaurants);
        }

        //**************************~ ADD A REVIEW ~**************************


        [HttpPost("Add a new restaurant")]
        public ActionResult<Review> AddReview(Review newReview)
        {
            repo.AddReview(newReview);

            return CreatedAtAction("Get", newReview);
        }
    }
}
