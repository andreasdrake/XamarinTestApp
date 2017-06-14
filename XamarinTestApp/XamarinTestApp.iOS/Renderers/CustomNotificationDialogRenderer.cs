using System.ComponentModel;
using CoreGraphics;

using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinTestApp.iOS.Renderers;
using XamarinTestApp.Controls;
using System;

[assembly: ExportRenderer(typeof(CustomNotifcationDialog), typeof(CustomNotificationDialogRenderer))]
namespace XamarinTestApp.iOS.Renderers
{
	public class CustomNotificationDialogRenderer: ViewRenderer<CustomNotifcationDialog, UIView>
	{
		protected override void OnElementChanged(ElementChangedEventArgs<CustomNotifcationDialog> e)
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
			//if (e.PropertyName == CustomNotifcationDialog.ActiveProperty.PropertyName)
			//{
			//	this.SetNeedsDisplay();
			//}
		}

        
        public override void Draw(CGRect rect)
        {
            DrawOLD(rect, Element.GradientBackgroundStartColor.ToUIColor(), Element.GradientBackgroundStopColor.ToUIColor(), Element.StrokeColor.ToUIColor());
        }

        private void DrawOLD(CGRect frame, UIColor backgroundStartGradientColor, UIColor backgroundStopGradientColor, UIColor strokeColor)
        {
            StyleKitName.DrawCanvas(frame, backgroundStartGradientColor, backgroundStopGradientColor, strokeColor);
            //OLD DOWN HERE

            // Color Declarations
            //var color2 = colorFill;

            ////// Bezier 2 Drawing
            //var bezier2Path = new UIBezierPath();
            //bezier2Path.MoveTo(new CGPoint(frame.GetMinX() + 0.95789f * frame.Width, frame.GetMinY() + 0.09893f * frame.Height));
            //bezier2Path.AddCurveToPoint(new CGPoint(frame.GetMinX() + 0.95789f * frame.Width, frame.GetMinY() + 0.73626f * frame.Height), new CGPoint(frame.GetMinX() + 0.95789f * frame.Width, frame.GetMinY() + 0.09890f * frame.Height), new CGPoint(frame.GetMinX() + 0.95789f * frame.Width, frame.GetMinY() + 0.73626f * frame.Height));
            //bezier2Path.AddLineTo(new CGPoint(frame.GetMinX() + 0.25538f * frame.Width, frame.GetMinY() + 0.73626f * frame.Height));
            //bezier2Path.AddCurveToPoint(new CGPoint(frame.GetMinX() + 0.17368f * frame.Width, frame.GetMinY() + 0.92308f * frame.Height), new CGPoint(frame.GetMinX() + 0.22263f * frame.Width, frame.GetMinY() + 0.81115f * frame.Height), new CGPoint(frame.GetMinX() + 0.17368f * frame.Width, frame.GetMinY() + 0.92308f * frame.Height));
            //bezier2Path.AddCurveToPoint(new CGPoint(frame.GetMinX() + 0.17368f * frame.Width, frame.GetMinY() + 0.73626f * frame.Height), new CGPoint(frame.GetMinX() + 0.17368f * frame.Width, frame.GetMinY() + 0.92308f * frame.Height), new CGPoint(frame.GetMinX() + 0.17368f * frame.Width, frame.GetMinY() + 0.81115f * frame.Height));
            //bezier2Path.AddLineTo(new CGPoint(frame.GetMinX() + 0.03684f * frame.Width, frame.GetMinY() + 0.73626f * frame.Height));
            //bezier2Path.AddLineTo(new CGPoint(frame.GetMinX() + 0.03684f * frame.Width, frame.GetMinY() + 0.09890f * frame.Height));
            //bezier2Path.AddLineTo(new CGPoint(frame.GetMinX() + 0.95789f * frame.Width, frame.GetMinY() + 0.09890f * frame.Height));
            //bezier2Path.AddLineTo(new CGPoint(frame.GetMinX() + 0.95789f * frame.Width, frame.GetMinY() + 0.09893f * frame.Height));
            //bezier2Path.ClosePath();
            //color2.SetFill();
            //bezier2Path.Fill();
            //UIColor.White.SetStroke();
            //bezier2Path.LineWidth = 2.0f;
            //bezier2Path.Stroke();
        }

