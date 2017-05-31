using System;
using Xamarin.Forms;
using XamarinTestApp.Controls;
using XamarinTestApp.Droid.Renderers;
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;

[assembly: ExportRenderer(typeof(EntryWithCurvedCorners), typeof(EntryWithCurvedCornersRenderer))]
namespace XamarinTestApp.Droid.Renderers
{
    public class EntryWithCurvedCornersRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
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
                var view = (EntryWithCurvedCorners)Element;
                GradientDrawable gradientDrawable = new GradientDrawable();
                gradientDrawable.SetShape(ShapeType.Rectangle);
                gradientDrawable.SetColor(view.BorderColor.ToAndroid());
                gradientDrawable.SetStroke(0, view.BorderColor.ToAndroid());
                gradientDrawable.SetCornerRadius(
                     AndroidHelpers.DpToPixels(this.Context,
                         Convert.ToSingle(view.CornerRadius)));
                
                Control.SetBackground(gradientDrawable);

                Control.SetPadding(
                       (int)AndroidHelpers.DpToPixels(this.Context, Convert.ToSingle(20)),
                        Control.PaddingLeft,
                       (int)AndroidHelpers.DpToPixels(this.Context, Convert.ToSingle(20)),
                       Control.PaddingRight);

            }
        }
    }
}