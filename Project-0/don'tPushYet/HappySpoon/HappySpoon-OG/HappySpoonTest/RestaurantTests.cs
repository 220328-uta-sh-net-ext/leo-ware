using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonBL;
using HappySpoonDL;
using HappySpoonModels;


namespace HappySpoonTest
{
    public class RestaurantTests
    {
        private readonly IRestaurant repo;
        private readonly IRestaurantLogic logic;
       

        //[Fact]

        public void AddRestaurantTest()
        {
            RestaurantProfile rp = new RestaurantProfile
            {
                RestaurantID = 5,
                Name = "Denys",
                Description = "24 Hour diner",
                Location = "Savannah",
                ContactInfo = "2224563875",
                AverageStars = 4
            };

            /*Assert.Equal(5, rp.RestaurantID);
            Assert.Equal("Denys", rp.Name);
            Assert.Equal("24 Hour diner", rp.Description);
            Assert.Equal("Savannah", rp.Location);
            Assert.Equal("2224563875", rp.ContactInfo);
            Assert.Equal(4, rp.AverageStars);*/


        }


        //[Theory]
        public void SearchRestaurantsTest()
        {
            List<RestaurantProfile> restaurant = new List<RestaurantProfile>()
            {
                // var rp = Name.Where(s => s.Contains("Bobs Burgers"))
            };
        }


        //[Fact]
        public void AddRestaurant()
        {
            RestaurantProfile rp = new RestaurantProfile
            {
                RestaurantID = 3,
                Name = "Spondivits",
                Description = "Buscuits and seafood. Just how grandma made it!",
                Location = "Atlanta",
                ContactInfo = "4049123791",
                AverageStars = 5
            };
           /* Assert.Equal(1, rp.RestaurantID);
            Assert.Equal("Spondivits", rp.Name);
            Assert.Equal("Buscuits and seafood. Just how grandma made it!", rp.Description);
            Assert.Equal("Atlanta", rp.Location);
            Assert.Equal("4049123791", rp.ContactInfo);
            Assert.Equal(5, rp.AverageStars);*/
        }

        //[Fact]
        public void AddReviewTest()
        {
            Review r = new Review
            {
                Comments = "I hated it. Ew.",
                Stars = 1
            };

           /* Assert.Equal("I hated it. Ew.", r.Comments);
            Assert.Equal(1, r.Stars);*/
        }

    }
}
