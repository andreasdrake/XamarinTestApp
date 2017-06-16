using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using XamarinTestApp.Controls;
using XamarinTestApp.Droid.Renderers;
using CoreGraphics;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(CircleControl), typeof(CircleControlRenderer))]
namespace XamarinTestApp.Droid.Renderers
{
    public class CircleControlRenderer : ViewRenderer<CircleControl, UIView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<CircleControl> e)
        {
            base.OnElementChanged(e);
            if (Control == null)
            {
                var dialogView = new UIView();
                SetNativeControl(dialogView);
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            this.SetNeedsDisplay();
        }
        public override void Draw(CGRect frame)
        {
            //// General Declarations
            var colorSpace = CGColorSpace.CreateDeviceRGB();
            var context = UIGraphics.GetCurrentContext();

            //// Color Declarations
            var color1 = UIColor.FromRGBA(0.355f, 1.000f, 0.355f, 1.000f);
            var color2 = UIColor.FromRGBA(0.000f, 0.624f, 0.000f, 1.000f);

            //// Gradient Declarations
            var backgroundGradientColorColors = new CGColor[] { color1.CGColor, color2.CGColor };
            var backgroundGradientColorLocations = new nfloat[] { 0.0f, 1.0f };
            var backgroundGradientColor = new CGGradient(colorSpace, backgroundGradientColorColors, backgroundGradientColorLocations);

            //// Oval Drawing
            var ovalRect = new CGRect(frame.GetMinX() + NMath.Floor((frame.Width - 50.0f) * 0.50000f + 0.5f), frame.GetMinY() + NMath.Floor((frame.Height - 50.0f) * 0.50000f + 0.5f), 50.0f, 50.0f);
            var ovalPath = UIBezierPath.FromOval(ovalRect);
            context.SaveState();
            ovalPath.AddClip();
            context.DrawLinearGradient(backgroundGradientColor,
                new CGPoint(ovalRect.GetMidX(), ovalRect.GetMinY()),
                new CGPoint(ovalRect.GetMidX(), ovalRect.GetMaxY()),
                0);
            context.RestoreState();
        }
    }
}