using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using RandomActivityFinder.Core.ViewModel;

namespace RandomActivityFinder
{
    class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {
            ShowViewModel<MainViewModel>();
        }
    }
}
