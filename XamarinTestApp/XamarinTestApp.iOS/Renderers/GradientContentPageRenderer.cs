using CoreAnimation;
using CoreGraphics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinTestApp.Controls;
using XamarinTestApp.iOS.Renderers;

[assembly: ExportRenderer(typeof(GradientContentPage), typeof(GradientContentPageRenderer))]
namespace XamarinTestApp.iOS.Renderers
{
    //Saxat av: https://forums.xamarin.com/discussion/22440/gradient-as-background-color
    public class GradientContentPageRenderer : PageRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null) // perform initial setup
            {
                var page = e.NewElement as GradientContentPage;
                var gradientLayer = new CAGradientLayer()
                {
                    Frame = View.Bounds,
                    Colors = new CGColor[] { page.StartColor.ToCGColor(), page.EndColor.ToCGColor() }
                };
                View.Layer.InsertSublayer(gradientLayer, 0);
            }
        }
    }
}
