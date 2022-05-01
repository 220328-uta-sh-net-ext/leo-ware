using HappySpoonDL;
using HappySpoonModels;


namespace HappySpoonBL
{
    public class RestaurantLogic
    {

        static RestaurantRepo getRestaurants = new RestaurantRepo();

        static ReviewRepo getReviews = new ReviewRepo();
        public ReviewRepo AddReview(string restaurantName)
        {
            Review newReview = ReviewRepo();

            Console.WriteLine($"How was your experience at {restaurantName}?");
            newReview.comments = reviews.Comments();
            newReview.

            return repo.AddReview(restaurantName, newReview);
        }
        public static void GetRestaurants()
        {
            var restaurants = getRestaurants.GetRestaurants();
            foreach (var restaurant in restaurants)
            {
                reviews.AverageRating(restaurant);
                Console.WriteLine(restaurant.ToString());
            }
        }


        public static string GetRestaurants(int index)
        {
            var restaurants = getRestaurants.GetRestaurants();
            return restaurants[index].RestaurantName;
        }

        public List<RestaurantProfile> SearchRestaurants(string name)
        {
            var restaurants = getRestaurants.GetRestaurants();
            var filteredRestaurants = restaurants.Where(restaurant => restaurant.RestaurantName.ToLower().Contains(name)).ToList();
            return filteredRestaurants;
        }

    
    }

}
