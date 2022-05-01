using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonDL;
using HappySpoonUI;

namespace HappySpoonBL
{
    internal class ReviewLogic : IReview
    {
        readonly IReview repo;

        public ReviewLogic(IReview repo)
        {
            this.repo = repo;
        }


        public void AddReview(string name, string entry)
        {
            throw new NotImplementedException();
        }

    }
}
