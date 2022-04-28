﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonModels;

namespace HappySpoonUI
{
    public interface RestaurantInterface
    {
      
            RestaurantProfile Restaurant();

            List<RestaurantProfile> GetRestaurants();
        
    }
}
