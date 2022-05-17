using HappySpoonBL;
using HappySpoonDL;
using HappySpoonModels;
using HappySpoonUI;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace HappySpoonTest
{
    public class HappySpoonUnitTest
    {
        //private readonly ILogic logic;
        //private IRepo repo;

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
        public void LoginSuccess()
        {
           var uName = "AmericaChavez";
           var  uPass = "Password";

            List<UserProfile> user = new List<UserProfile>();

            if (uName.Equals(user) && uPass.Equals(user))
                
            Assert.Equal(user, user);

        }


        /*[Fact]
        public void SearchUser(List<UserProfile> user)
        {
           var uName = "Amer";

            List<UserProfile> user = new List<UserProfile>();

            if (uName.Contains(user))

            Assert.Equal("AmericaChavez", user);

        }*/

    }
}