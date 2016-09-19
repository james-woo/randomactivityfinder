using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MvvmCross.Core.ViewModels;
using MvvmCross.Plugins.Messenger;
using MvvmCross.Localization;

namespace RandomActivityFinder.Core.ViewModel
{
    public class BaseViewModel : MvxViewModel, IDisposable
    {
        protected IMvxMessenger Messenger;

        public BaseViewModel(IMvxMessenger messenger)
        {
            Messenger = messenger;
        }

        public IMvxLanguageBinder TextSource => new MvxLanguageBinder("", GetType().Name);

        protected async Task ReloadDataAsync()
        {
            try
            {
                await InitializeAsync();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }

        protected virtual Task InitializeAsync()
        {
            return Task.FromResult(0);
        }
        public void Dispose()
        {
            Messenger = null;
        }
    }
}
