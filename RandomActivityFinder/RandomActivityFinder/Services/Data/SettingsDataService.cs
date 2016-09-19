using System.Collections.Generic;
using RandomActivityFinder.Core.Contracts.Repository;
using RandomActivityFinder.Core.Contracts.Services;

namespace RandomActivityFinder.Core.Services.Data
{
    public class SettingsDataService : ISettingsDataService
    {
        private readonly ISettingsRepository _settingsRepository;

        public SettingsDataService(ISettingsRepository settingsRepository)
        {
            _settingsRepository = settingsRepository;
        }

        public string GetAboutContent()
        {
            return _settingsRepository.GetAboutContent();
        }
    }
}