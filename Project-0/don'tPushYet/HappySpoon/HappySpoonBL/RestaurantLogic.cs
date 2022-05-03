using HappySpoonDL;
using HappySpoonModels;


namespace HappySpoonBL
{
    public class RestaurantLogic
    {
        readonly IRepo repo;
        private ILogic Rlogic;

        public RestaurantLogic(ILogic logic)
        {
            Rlogic = logic;
        }
        public List<RestaurantProfile> GetRestaurants { get; set; }

        public List<Review> GetReviews { get; set; }

        public List<Review> GetRatings { get; set; }

        public void RestaurantProfile(RestaurantProfile Restaurant)
        {
                Console.WriteLine($"Restaurant Name: {Restaurant.Name}\nDescription: {Restaurant.Description}\nLocation: {Restaurant.Location}\n ContactInfo: {Restaurant.ContactInfo}\nAverage Rating: {Restaurant.AverageRating}\nReviews: {Restaurant.GetReviews}");
        }

        public void RestaurantProfile(List<RestaurantProfile> Restaurants)
        {
            foreach (var restaurant in GetRestaurants)
            {
                RestaurantProfile(restaurant);
            }
        }

        /*public void AddRestaurant(RestaurantProfile Restaurant)
        {
            GetRestaurants.Add(Restaurant);
        }*/

        public void SearchAllRestaurants(string Name)
        {
            var Restaurant = GetRestaurants.FirstOrDefault(r => r.Name == Name);
            if (Restaurant == null)
            {
                Console.WriteLine($"Sorry, {Restaurant} was not found.\nPlease check your input and try again.");
            }
            else
            {
                RestaurantProfile(Restaurant);
            }
        }

        public void SearchAllRestaurants()
        {
            foreach (var restaurants in GetRestaurants)
            {
                RestaurantProfile(restaurants);
            }
        }

        public void SearchRestaurants(string phrase)
        {
            var target = GetRestaurants.Where(r => r.Name.Contains(phrase)).ToList();
            foreach (var restaurant in target)
            {
                RestaurantProfile(target);
            }
        }

    }

    public class ReviewLogic
    {
        readonly IRepo repo;
        readonly ILogic logic;
        public ReviewLogic(ILogic logic)
        {
            this.logic = logic;
        }

        public int AddRating(int stars)
        {
            while (true)
            {
                Console.WriteLine("Choose a rating from 1 to 5,\n5 is the highest rating and 1 is the lowest rating");
                string input = Console.ReadLine();

                if (int.TryParse(input, out stars))
                {
                    if (stars >= 1 && stars <= 5)
                    {
                        Console.WriteLine($"You've rated this restaurant {stars} stars. Thank you for your feedback.");
                        return stars;
                    }
                    else
                        Console.WriteLine("We appreciate your enthusiasm,\nbut you may only give restaurants a rating from 1 to 5");
                }
                else
                    Console.WriteLine("Your input was invalid. Please try entering a number.");
            }
        }


        /*public void AddReview(Review Comments, List<RestaurantProfile> Name)
        {
            var reviews = GetReviews.Where(u => u.Comments.Contains(Name)).ToList();
            foreach (var review in reviews)
            {
                //RestaurantProfile(review);
                return GetReviews.Add(review);
            }

            Console.WriteLine($"How was your experience at {Name}?");

        }*/

        public List<Review> GetRestaurants(RestaurantProfile Name)
        {
            List<Review> restaurant = repo.GetReviews();
            var filteredRestaurants = restaurant.Where(r => r.Name.Contains(Name)).ToList();
            return filteredRestaurants;
        }

        public List<Review> GetReviews(string review, int stars)
        {
            List<Review> reviews = repo.GetReviews();
            var filterReviews = reviews.Where(r => r.Comments.ToLower().Equals(review) || r.Rating.Equals(stars)).ToList();
            return filterReviews;
        }

    }

}
