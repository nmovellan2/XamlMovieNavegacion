using System;
using System.Collections.Generic;
using System.Text;

namespace XamaFilm.ViewModels
{
    public class MasterViewModel : Base.ViewModelBase
    {

        public MasterViewModel(MenuViewModel menuViewModel)
        {
            MenuViewModel = menuViewModel;
        }

        private MenuViewModel _menuViewModel;
        public MenuViewModel MenuViewModel
        {
            get => _menuViewModel;
            set
            {
                _menuViewModel = value;
                OnPropertyChanged();
            }
        }
    }
}
