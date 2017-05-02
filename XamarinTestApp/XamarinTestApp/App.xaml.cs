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

        public static void SetMainPage()
        {
            var nav = new NavigationPage(new LoginPage { BindingContext = new LoginViewModel() });
            nav.SetValue(NavigationPage.BarTextColorProperty, Color.White);
            nav.SetValue(NavigationPage.BarBackgroundColorProperty, Color.Transparent);


            Current.MainPage = nav;// new LoginPage();// { BindingContext = new LoginViewModel() };
                
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
