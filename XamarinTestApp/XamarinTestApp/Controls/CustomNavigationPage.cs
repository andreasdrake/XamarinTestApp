using Xamarin.Forms;

namespace XamarinTestApp.Controls
{
    public class CustomNavigationPage : NavigationPage
    {
        public CustomNavigationPage():base()
        {

        }
        public CustomNavigationPage(Page root):base(root)
        {

        }

        //public static readonly BindableProperty BarItemFontSizeProperty =
        //    BindableProperty.Create(
        //    nameof(BarItemFontSize),
        //    typeof(float),
        //    typeof(CustomNavigationPage),
        //    20);

        //public float BarItemFontSize
        //{
        //    get { return (float)GetValue(BarItemFontSizeProperty); }
        //    set { SetValue(BarItemFontSizeProperty, value); }
        //}

        //public static readonly BindableProperty BarItemFontFamilyProperty =
        //    BindableProperty.Create(
        //    nameof(BarItemFontFamily),
        //    typeof(string),
        //    typeof(CustomNavigationPage),
        //    "");

        //public string BarItemFontFamily
        //{
        //    get { return (string)GetValue(BarItemFontFamilyProperty); }
        //    set { SetValue(BarItemFontFamilyProperty, value); }
        //}



        //public static readonly BindableProperty BarTitleFontSizeProperty =
        //  BindableProperty.Create(
        //  nameof(BarTitleFontSize),
        //  typeof(float),
        //  typeof(CustomNavigationPage),
        //  20.0);

        //public float BarTitleFontSize
        //{
        //    get { return (float)GetValue(BarTitleFontSizeProperty); }
        //    set { SetValue(BarTitleFontSizeProperty, value); }
        //}


        //public static readonly BindableProperty BarTitleFontFamilyProperty =
        //    BindableProperty.Create(
        //    nameof(BarTitleFontFamily),
        //    typeof(string),
        //    typeof(CustomNavigationPage),
        //    "Montserrat-Bold");

        //public string BarTitleFontFamily
        //{
        //    get { return (string)GetValue(BarTitleFontFamilyProperty); }
        //    set { SetValue(BarTitleFontFamilyProperty, value); }
        //}
    }
}
