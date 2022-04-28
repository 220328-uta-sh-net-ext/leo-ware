using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonDL;

namespace HappySpoonUI
{
    public interface ReviewInterface
    {
            ReviewRepo AddReview(string name, string entry);

            List<ReviewRepo> GetReviews();
    }
}
