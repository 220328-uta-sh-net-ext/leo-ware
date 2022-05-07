using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonModels;

namespace HappySpoonModels
{
    public class Review
    {

        public int UserID { get; set; }
        public string UserName { get; set; }
        public double Stars { get; set; }
        public string Comments { get; set; }
        public string Restaurant { get; set; }
        //RestaurantProfile Name { get => Name; set => Restaurant = Name; }

        public Review()
        {
            Restaurant = Restaurant;
            UserID = 0;
            UserName = UserName;
            Stars = 0;  //if (Stars = null) {return null;}
            Comments = "";
        }

        public override string ToString()
        {
            return $"{UserName}\n{Restaurant}\n{Stars}\n{Comments}";
        }
    }
}
