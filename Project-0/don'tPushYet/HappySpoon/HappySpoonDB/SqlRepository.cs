using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappySpoonDL
{
    internal class SqlRepository
    {
       public List<UserRepo> GetUsers { get; set; }
       public List<RestaurantRepo> GetRestaurants { get; set; }
       public List<ReviewRepo> GetReviews { get; set; }
    }
}
