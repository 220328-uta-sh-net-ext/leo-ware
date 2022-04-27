namespace HappySpoonDL
{
    public class ReviewRepo
    {
        private string filePath = "../PokemonDL/Database";
        private string jsonString;

        public void GetUsers()
        {
            jsonString = File.ReadAllText(filePath + "reviews.json");
        }
    }
}