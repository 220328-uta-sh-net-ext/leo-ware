using HappySpoonModels;
namespace HappySpoonDL
{
    public class RestaurantRepo : IRestaurant
    {
        private string filePath = "../PokemonDL/Database";
        private string jsonString;

        
        RestaurantRepo AddRestaurant(RestaurantRepo newRestaurant)
        {
            var restaurant = GetRestaurants();
            restaurant.Add(newRestaurant);
        }
        public List<RestaurantRepo> GetRestaurants()
        {
            jsonString = File.ReadAllText(filePath + "restaurants.json");
        }
    }

    public class ReviewRepo : IReview
    {
        private string filePath = "../PokemonDL/Database";
        private string jsonString;

        public ReviewRepo IReview.AddReview(string restaurantName, ReviewRepo newReview)
        {
            var restaurants = GetRestaurants();
            foreach (var review in restaurants)
            {
                if (review.RestaurantName == restaurantName)
                {
                    review.Review.Add(newReview);
                    break;
                }
            }
            return newReview;
        }

        public List<ReviewRepo> IReview.GetReviews()
        {
            jsonString = File.ReadAllText(filePath + "reviews.json");
        }
    }
}
