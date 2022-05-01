

namespace HappySpoonModels
{
    public class RestaurantProfile
    {
        private string RestaurantName { get; set; }
        private string Description { get; set; }
        private string Location { get; set; }
        private string ContactInfo { get; set; }
        public double AverageRating { get; set; }
        public List<ReviewRepo> GetReviews { get; set; }

        public RestaurantProfile()
        {
            GetReviews = new List<ReviewRepo>()
            {
                new Review()
            };
        }

        public RestaurantProfile(string RestaurantName)
        {
            RestaurantName = new List<ReviewRepo>()
            {
                new Review()
            };
        }

        public RestaurantProfile(RestaurantRow row)
        {
            RestaurantName = row.["RestaurantName"].ToString() ?? "";
            Description = row.["Description"].ToString() ?? "";
            Location = row.["Location"].ToString() ?? "";
            ContactInfo = row.["ContactInfo"].ToString() ?? "";
        }

        public override string ToString()
        {
            return $"{RestaurantName}\n{Description}\n{Location}\n{ContactInfo}\n{AverageRating}";
        }
        

    }

}
