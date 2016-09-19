using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Widget;
using MvvmCross.Droid.Support.V7.AppCompat;
using RandomActivityFinder.Core.ViewModel;
using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace RandomActivityFinder.Droid.Activities
{
    [Activity(Label = "Main Activity", Theme = "@style/AppTheme",
        LaunchMode = LaunchMode.SingleTop,
        ScreenOrientation = ScreenOrientation.Portrait,
        Name = "randomactivityfinder.droid.activities.MainActivity")]
    public class MainActivity : MvxCachingFragmentCompatActivity<MainViewModel>
    {
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
		}
	}
}


