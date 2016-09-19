using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RandomActivityFinder.Core.Contracts.ViewModel;
using RandomActivityFinder.Core.Contracts.Services;
using MvvmCross.Core.ViewModels;
using MvvmCross.Plugins.Messenger;
using RandomActivityFinder.Core.Model.App;

namespace RandomActivityFinder.Core.ViewModel
{
    public class SearchViewModel : BaseViewModel, ISearchViewModel
    {
        private readonly IConnectionService _connectionService;
        private readonly IDialogService _dialogService;

        private double _distance;
        private int _activityType;
        private string _customSearch;
        private double _latitude;
        private double _longitude;

        public double SelectedDistance
        {
            get { return _distance; }
            set
            {
                if (_distance != value)
                {
                    _distance = value;
                    RaisePropertyChanged(() => SelectedDistance);
                }
            }
        }

        public int SelectedActivityType
        {
            get { return _activityType; }
            set
            {
                if (_activityType != value)
                {
                    _activityType = value;
                    RaisePropertyChanged(() => SelectedActivityType);
                }
            }
        }

        public string SelectedCustomSearch
        {
            get { return _customSearch; }
            set
            {
                if (_customSearch != value)
                {
                    _customSearch = value;
                    RaisePropertyChanged(() => SelectedCustomSearch);
                }
            }
        }

        public double UsersCurrentLatitude
        {
            get { return _latitude; }
            set
            {
                if(_latitude != value)
                {
                    _latitude = value;
                    RaisePropertyChanged(() => UsersCurrentLatitude);
                }
            }
        }

        public double UsersCurrentLongitude
        {
            get { return _longitude; }
            set
            {
                if (_longitude != value)
                {
                    _longitude = value;
                    RaisePropertyChanged(() => UsersCurrentLongitude);
                }
            }
        }

        public IMvxCommand SearchCommand
        {
            get
            {
                return new MvxCommand(() =>
                    ShowViewModel<SuggestionViewModel>(new SearchParameters
                    {
                        ActivityDistance = SelectedDistance,
                        ActivityType = SelectedActivityType,
                        ActivityCustomSearch = SelectedCustomSearch,
                        UserLatitude = UsersCurrentLatitude,
                        UserLongitude = UsersCurrentLongitude
                    }));
            }
        }

        public SearchViewModel(IMvxMessenger messenger,
            IConnectionService connectionService,
            IDialogService dialogService) : base(messenger)
        {
            _connectionService = connectionService;
            _dialogService = dialogService;
        }

        public override async void Start()
        {
            base.Start();

            await ReloadDataAsync();
        }


        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            if (!_connectionService.CheckOnline())
            {
                await _dialogService.ShowAlertAsync("No internet available", "RandomActivityFinder says...", "OK");
            }
        }
    }
}
