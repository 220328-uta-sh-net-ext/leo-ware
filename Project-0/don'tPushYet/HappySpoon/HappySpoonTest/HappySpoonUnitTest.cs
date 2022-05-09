using HappySpoonBL;
using HappySpoonDL;
using HappySpoonModels;
using HappySpoonUI;
using System;
using System.Collections.Generic;
using Xunit;

namespace HappySpoonTest
{
    public class HappySpoonUnitTest
    {
        private readonly IUserLogic logic;
        private IUser repo;

        [Fact]
        public void AddUserTest()
        {

            UserProfile User = new UserProfile
            {
                UserName = "flubber",
                UserPassword = "flubbersgonnaflub",
                UserEmail = "daflubbz@blobsRUs.com"
            };

            Assert.Equal("flubber", User.UserName);
            Assert.Equal("flubbersgonnaflub", User.UserPassword);
            Assert.Equal("daflubbz@blobsRUs.com", User.UserEmail);
        }

        [Fact]

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

            Assert.Equal(5, rp.RestaurantID);
            Assert.Equal("Denys", rp.Name);
            Assert.Equal("24 Hour diner", rp.Description);
            Assert.Equal("Savannah", rp.Location);
            Assert.Equal("2224563875", rp.ContactInfo);
            Assert.Equal(4, rp.AverageStars);


        }

        [Fact]
        public void SearchRestaurantsTest()
        {
            List<RestaurantProfile> restaurant = new List<RestaurantProfile>()
            {
               // var rp = Name.Where(s => s.Contains("Bobs Burgers"))
            };
        }

        [Fact]
        public void AddReviewTest()
        {
            Review r = new Review
            {
                Comments = "I hated it. Ew.",
                Stars = 1
            };

            Assert.Equal("I hated it. Ew.", r.Comments);
            Assert.Equal(1, r.Stars);
        }

        [Fact]
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
            Assert.Equal(1, rp.RestaurantID);
            Assert.Equal("Spondivits", rp.Name);
            Assert.Equal("Buscuits and seafood. Just how grandma made it!", rp.Description);
            Assert.Equal("Atlanta", rp.Location);
            Assert.Equal("4049123791", rp.ContactInfo);
            Assert.Equal(5, rp.AverageStars);
        }

        /*[Theory]
        [InlineData("AmericaChavez", UserName)]
        public void SearchUserTest()
        {
            List<UserProfile> user = new List<UserProfile>();
            IUser repo = this.repo;

                user.UserName = Console.ReadLine();
                foreach (var i in user.UserName)
                {
                    if (i.Equals(user.UserName))
                     repo.GetUser();
                }
                
        }*/

    }
}