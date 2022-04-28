namespace HappySpoonDL
{
    public class ReviewRepo
    {
        private string filePath = "../PokemonDL/Database";
        private string jsonString;

        public void GetReviews()
        {
            jsonString = File.ReadAllText(filePath + "reviews.json");
        }
    }
}