using Acr.UserDialogs;
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
            _loginViewModel = new LoginViewModel(UserDialogs.Instance, OnUserLoggedIn);
            _loginPage = new LoginPage { BindingContext = _loginViewModel };

            var navPage = new NavigationPage(new DashboardPage { BindingContext = new DashboardviewModel(UserDialogs.Instance) });
            navPage.SetValue(NavigationPage.BarBackgroundColorProperty, Color.Transparent);//, Color.FromHex("#060c14"));
            Master = new AboutPage();
            Detail = navPage;// new NavigationPage(new DashboardPage());
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
