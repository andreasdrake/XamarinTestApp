using Foundation;
using ImageCircle.Forms.Plugin.iOS;
using UIKit;

namespace XamarinTestApp.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
            //Icon definitions:
            //Font Awesome: http://fontawesome.io/cheatsheet/
            //Ionic: http://ionicons.com/

            Plugin.Iconize.Iconize.With(new Plugin.Iconize.Fonts.FontAwesomeModule())
                .With(new Plugin.Iconize.Fonts.IoniconsModule());

            global::Xamarin.Forms.Forms.Init();
            ImageCircleRenderer.Init();
            FormsPlugin.Iconize.iOS.IconControls.Init();
                      

            LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
        
    }
}
