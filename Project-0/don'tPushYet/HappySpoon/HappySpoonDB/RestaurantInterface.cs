using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappySpoonDL
{
    public interface RestaurantInterface
    {
        Restaurant restaurant(Restaurant, string rating);
        
        List<Restaurant> GetRestaurants();
    }
}
