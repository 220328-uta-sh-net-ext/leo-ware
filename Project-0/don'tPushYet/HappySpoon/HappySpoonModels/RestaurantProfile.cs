namespace HappySpoonModels
{
    public class RestaurantProfile
      {
        private string Name { get; set; }
        private string Description { get; set; }
        private string Location { get; set; }
        private string ContactInfo { get; set; }
        public string AverageRating { get; set; }
        static string Reviews { get; set; }

      }

    List<RestaurantProfile> Restaurants
    { }
}
