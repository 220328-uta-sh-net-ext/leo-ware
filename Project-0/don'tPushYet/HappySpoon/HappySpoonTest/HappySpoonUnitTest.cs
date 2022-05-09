using HappySpoonModels;
using HappySpoonUI;
using System.Collections.Generic;
using Xunit;

namespace HappySpoonTest
{
    public class HappySpoonUnitTest
    {
        [Fact]
        public void LoginTest()
        {
            UserProfile User = new UserProfile
            {
                UserName = "flubber",
                UserPassword = "flubbersgonnaflub"
            };

            Assert.Equal("flubber", User.UserName);
            Assert.Equal("flubbersgonnaflub", User.UserPassword);
        }

        [Fact]

        public void AddRestaurantTest()
        {
            
        }

        [Fact]
        public void SearchRestaurantsTest()
        {
            RestaurantProfile restaurant = new RestaurantProfile
            {
                Name = "Bob's Burgers"
            };

            Assert.Equal("Bob's Burgers", restaurant.Name);
        }

        [Fact]
        public void AddReviewTest()
        {

        }

    }
}