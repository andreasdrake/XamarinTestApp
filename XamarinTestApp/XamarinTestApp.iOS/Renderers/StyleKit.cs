
using System;
using Foundation;
using UIKit;
using CoreGraphics;

namespace XamarinTestApp.iOS.Renderers
{
    [Register("StyleKitName")]
    public class StyleKitName : NSObject
    {
        public static void DrawCanvas(CGRect frame, UIColor gradientStartColor, UIColor gradientStopColor, UIColor strokeColor)
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

/* [Register("StyleKitName")]
    public class StyleKitName : NSObject
    {

        //// Initialization

        static StyleKitName()
        {
            var colorSpace = CGColorSpace.CreateDeviceRGB();

            // Colors Initialization
            GradientColorStart = UIColor.FromRGBA(1.000f, 1.000f, 1.000f, 1.000f);
            GradientColorStop = UIColor.FromRGBA(0.968f, 0.984f, 1.000f, 1.000f);

            // Gradients Initialization
            var backgroundGradientColors = new CGColor[] { StyleKitName.GradientColorStart.CGColor, StyleKitName.GradientColorStop.CGColor };
            var backgroundGradientLocations = new nfloat[] { 0.0f, 1.0f };
            BackgroundGradient = new CGGradient(colorSpace, backgroundGradientColors, backgroundGradientLocations);

            // Shadows Initialization
            Shadow = new NSShadow { ShadowColor = UIColor.DarkGray.ColorWithAlpha(0.15f), ShadowOffset = new CGSize(1.0f, 1.0f), ShadowBlurRadius = 4.0f };

        }

        //// Colors

        public static UIColor GradientColorStart { get; private set; }
        public static UIColor GradientColorStop { get; private set; }

        //// Gradients

        public static CGGradient BackgroundGradient { get; private set; }

        //// Shadows

        public static NSShadow Shadow { get; private set; }

        //// Drawing Methods

        public static void DrawCanvas1(CGRect frame)
        {
            //// General Declarations
            var context = UIGraphics.GetCurrentContext();

            //// Color Declarations
            var strokeColor = UIColor.FromRGBA(0.000f, 0.624f, 0.000f, 1.000f);


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
            context.SetShadow(StyleKitName.Shadow.ShadowOffset, StyleKitName.Shadow.ShadowBlurRadius, StyleKitName.Shadow.ShadowColor.CGColor);
            context.BeginTransparencyLayer(null);
            bezierPath.AddClip();
            var bezierBounds = bezierPath.CGPath.PathBoundingBox;
            context.DrawLinearGradient(StyleKitName.BackgroundGradient,
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
*/
