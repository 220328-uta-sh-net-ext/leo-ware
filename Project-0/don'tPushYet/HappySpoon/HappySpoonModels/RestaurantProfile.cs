namespace HappySpoonModels
{
    public class RestaurantProfile
    {
        public int RestaurantID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string ContactInfo { get; set; }
        public double AverageStars { get; set; }

        //Rating / (Reviews * 5) -- Calculating average rating

        public RestaurantProfile()
        {
            RestaurantID = ++RestaurantID;
            Name = "";
            Description = "";
            Location = "";
            ContactInfo = "";
            AverageStars = 0;
        }



        /*public RestaurantProfile(RestaurantID)
        {
            RestaurantID = new List<Review> RestaurantID()
            {
                new Review()
            };
        }*/

        /*<summary> row = RestaurnatRow </>
         * Establishing where the data goes in the RestaurantProfile Table row
         * 
        public RestaurantProfile(RestaurantRow row)
        {
            RestaurantID = row.["RestaurantID"].ToString() ?? "";
            RestaurantName = row.["RestaurantName"].ToString() ?? "";
            Description = row.["Description"].ToString() ?? "";
            Location = row.["Location"].ToString() ?? "";
            ContactInfo = row.["ContactInfo"].ToString() ?? "";
        }*/

        public override string ToString()
        {
            return $"{Name}\n{Description}\n{Location}\n{ContactInfo}\n{AverageStars}";
        }
        

    }

}
