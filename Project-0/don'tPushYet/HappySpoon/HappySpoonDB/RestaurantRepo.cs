using HappySpoonModels;
namespace HappySpoonDL
{
    public class RestaurantRepo : IRestaurant
    {
        private string filePath = "../HappySpoonDL/Database";
        private string jsonString;

    
        private RestaurantRepo AddRestaurant(RestaurantRepo newRestaurant)
        {    
            {
                var restaurants = GetRestaurants();
                restaurants.Add(newRestaurant);
            }
            public List<RestaurantRepo> GetRestaurants()
            {
                jsonString = File.ReadAllText(filePath + "restaurants.json");
            }
        }

    }

    

    public class ReviewRepo
    {

    
        private string filePath = "../HappySpoonDL/Database";
        private string jsonString;
        public ReviewRepo IReview.AddReview(string restaurantName, ReviewRepo newReview)
        {
            var restaurants = GetRestaurants();
            foreach (var restaurant in restaurants)
            {
                if (restaurant.RestaurantName == restaurantName)
                {
                    restaurant.Review.Add(newReview);
                    break;
                }
            }
            return newReview;
            List<ReviewRepo> GetReviews()
            {
                jsonString = File.ReadAllText(filePath + "reviews.json");
            }
        
        }


    }


}