        public void DrawCanvas(CGRect frame, UIColor gradientStartColor, UIColor gradientStopColor, UIColor strokeColor)
        {
            //// General Declarations
            var context = UIGraphics.GetCurrentContext();

            //// Colors
            var colorSpace = CGColorSpace.CreateDeviceRGB();
            var backgroundGradientColors = new CGColor[] { gradientStartColor.CGColor, gradientStopColor.CGColor };
            var backgroundGradientLocations = new nfloat[] { 0.0f, 1.0f };
            CGGradient backgroundGradient = new CGGradient(colorSpace, backgroundGradientColors, backgroundGradientLocations);

            //// Shadows

            var shadow = new NSShadow { ShadowColor = UIColor.DarkGray.ColorWithAlpha(0.15f), ShadowOffset = new CGSize(1.0f, 1.0f), ShadowBlurRadius = 4.0f };

            //// Subframes
            var frame2 = new CGRect(frame.GetMinX() + NMath.Floor((frame.Width - 21.0f) * 0.50000f + 0.5f), frame.GetMinY() + frame.Height - 13.0f, 21.0f, 12.0f);


            //// Bezier Drawing
            var bezierPath = new UIBezierPath();
            bezierPath.MoveTo(new CGPoint(frame.GetMaxX() - 3.0f, frame.GetMinY() + 7.0f));
            bezierPath.AddLineTo(new CGPoint(frame.GetMaxX() - 3.0f, frame.GetMaxY() - 16.0f));
            bezierPath.AddCurveToPoint(new CGPoint(frame.GetMaxX() - 8.0f, frame.GetMaxY() - 11.0f), new CGPoint(frame.GetMaxX() - 3.0f, frame.GetMaxY() - 13.24f), new CGPoint(frame.GetMaxX() - 5.24f, frame.GetMaxY() - 11.0f));
            bezierPath.AddLineTo(new CGPoint(frame2.GetMinX() + 18.97f, frame2.GetMaxY() - 10.0f));
            bezierPath.AddCurveToPoint(new CGPoint(frame2.GetMinX() + 10.47f, frame2.GetMaxY() - 1.5f), new CGPoint(frame2.GetMinX() + 14.72f, frame2.GetMaxY() - 5.75f), new CGPoint(frame2.GetMinX() + 10.47f, frame2.GetMaxY() - 1.5f));
            bezierPath.AddCurveToPoint(new CGPoint(frame2.GetMinX() + 1.97f, frame2.GetMaxY() - 10.0f), new CGPoint(frame2.GetMinX() + 10.47f, frame2.GetMaxY() - 1.5f), new CGPoint(frame2.GetMinX() + 6.22f, frame2.GetMaxY() - 5.75f));
            bezierPath.AddLineTo(new CGPoint(frame.GetMinX() + 7.0f, frame.GetMaxY() - 11.0f));
            bezierPath.AddCurveToPoint(new CGPoint(frame.GetMinX() + 2.0f, frame.GetMaxY() - 16.0f), new CGPoint(frame.GetMinX() + 4.24f, frame.GetMaxY() - 11.0f), new CGPoint(frame.GetMinX() + 2.0f, frame.GetMaxY() - 13.24f));
            bezierPath.AddLineTo(new CGPoint(frame.GetMinX() + 2.0f, frame.GetMinY() + 7.0f));
            bezierPath.AddCurveToPoint(new CGPoint(frame.GetMinX() + 7.0f, frame.GetMinY() + 2.0f), new CGPoint(frame.GetMinX() + 2.0f, frame.GetMinY() + 4.24f), new CGPoint(frame.GetMinX() + 4.24f, frame.GetMinY() + 2.0f));
            bezierPath.AddLineTo(new CGPoint(frame.GetMaxX() - 8.0f, frame.GetMinY() + 2.0f));
            bezierPath.AddCurveToPoint(new CGPoint(frame.GetMaxX() - 3.0f, frame.GetMinY() + 7.0f), new CGPoint(frame.GetMaxX() - 5.24f, frame.GetMinY() + 2.0f), new CGPoint(frame.GetMaxX() - 3.0f, frame.GetMinY() + 4.24f));
            bezierPath.ClosePath();
            context.SaveState();
            context.SetShadow(shadow.ShadowOffset, shadow.ShadowBlurRadius, shadow.ShadowColor.CGColor);
            context.BeginTransparencyLayer(null);
            bezierPath.AddClip();
            var bezierBounds = bezierPath.CGPath.PathBoundingBox;
            context.DrawLinearGradient(backgroundGradient,
                new CGPoint(bezierBounds.GetMidX(), bezierBounds.GetMinY()),
                new CGPoint(bezierBounds.GetMidX(), bezierBounds.GetMaxY()),
                0);
            context.EndTransparencyLayer();
            context.RestoreState();

            strokeColor.SetStroke();
            bezierPath.LineWidth = 1.0f;
            bezierPath.Stroke();
        }
    }
}
