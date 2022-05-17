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

        public string UserName { get; set; }
        public double Stars { get; set; }
        public string Comments { get; set; }
        public string Restaurant { get; set; }
        

        public Review()
        {
            Restaurant = "";
            UserName = "";
            Stars = 0;
            Comments = "";
        }

        public override string ToString()
        {
            return $"{UserName}\n{Restaurant}\n{Stars}\n{Comments}";
        }
    }
}
