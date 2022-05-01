using HappySpoonModels;

namespace HappySpoonDL
{
    public interface IReview
    {
        ReviewRepo AddReview(string restaurantName, Review newReview);
        ReviewRepo AddReview(Review newReview);
        List<ReviewRepo> GetReviews();
    }
}
