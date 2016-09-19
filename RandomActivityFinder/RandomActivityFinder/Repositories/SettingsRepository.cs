using System.Collections.Generic;
using RandomActivityFinder.Core.Contracts.Repository;
using RandomActivityFinder.Core.Model;

namespace RandomActivityFinder.Core.Repositories
{
    public class SettingsRepository : ISettingsRepository
    {
        public string GetAboutContent()
        {
            return "Random Activity Finder";
        }
    }
}