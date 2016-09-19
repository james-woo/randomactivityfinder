using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MvvmCross.Core.ViewModels;
using RandomActivityFinder.Core.Model.App;
using System.Collections.ObjectModel;
using MvvmCross.Plugins.Messenger;
using RandomActivityFinder.Core.Utility;

namespace RandomActivityFinder.Core.ViewModel
{
    public class MenuViewModel : BaseViewModel
    {
        public MvxCommand<MenuItem> MenuItemSelectCommand => new MvxCommand<MenuItem>(OnMenuEntrySelect);
        public ObservableCollection<MenuItem> MenuItems { get; }

        public event EventHandler CloseMenu;

        public MenuViewModel(IMvxMessenger messenger) : base(messenger)
        {
            MenuItems = new ObservableCollection<MenuItem>();
            CreateMenuItems();
        }

        private void CreateMenuItems()
        {
            MenuItems.Add(new MenuItem
            {
                Title = "Settings",
                ViewModelType = typeof(SettingsViewModel),
                Option = MenuOption.Settings,
                IsSelected = false
            });
        }

        private void OnMenuEntrySelect(MenuItem item)
        {
            ShowViewModel(item.ViewModelType);
            RaiseCloseMenu();
        }

        private void RaiseCloseMenu()
        {
            CloseMenu?.Invoke(this, EventArgs.Empty);
        }
    }
}
