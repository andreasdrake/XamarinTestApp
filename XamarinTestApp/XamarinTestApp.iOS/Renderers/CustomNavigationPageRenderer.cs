//using UIKit;
//using Xamarin.Forms;
//using XamarinTestApp.Controls;
//using XamarinTestApp.iOS.Renderers;
//using Xamarin.Forms.Platform.iOS;
//using CoreAnimation;
//using CoreGraphics;

//[assembly: ExportRenderer(typeof(CustomNavigationPage), typeof(CustomNavigationPageRenderer))]
//namespace XamarinTestApp.iOS.Renderers
//{
//    public class CustomNavigationPageRenderer : NavigationRenderer
//    {
//        public CustomNavigationPageRenderer()
//        {
//            this.NavigationBarHidden = true;
//        }
//        public override void ViewDidLoad()
//        {
//            base.ViewDidLoad();
//            var gradient = new CAGradientLayer();
//            gradient.Frame = NavigationBar.Bounds;
//            gradient.NeedsDisplayOnBoundsChange = true;
//            gradient.MasksToBounds = true;
//            View.BackgroundColor = UIColor.Black;
//            gradient.Colors = new CGColor[]
//            {
//                UIColor.from
//                    UIColor.FromCGColor( f80000.CGColor, UIColor.From #8f0000.CGColor
//            };  
//UIGraphics.BeginImageContext(gradient.Bounds.Size);
//            gradient.RenderInContext(UIGraphics.GetCurrentContext());
//            UIImage backImage = UIGraphics.GetImageFromCurrentImageContext();
//            UIGraphics.EndImageContext();
//            UINavigationBar.Appearance.SetBackgroundImage(backImage, UIBarMetrics.Default);
//        }
//    }
//}  


////05101f
