using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using XamaFilm.Services;
using XamaFilm.ViewModels.Base;
using XamaFilm.Views;
using Xamarin.Forms;

namespace XamaFilm.ViewModels
{
    public class MenuViewModel:ViewModelBase
    {
        ObservableCollection<MasterViewMenuItem> _menuItems = new ObservableCollection<MasterViewMenuItem>();
        public ObservableCollection<MasterViewMenuItem> MenuItems
        {
            get => _menuItems;
            set
            {
                _menuItems = value;
                OnPropertyChanged();
            }
        }

        public MenuViewModel()
        {
            InitMenuItems();
        }

        private void InitMenuItems()
        {
            MenuItems.Add(new MasterViewMenuItem
            {
                Title = "HOME",
                MenuItemType = MenuItemType.Home,
                ViewModelType = typeof(HomeViewModel),
                IsEnabled = true
            });
            MenuItems.Add(new MasterViewMenuItem
            {
                Title = "MOVIES",
                MenuItemType = MenuItemType.Movies,
                ViewModelType = typeof(MoviesListViewModel),
                IsEnabled = true
            });
            MenuItems.Add(new MasterViewMenuItem
            {
                Title = "SERIES",
                MenuItemType = MenuItemType.Series,
                ViewModelType = typeof(SeriesListViewModel),
                IsEnabled = true
            });
            MenuItems.Add(new MasterViewMenuItem
            {
                Title = "FAVORITES",
                MenuItemType = MenuItemType.Favorites,
                ViewModelType = typeof(FavoritesViewModel),
                IsEnabled = true
            });
            MenuItems.Add(new MasterViewMenuItem
            {
                Title = "WATCHLIST",
                MenuItemType = MenuItemType.Watchlist,
                ViewModelType = typeof(WatchlistViewModel),
                IsEnabled = true
            });
            MenuItems.Add(new MasterViewMenuItem
            {
                Title = "SETTINGS",
                MenuItemType = MenuItemType.Settings,
                ViewModelType = typeof(SettingsViewModel),
                IsEnabled = true
            });

        }

        public ICommand ItemSelectedCommand => new Command<Object>(onSelectedCommand);

        private void onSelectedCommand(object Menu)
        {

            ViewModelLocator.Instance
                .Resolve<INavigationService>()
                .NavigateToAsync((Menu as MasterViewMenuItem).ViewModelType);
        }
    }
}
