using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RandomActivityFinder.Core.Model;
using RandomActivityFinder.Core.Contracts.Repository;

namespace RandomActivityFinder.Core.Repositories
{
    public class RandomActivityRepository : BaseRepository, IRandomActivityRepository
    {
        private static readonly List<RandomActivity> AllRandomActivities = new List<RandomActivity>()
        {
            new RandomActivity
            {
                ActivityName = "Test1",
                ActivityAddress = "Test Address1",
                ActivityRating = 5.0,
                ActivityReviews = 5,
                ActivityTopReview = "Test Review1",
                ActivityImageURL = "testurl1"
            },
            new RandomActivity
            {
                ActivityName = "Test2",
                ActivityAddress = "Test Address2",
                ActivityRating = 5.0,
                ActivityReviews = 5,
                ActivityTopReview = "Test Review2",
                ActivityImageURL = "testurl2"
            }
        };

        public async Task<RandomActivity> GetRandomActivityDetails (int index)
        {
            return await Task.FromResult(AllRandomActivities.ElementAt(index));
        }
    }
}
