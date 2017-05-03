using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinTestApp.ViewModels;

namespace XamarinTestApp.Views
{
    public class RootPage : MasterDetailPage
    {
        private readonly LoginPage _loginPage;
        private readonly LoginViewModel _loginViewModel;

        public RootPage()
        {
            _loginViewModel = new LoginViewModel(OnUserLoggedIn);
            _loginPage = new LoginPage { BindingContext = _loginViewModel };
            Master = new AboutPage();
            Detail = new NavigationPage(new ItemsPage());
            ShowLoginDialog();
        }


        private async void ShowLoginDialog()
        {
            await Navigation.PushModalAsync(_loginPage);
        }

        private async void PopLoginDialog()
        {
            await Navigation.PopModalAsync();
        }

        private void OnUserLoggedIn(string userName)
        {
            PopLoginDialog();
        }
    }
}
