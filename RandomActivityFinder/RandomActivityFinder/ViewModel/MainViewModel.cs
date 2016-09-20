using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MvvmCross.Core.ViewModels;
using RandomActivityFinder.Core.Contracts.ViewModel;
using MvvmCross.Platform;

namespace RandomActivityFinder.Core.ViewModel
{
    public class MainViewModel : MvxViewModel, IMainViewModel
    {
        private readonly Lazy<SearchViewModel> _searchViewModel;
        private readonly Lazy<SettingsViewModel> _settingsViewModel;
        public SearchViewModel SearchViewModel => _searchViewModel.Value;
        public SettingsViewModel SettingsViewModel => _settingsViewModel.Value;
        public MainViewModel()
        {
            _searchViewModel = new Lazy<SearchViewModel>(Mvx.IocConstruct<SearchViewModel>);
            _settingsViewModel = new Lazy<SettingsViewModel>(Mvx.IocConstruct<SettingsViewModel>);
        }
    }
}
