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
                e.NewElement.SizeChanged += NewElementSizeChanged;
            }
            else if (e.OldElement != null)
            {
                e.OldElement.SizeChanged -= NewElementSizeChanged;
            }

      
        }

        private void NewElementSizeChanged(object sender, System.EventArgs e)
        {
            if (Control != null)
            {
                var view = (RoundCornersButton)Element;

                Control.Layer.CornerRadius =(float)view.Height/2;
                Control.ClipsToBounds = true;
            }
        }
    }
}