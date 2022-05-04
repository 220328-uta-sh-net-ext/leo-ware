namespace HappySpoonModels
{
    public class RestaurantProfile
    {
        public int RestaurantID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string ContactInfo { get; set; }
        public double Stars { get; set; }
        public string Reviews { get; set; }
        public int NumOfReviews { get; set; }

        //Rating / (Reviews * 5) -- Calculating average rating

        public RestaurantProfile()
        {
            RestaurantID = 0;
            Name = "";
            Description = "";
            Location = "";
            ContactInfo = "";
            Stars = 0;
            Reviews = "";
            NumOfReviews = 0;
            
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
            return $"{Name}\n{Description}\n{Location}\n{ContactInfo}\n{Stars}\n\n{Reviews}";
        }
        

    }

}
