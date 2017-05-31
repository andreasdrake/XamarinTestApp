using Xamarin.Forms;
using XamarinTestApp.Controls;
using XamarinTestApp.Droid.Renderers;

[assembly: ExportRenderer(typeof(RoundCornersButton), typeof(RoundCornersButtonRenderer))]
namespace XamarinTestApp.Droid.Renderers
{
    using Android.Graphics.Drawables;
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Platform.Android;

    public class RoundCornersButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                e.NewElement.SizeChanged += NewElement_SizeChanged;
            }
            else if (e.OldElement != null)
            {
                e.OldElement.SizeChanged -= NewElement_SizeChanged;
            }
        }

        private void NewElement_SizeChanged(object sender, EventArgs e)
        {
            if (Control != null)
            {
                var view = (RoundCornersButton)Element;
                GradientDrawable gradientDrawable = new GradientDrawable();
                gradientDrawable.SetShape(ShapeType.Rectangle);
                gradientDrawable.SetColor(view.BackgroundColor.ToAndroid());
                gradientDrawable.SetStroke(0, view.BorderColor.ToAndroid());
                gradientDrawable.SetCornerRadius(
                     AndroidHelpers.DpToPixels(this.Context,
                         Convert.ToSingle(view.Height/2)));

                Control.SetBackground(gradientDrawable);
            }
        }
    }
     
}