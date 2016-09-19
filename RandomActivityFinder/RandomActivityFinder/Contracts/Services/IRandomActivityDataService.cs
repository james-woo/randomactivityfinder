using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RandomActivityFinder.Core.Model;

namespace RandomActivityFinder.Core.Contracts.Services
{
    public interface IRandomActivityDataService
    {
        Task<RandomActivity> GetRandomActivityDetails(int index);
        Task<RandomActivity> SearchRandomActivity(double distance, int activityType, string custom, double latitude, double longitude);
    }
}
