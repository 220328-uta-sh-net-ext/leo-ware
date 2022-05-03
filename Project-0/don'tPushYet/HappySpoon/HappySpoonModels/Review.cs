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
        public string UserName { get; set; }
        public int Rating { get; set; }
        public string Comments { get; set; }
        public RestaurantProfile Name { get; set; }

        public Review(RestaurantProfile name)
        {
            Name = name;
        }



        /*public Review()
        {
            userID = UserID;
            userName = UserName;
            averageRating = AverageRating;
        }*/

        /*public Review(string Comments)
        {
            userID = UserID;
            userName = UserName;
            averageRating = AverageRating;
            comments = Comments;

        }*/

        public override string ToString()
        {
            return $"{UserID}\n{UserName}\n{Rating}\n{Comments}";
        }
    }
}
