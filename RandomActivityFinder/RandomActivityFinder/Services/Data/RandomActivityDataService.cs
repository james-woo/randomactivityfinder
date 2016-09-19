using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RandomActivityFinder.Core.Model;
using RandomActivityFinder.Core.Contracts.Repository;
using RandomActivityFinder.Core.Contracts.Services;

namespace RandomActivityFinder.Core.Services.Data
{
    public class RandomActivityDataService : IRandomActivityDataService
    {
        private readonly IRandomActivityRepository _randomActivityRepository;

        public RandomActivityDataService(IRandomActivityRepository randomActivityRepository)
        {
            _randomActivityRepository = randomActivityRepository;
        }

        public async Task<RandomActivity> GetRandomActivityDetails(int index)
        {
            return await _randomActivityRepository.GetRandomActivityDetails(index);
        }

        public async Task<RandomActivity> SearchRandomActivity(double distance, int activityType, string custom, double latitude, double longitude)
        {
            return await _randomActivityRepository.GetRandomActivityDetails(0);
        }
    }
}
