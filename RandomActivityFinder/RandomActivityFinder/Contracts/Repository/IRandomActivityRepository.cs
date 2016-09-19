using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RandomActivityFinder.Core.Model;

namespace RandomActivityFinder.Core.Contracts.Repository
{
    public interface IRandomActivityRepository
    {
        Task<RandomActivity> GetRandomActivityDetails(int index);
    }
}
