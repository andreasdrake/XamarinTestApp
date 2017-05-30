using System;
using Android.Content;
using Xamarin.Forms;
using XamarinTestApp.Controls;
using Xamarin.Forms.Platform.Android;
using XamarinTestApp.Droid.Renderers;
using Android.Graphics.Drawables;
using Android.Util;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace XamarinTestApp.Droid.Renderers
{
    public class CustomEntryRenderer : EntryRenderer
    {
        private GradientDrawable _gradientBackground;

        #region Parent override

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement != null || Element == null)
            {
                return;
            }
            Control?.SetBackgroundColor(Android.Graphics.Color.Transparent);

            var view = (CustomEntry)Element;
            if (view == null) return;

            _gradientBackground = new GradientDrawable();
            _gradientBackground.SetShape(ShapeType.Rectangle);
            _gradientBackground.SetColor(view.BackgroundColor.ToAndroid());
            _gradientBackground.SetStroke(4, view.BackgroundColor.ToAndroid());


            _gradientBackground.SetCornerRadius(
               DpToPixels(this.Context,
               Convert.ToSingle(view.BorderRadius)));

            Control.SetBackground(_gradientBackground);
            //Control.BorderStyle = UIKit.UITextBorderStyle.None;
            //UpdateBorderWidth();
            //UpdateBorderColor();
            //UpdateBorderRadius();
            //UpdateLeftPadding();
            //UpdateRightPadding();
            //Control.ClipToOutline = true;
            //Control.ClipsToBounds = true;
        }

        /// <summary>
        /// Device Independent Pixels to Actual Pixles conversion
        /// </summary>
        /// <param name="context"></param>
        /// <param name="valueInDp"></param>
        /// <returns></returns>
        public static float DpToPixels(Context context, float valueInDp)
        {
            DisplayMetrics metrics = context.Resources.DisplayMetrics;
            return TypedValue.ApplyDimension(ComplexUnitType.Dip, valueInDp, metrics);
        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (this.Element == null)
                return;
            if (e.PropertyName == CustomEntry.BorderWidthProperty.PropertyName)
            {
                UpdateBorderWidth();
            }
            else if (e.PropertyName == CustomEntry.BorderColorProperty.PropertyName)
            {
                UpdateBorderColor();
            }
            else if (e.PropertyName == CustomEntry.BorderRadiusProperty.PropertyName)
            {
                UpdateBorderRadius();
            }
            else if (e.PropertyName == CustomEntry.LeftPaddingProperty.PropertyName)
            {
                UpdateLeftPadding();
            }
            else if (e.PropertyName == CustomEntry.RightPaddingProperty.PropertyName)
            {
                UpdateRightPadding();
            }
        }

        #endregion

        #region Utility methods

        private void UpdateBorderWidth()
        {
            var entryEx = this.Element as CustomEntry;
            //Control.Layer.BorderWidth = entryEx.BorderWidth;
        }

        private void UpdateBorderColor()
        {
            //var entryEx = this.Element as CustomEntry;
            //Control.Layer.BorderColor = entryEx.BorderColor.ToUIColor().CGColor;
        }

        private void UpdateBorderRadius()
        {
            //var entryEx = this.Element as CustomEntry;
            //Control.Layer.CornerRadius = (nfloat)entryEx.BorderRadius;
        }

        private void UpdateLeftPadding()
        {
            //var entryEx = this.Element as CustomEntry;
            //var leftPaddingView = new UIKit.UIView(new CGRect(0, 0, entryEx.LeftPadding, 0));
            //Control.LeftView = leftPaddingView;
            //Control.LeftViewMode = UITextFieldViewMode.Always;
        }

        private void UpdateRightPadding()
        {
            //var entryEx = this.Element as CustomEntry;
            //var rightPaddingView = new UIView(new CGRect(0, 0, entryEx.RightPadding, 0));
            //Control.RightView = rightPaddingView;
            //Control.RightViewMode = UITextFieldViewMode.Always;
        }

        #endregion


        //protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        //{
        //    base.OnElementChanged(e);

        //    if (Control != null)
        //    {
        //        // do whatever you want to the UITextField here!
        //        Control.BackgroundColor = UIKit.UIColor.FromRGB(0, 159, 0);
        //        Control.Alpha = (nfloat)0.8;
        //        Control.TextColor = UIKit.UIColor.White;
        //    }
        //}
    }
}
