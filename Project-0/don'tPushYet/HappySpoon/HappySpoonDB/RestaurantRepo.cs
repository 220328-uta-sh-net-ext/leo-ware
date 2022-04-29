namespace HappySpoonDL
{
    public class RestaurantRepo
    {
        private string filePath = "../PokemonDL/Database";
        private string jsonString;

        public void GetRestaurants()
        {
            jsonString = File.ReadAllText(filePath + "restaurants.json");
        }
    }
}
