using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RandomActivityFinder.Core.Contracts.ViewModel;
using RandomActivityFinder.Core.Contracts.Services;
using RandomActivityFinder.Core.Model;
using MvvmCross.Core.ViewModels;
using MvvmCross.Plugins.Messenger;
using MvvmCross.Platform.Platform;
using RandomActivityFinder.Core.Model.App;

namespace RandomActivityFinder.Core.ViewModel

{
    public class SuggestionViewModel : BaseViewModel, ISuggestionViewModel
    {
        private readonly IRandomActivityDataService _randomActivityDataService;
        private RandomActivity _randomActivity;
        private double _activityDistance;
        private int _activityType;
        private string _activityCustomSearch;
        private double _latitude;
        private double _longitude;

        public RandomActivity SelectedActivity
        {
            get { return _randomActivity; }
            set
            {
                _randomActivity = value;
                RaisePropertyChanged(() => SelectedActivity);
            }
        }

        public MvxCommand ReloadDataCommand
        {
            get
            {
                return new MvxCommand(async () =>
                {
                    _randomActivity = (await _randomActivityDataService.SearchRandomActivity(_activityDistance, _activityType, _activityCustomSearch, _latitude, _longitude));
                });
            }
        }

        public SuggestionViewModel(IMvxMessenger messenger,
                                   IRandomActivityDataService randomActivityDataService) : base(messenger)
        {
            _randomActivityDataService = randomActivityDataService;
        }

        public override async void Start()
        {
            base.Start();
            await ReloadDataAsync();
        }

        protected override async Task InitializeAsync()
        {
            _randomActivity = (await _randomActivityDataService.SearchRandomActivity(_activityDistance, _activityType, _activityCustomSearch, _latitude, _longitude));
        }
        public void Init(SearchParameters parameters)
        {
            _activityDistance = parameters.ActivityDistance;
            _activityType = parameters.ActivityType;
            _activityCustomSearch = parameters.ActivityCustomSearch;
            _latitude = parameters.UserLatitude;
            _longitude = parameters.UserLongitude;
        }
    }
}
