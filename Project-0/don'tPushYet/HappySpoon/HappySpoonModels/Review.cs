using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappySpoonModels
{
    public class Review
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public int ReviewID { get; set; }
        public int Rating { get; set; }
        public string Comments { get; set; }

        public int RestaurantID { get; set; }
        public RestaurantProfile Restaurant { get; set; }
      
        
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
