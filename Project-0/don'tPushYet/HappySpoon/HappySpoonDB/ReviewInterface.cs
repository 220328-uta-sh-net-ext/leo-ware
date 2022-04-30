using HappySpoonDL;
using HappySpoonModels;

namespace HappySpoonUI
{
    public interface ReviewInterface
    {
            void AddReview(string name, string entry);

            List<ReviewRepo> GetReviews();
    }
}
