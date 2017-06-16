using Xamarin.Forms;
using XamarinTestApp.Controls;
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

            var navPage = new CustomNavigationPage(new DashboardPage { BindingContext = new DashboardviewModel() });
            //var navPage = new TransparentNavigationPage(new DashboardPage { BindingContext = new DashboardviewModel() });
            navPage.BarBackgroundColor = Color.FromHex("#0d1829");
            navPage.BarTextColor = Color.White;
            //navPage.BarTitleFontFamily = "Montserrat-Bold";

            //Master = new MenuPage();
            Master = new MenuPage2();
            Detail = navPage;
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
