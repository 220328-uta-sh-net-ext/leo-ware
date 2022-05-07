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
        public UserProfile UserName { get; set; }
        public double Stars { get; set; }
        public string Comments { get; set; }
        public RestaurantProfile Name { get; set; }

        public Review(RestaurantProfile name, UserProfile username)
        {
            name = Name;
            UserID = 0;
            username = UserName;
            Stars = 0;  //if (Stars = null) {return null;}
            Comments = "";
        }

        public override string ToString()
        {
            return $"{UserName}\n{Stars}\n{Comments}";
        }
    }
}
