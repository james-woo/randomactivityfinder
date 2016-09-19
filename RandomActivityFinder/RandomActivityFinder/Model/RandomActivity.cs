using System;

namespace RandomActivityFinder.Core.Model
{
    public class RandomActivity : BaseModel
    {
        public string ActivityName { get; set; }

        public string ActivityAddress { get; set; }

        public double ActivityRating { get; set; }

        public int ActivityReviews { get; set; }

        public string ActivityTopReview { get; set; }

        public string ActivityImageURL { get; set; }

    }
}
