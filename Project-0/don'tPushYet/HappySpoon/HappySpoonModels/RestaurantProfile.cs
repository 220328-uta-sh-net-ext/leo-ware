using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappySpoonModels
{
      public class RestaurantProfile
      {
        private string name { get; set; }
        private string description { get; set; }
        private string location { get; set; }
        private string contactInfo { get; set; }
        public string averageRating { get; set; }
        static string reviews { get; set; }

      }
}
