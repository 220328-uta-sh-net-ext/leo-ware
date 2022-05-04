using HappySpoonDL;
using HappySpoonModels;


namespace HappySpoonBL
{
    public class RestaurantLogic : IRestaurantLogic
    {
        readonly IRestaurant repo;
        public RestauarantRepo

        public List<RestaurantProfile> GetAllRestaurants()
        {
            List<RestaurantProfile> restaurants = repo.GetAllRestaurants();
        }
        public void GetReview(string Comments, int Stars)
        {
            throw new NotImplementedException();
        }

        public void RestaurantProfile(RestaurantProfile Restaurant)
        {
                Console.WriteLine($"Restaurant Name: {Restaurant.Name}\nDescription: {Restaurant.Description}\nLocation: {Restaurant.Location}\n ContactInfo: {Restaurant.ContactInfo}\nRating: {Restaurant.Stars}\nReviews: {Restaurant.Reviews}");
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


        // ***************************************** TRYING TO CALCULATE RATING ************************************************
        public int AddReview(int stars)
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

        public void AddReview(string Comments, int Stars) //maybe add RestaurantProfile Restaurant // GetStars??? instead of AddReview here?
        {
            
            // database : name (id = StoreId)  <-find the restaurant
            // set (newReview : Stars + newReview) (NumOfReviews = NumOfReviews + 1) insted of number of reviews I think I have to use number of stars.
            //numofreviews / Stars = 
            //float i = Stars / (numofreviews * 5) i = 0.6
            //if(i <= 0.2) = 1; if(0.4) = 2; if(0.6) = 3; if(0.8) = 4; else 5
            //if (i < 0.2)
            //{
                //repo.AddReview(Comments, Stars);
                //throw new NotImplementedException();
            //}
            
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

        /*public List<Review> GetRestaurants(RestaurantProfile Name)
        {
            List<Review> restaurant = repo.GetReviews();
            var filteredRestaurants = restaurant.Where(r => r.Name.Contains(Name)).ToList();
            return filteredRestaurants;
        }*/

        /*public List<Review> GetReviews(string review, int stars)
        {
            List<Review> reviews = repo.GetReviews();
            var filterReviews = review.Where(r => r.Comments.ToLower().Equals(review) || r.Rating.Equals(stars)).ToList();
            return filteredReviews;
        }*/

    }

}
