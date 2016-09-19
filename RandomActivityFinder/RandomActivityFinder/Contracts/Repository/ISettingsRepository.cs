using System.Collections.Generic;
using RandomActivityFinder.Core.Model;

namespace RandomActivityFinder.Core.Contracts.Repository
{
    public interface ISettingsRepository
    {
        string GetAboutContent();
    }
}