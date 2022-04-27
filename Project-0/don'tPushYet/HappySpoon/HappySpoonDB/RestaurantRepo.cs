using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappySpoonDL
{
    public class RestaurantRepo
    {
        private string filePath = "../PokemonDL/Database";
        private string jsonString;

        public void GetUsers()
        {
            jsonString = File.ReadAllText(filePath + "restaurants.json");
        }
    }
}
