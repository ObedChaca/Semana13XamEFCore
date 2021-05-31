using Semana13XamEFCore.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace Semana13XamEFCore.ViewModels
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
            if (this.Id == 1)
                Application.Current.MainPage.Navigation.PushAsync(new AlbumPage());

            else
                Application.Current.MainPage.Navigation.PushAsync(new AlbumesPage());
        }
        #endregion Methods
    }
}
