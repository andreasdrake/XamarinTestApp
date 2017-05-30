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
        //protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        //{
        //    base.OnElementChanged(e);

        //    if (e.NewElement != null)
        //    {
        //        var view = (EntryWithCurvedCorners)Element;

        //        if (view.IsCurvedCornersEnabled)
        //        {
        //            // creating gradient drawable for the curved background
        //            var _gradientBackground = new GradientDrawable();
        //            _gradientBackground.SetShape(ShapeType.Rectangle);
        //            _gradientBackground.SetColor(view.BackgroundColor.ToAndroid());

        //            // Thickness of the stroke line
        //            _gradientBackground.SetStroke(view.BorderWidth, view.BorderColor.ToAndroid());

        //            // Radius for the curves
        //            _gradientBackground.SetCornerRadius(
        //                AndroidHelpers.DpToPixels(this.Context,
        //                    Convert.ToSingle(view.CornerRadius)));

        //            // set the background of the label
        //            Control.SetBackground(_gradientBackground);

        //        }

        //        // Set padding for the internal text from border
        //        Control.SetPadding(
        //               (int)AndroidHelpers.DpToPixels(this.Context, Convert.ToSingle(12)),
        //                Control.PaddingTop,
        //               (int)AndroidHelpers.DpToPixels(this.Context, Convert.ToSingle(12)),
        //               Control.PaddingBottom);
        //    }
        //}


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
                gradientDrawable.SetStroke(4, view.BorderColor.ToAndroid());
                gradientDrawable.SetCornerRadius(
                     AndroidHelpers.DpToPixels(this.Context,
                         Convert.ToSingle(view.CornerRadius)));

                //38.0f);

                Control.SetBackground(gradientDrawable);
            }
        }
    }
}