using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappySpoonModels
{
    public class Review
    {
        public int userID { get; set; }
        public string userName { get; set; }
        public string comments { get; set; }
        public double averageRating { get; set; }
        public int UserID;
        public string UserName;
        public double AverageRating;
        public Review()
        {
            userID = UserID;
            userName = UserName;
            averageRating = AverageRating;
        }

        public Review(string Comments)
        {
            userID=UserID;
            userName = UserName;
            averageRating = AverageRating;
            comments = Comments;

        }
    }
}
