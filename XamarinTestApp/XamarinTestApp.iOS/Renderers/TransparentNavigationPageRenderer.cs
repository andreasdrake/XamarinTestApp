using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using XamarinTestApp.iOS.Renderers;
using Xamarin.Forms;
using XamarinTestApp.Controls;
using Xamarin.Forms.Platform.iOS;

//TODO: Check this solution: https://forums.xamarin.com/discussion/17278/custom-font-in-xamarin-forms-font-awesome/p1

[assembly: ExportRenderer(typeof(CustomNavigationPage), typeof(TransparentNavigationPageRenderer))]
namespace XamarinTestApp.iOS.Renderers
{
    public class TransparentNavigationPageRenderer : NavigationRenderer
    {
        //public override void ViewDidAppear(bool animated)
        //{
        //    base.ViewDidAppear(animated);
        //    if (
        //        NavigationController != null &&
        //        NavigationController.NavigationBar != null)
        //    {
        //        NavigationController.NavigationBar.Translucent = true;
        //    }




        //}

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            if (NavigationBar == null)
            {
                return;
            }

            //SetNavBarItems();
            SetNavBarTitle();


        }

        //private void SetNavBarItems()
        //{

        //    var navPage = this.Element as CustomNavigationPage;

        //    if (navPage == null) return;

        //    var textAttributes = new UITextAttributes()
        //    {
        //        Font = UIFont.FromName(navPage.BarItemFontFamily, navPage.BarItemFontSize)
        //    };

        //    var textAttributesHighlighted = new UITextAttributes()
        //    {
        //        TextColor = Color.White.ToUIColor(),
        //        Font = UIFont.FromName(navPage.BarItemFontFamily, navPage.BarItemFontSize)
        //    };

        //    UIBarButtonItem.Appearance.SetTitleTextAttributes(textAttributes,
        //        UIControlState.Normal);
        //    UIBarButtonItem.Appearance.SetTitleTextAttributes(textAttributesHighlighted,
        //        UIControlState.Highlighted);

        //    //NavigationBar.TitleTextAttributes = new UIStringAttributes()
        //    //{
        //    //    Font = UIFont.FromName("Montserrat-Bold", 20)
        //    //};
        //}

        //TODO: Hide Statusbar:https://stackoverflow.com/questions/36449480/hide-statusbar-for-specific-contentpage

        private void SetNavBarTitle()
        {
            var navPage = this.Element as CustomNavigationPage;

            if (navPage == null) return;
            //UIWindow.UIViewAppearance..
            //UIApplication.SharedApplication.StatusBarStyle = 
            this.NavigationBar.TintColor = UIColor.White;
            //this.NavigationBar.BarTintColor = Color.Transparent.ToUIColor();
            //this.NavigationBar.Translucent = true;
            NavigationBar.TitleTextAttributes = new UIStringAttributes
            {
                Font = UIFont.FromName("Montserrat-Bold", 20),//(navPage.BarTitleFontFamily, navPage.BarTitleFontSize),
                ForegroundColor = UIColor.White
            };
        }
    }
}