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

   

        //[Theory]
        //[InlineData("AmericaChavez", )]
        //public void SearchUserTest()
        //{
            //List<UserProfile> user = new List<UserProfile>();
            //IUser repo = this.repo;

                //user.UserName = Console.ReadLine();
                //foreach (var i in user.UserName)
                //{
                  //  if (i.Equals(user.UserName))
                 //   repo.GetUser(user);
                //}
                
        //}

    }
}