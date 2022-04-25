using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappySpoonDL
{
    public interface ReviewInterface
    {
        Review AddReview(string name, string entry);

        List<Review> GetReviews();
    }
}
