using XamarinTestApp.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTestApp.ViewModels;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinTestApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            SetMainPage();
        }
        // Kolla här för att gå från login page till main page
        //https://github.com/xamarin/xamarin-forms-samples/blob/master/MobileCRM/MobileCRM.Shared/Pages/RootPage.cs
        public static void SetMainPage()
        {
            var loginPage = new LoginPage { BindingContext = new LoginViewModel() };
            //loginPage.SetValue(NavigationPage.BarTextColorProperty, Color.White);
            //loginPage.SetValue(NavigationPage.BarBackgroundColorProperty, Color.Gray);
            var nav = new NavigationPage(loginPage);
            nav.SetValue(NavigationPage.BarTextColorProperty, Color.White);
            nav.SetValue(NavigationPage.BarBackgroundColorProperty, Color.Transparent);


            Current.MainPage = loginPage;//nav;// new LoginPage();// { BindingContext = new LoginViewModel() };
                
            //    new TabbedPage
            //{
            //    Children =
            //    {
            //        new NavigationPage(new ItemsPage())
            //        {
            //            Title = "Browse",
            //            Icon = Device.OnPlatform("tab_feed.png",null,null)
            //        },
            //        new NavigationPage(new AboutPage())
            //        {
            //            Title = "About",
            //            Icon = Device.OnPlatform("tab_about.png",null,null)
            //        },
            //    }
            //};
        }
    }
}
