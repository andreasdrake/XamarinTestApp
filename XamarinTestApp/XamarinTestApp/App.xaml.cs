using XamarinTestApp.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTestApp.ViewModels;
using System;
using System.Diagnostics;
//using Acr.UserDialogs;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinTestApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //SetMainPage2();
            try
            {
                SetRootPage();
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        public static void SetRootPage()
        {
            Current.MainPage = new RootPage();
        }

       
        // Kolla här för att gå från login page till main page
        //https://github.com/xamarin/xamarin-forms-samples/blob/master/MobileCRM/MobileCRM.Shared/Pages/RootPage.cs
        public static void SetMainPage()
        {
            
            var loginVm = new LoginViewModel(user => { });//UserDialogs.Instance, 
            var loginPage = new LoginPage { BindingContext = loginVm };
            
            //var nav = new NavigationPage(loginPage);
            //nav.SetValue(NavigationPage.BarTextColorProperty, Color.White);
            //nav.SetValue(NavigationPage.BarBackgroundColorProperty, Color.Transparent);

            //Current.MainPage = new RootPage();
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
