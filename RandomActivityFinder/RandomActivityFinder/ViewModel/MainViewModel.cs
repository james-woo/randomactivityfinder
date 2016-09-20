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
        public SearchViewModel SearchViewModel => _searchViewModel.Value;
        public MainViewModel()
        {
            _searchViewModel = new Lazy<SearchViewModel>(Mvx.IocConstruct<SearchViewModel>);
        }
    }
}
