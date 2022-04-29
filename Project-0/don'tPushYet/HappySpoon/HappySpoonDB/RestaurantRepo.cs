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
