using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamEFCore.Views;

namespace XamEFCore.ViewModels
{
    public class MenuItemViewModel
    {
        #region Attributes
        public int Id { get; set; }
        public string Option { get; set; }
        public string Icon { get; set; }
        #endregion Attributes

        #region Commands
        public ICommand SelectMenuItemCommand
        {
            get
            {
                return new Command(SelectMenuItemExecute);
            }
        }
        #endregion Commands

        #region Methods
        private void SelectMenuItemExecute()
        {
            if(this.Id == 1)
                Application.Current.MainPage.Navigation.PushAsync(new AlbumPage());

            else
                Application.Current.MainPage.Navigation.PushAsync(new AlbumesPage());
        }
        #endregion Methods
    }
}
