using HappySpoonModels;

namespace HappySpoonDL
{
    public interface IReview
    {
        void AddReview(ReviewRepo newReview);
        List<Review> GetReviews();
    }
}
