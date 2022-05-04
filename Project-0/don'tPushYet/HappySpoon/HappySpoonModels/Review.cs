using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappySpoonModels
{
    public class Review : RestaurantProfile
    {
        public int UserID { get; set; }
        public UserProfile UserName { get; set; }
        public int Rating { get; set; }
        public string Comments { get; set; }
        public RestaurantProfile Name { get; set; }

        public Review(RestaurantProfile name, UserProfile username)
        {
            Name = Name;
            UserID = 0;
            UserName = UserName;
            Rating = 0;
            Comments = "";
        }

        public override string ToString()
        {
            return $"{UserID}\n{UserName}\n{Rating}\n{Comments}";
        }
    }
}
