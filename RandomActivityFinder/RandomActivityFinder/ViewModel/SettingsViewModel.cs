using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MvvmCross.Core.ViewModels;
using MvvmCross.Plugins.Messenger;
using RandomActivityFinder.Core.Contracts.Services;
using RandomActivityFinder.Core.Contracts.ViewModel;
using MvvmCross.Plugins.WebBrowser;

namespace RandomActivityFinder.Core.ViewModel
{
    public class SettingsViewModel : BaseViewModel, ISettingsViewModel
    {
        private readonly ISettingsDataService _settingsDataService;
        private string _aboutContent;
        private readonly IMvxWebBrowserTask _webBrowser;

        public MvxCommand HelpCommand
        {
            get
            {
                return new MvxCommand(() =>
                {
                    _webBrowser.ShowWebPage("http://www.jameswoo.me");
                });
            }
        }

        public string AboutContent
        {
            get { return _aboutContent; }
            set
            {
                _aboutContent = value;
                RaisePropertyChanged(() => AboutContent);
            }
        }

        public SettingsViewModel(IMvxMessenger messenger, ISettingsDataService settingsDataService, IMvxWebBrowserTask webBrowser) : base(messenger)
        {
            _settingsDataService = settingsDataService;
            _webBrowser = webBrowser;

        }

        public override async void Start()
        {
            base.Start();
            await ReloadDataAsync();
        }

        protected override Task InitializeAsync()
        {
            return Task.Run(() =>
            {
                AboutContent = _settingsDataService.GetAboutContent();
            });
        }
    }
}
