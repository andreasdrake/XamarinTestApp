using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using XamarinTestApp.Controls;
using XamarinTestApp.iOS.Renderers;

[assembly: ExportRenderer(typeof(RoundCornersButton), typeof(RoundCornersButtonRenderer))]
namespace XamarinTestApp.iOS.Renderers
{
    public class RoundCornersButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                // Subscribe for events
            }
            else if (e.OldElement != null)
            {
                // Unsubscribe from events
            }

            if (Control != null)
            {
                Control.Layer.CornerRadius = 15;
                Control.ClipsToBounds = true;
            }
        }
    }
}