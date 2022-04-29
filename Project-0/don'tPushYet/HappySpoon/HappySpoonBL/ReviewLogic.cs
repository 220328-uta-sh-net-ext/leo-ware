using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonDL;

namespace HappySpoonBL
{
    internal class ReviewLogic : ReviewInterface
    {
        readonly ReviewInterface repo;

        public ReviewLogic(ReviewInterface repo)
        {
            this.repo = repo;
        }


        public void AddReview(string name, string entry)
        {
            throw new NotImplementedException();
        }

    }
}
