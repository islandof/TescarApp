using System.Windows.Input;
using VehicleManageApp.Mvvm;
using Xamarin.Forms;

namespace VehicleManageApp.ViewModels
{
    public class WelcomeViewModel
    {
        private INavigation _navi;

        public WelcomeViewModel(INavigation navi)
        {
            _navi = navi;
        }

        public ICommand GoToLoginPageCommand
        {
            get { return new SimpleCommand(() => _navi.PushAsync(App.LoginPage)); }
        }
    }
}
