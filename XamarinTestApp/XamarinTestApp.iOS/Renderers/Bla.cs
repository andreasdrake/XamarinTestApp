using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using CoreGraphics;

namespace XamarinTestApp.iOS.Renderers
{
    public class Bla : NSObject
    {
        public static void DrawCanvas1(CGRect frame, nfloat percent)
        {
            //// General Declarations
            var colorSpace = CGColorSpace.CreateDeviceRGB();
            var context = UIGraphics.GetCurrentContext();

            //// Color Declarations
            var color3 = UIColor.FromRGBA(0.652f, 0.800f, 0.320f, 1.000f);
            var color4 = UIColor.FromRGBA(0.073f, 0.891f, 0.004f, 1.000f);

            //// Gradient Declarations
            var gradientColors = new CGColor[] { color3.CGColor, color4.CGColor };
            var gradientLocations = new nfloat[] { 0.0f, 1.0f };
            var gradient = new CGGradient(colorSpace, gradientColors, gradientLocations);


            //// Subframes
            var group = new CGRect(frame.GetMinX() + 1.0f, frame.GetMinY() + 1.0f, frame.Width - 2.0f, frame.Height - 2.0f);


            //// Group
            {
                context.SaveState();
                context.BeginTransparencyLayer();


                //// Oval Drawing
                var ovalRect = new CGRect(group.GetMinX() + NMath.Floor(group.Width * 0.00000f + 0.5f), group.GetMinY() + NMath.Floor(group.Height * 0.00000f + 0.5f), NMath.Floor(group.Width * 1.00000f + 0.5f) - NMath.Floor(group.Width * 0.00000f + 0.5f), NMath.Floor(group.Height * 1.00000f + 0.5f) - NMath.Floor(group.Height * 0.00000f + 0.5f));
                var ovalPath = UIBezierPath.FromOval(ovalRect);
                context.SaveState();
                ovalPath.AddClip();
                context.DrawLinearGradient(gradient,
                    new CGPoint(ovalRect.GetMidX(), ovalRect.GetMinY()),
                    new CGPoint(ovalRect.GetMidX(), ovalRect.GetMaxY()),
                    0);
                context.RestoreState();


                //// Rectangle Drawing
                context.SaveState();
                context.SetBlendMode(CGBlendMode.DestinationIn);
                context.BeginTransparencyLayer();

                var rectanglePath = UIBezierPath.FromRect(new CGRect(group.GetMinX() + NMath.Floor(group.Width * 0.00000f + 0.5f), 
                    group.GetMinY() + NMath.Floor(group.Height * 0.21053f + 0.5f), NMath.Floor(group.Width * 1.00000f + 0.5f) - NMath.Floor(group.Width * 0.00000f + 0.5f),
                    NMath.Floor(group.Height * 1.00000f + 0.5f) - NMath.Floor(group.Height * percent + 0.5f)));
                UIColor.Gray.SetFill();
                rectanglePath.Fill();

                context.EndTransparencyLayer();
                context.RestoreState();


                context.EndTransparencyLayer();
                context.RestoreState();
            }
        }


        public static void DrawCanvas1(CGRect targetFrame, ResizingBehavior resizing, nfloat frameW, nfloat frameH, nfloat percent)
        {
            //// General Declarations
            var colorSpace = CGColorSpace.CreateDeviceRGB();
            var context = UIGraphics.GetCurrentContext();

            //// Resize to Target Frame
            context.SaveState();
            var resizedFrame = ResizingBehaviorApply2(resizing, new CGRect(0, 0, frameW, frameH), targetFrame);
            context.TranslateCTM(resizedFrame.X, resizedFrame.Y);
            context.ScaleCTM(resizedFrame.Width / frameW, resizedFrame.Height / frameH);


            //// Color Declarations
            var color3 = UIColor.FromRGBA(0.652f, 0.800f, 0.320f, 1.000f);
            var color4 = UIColor.FromRGBA(0.073f, 0.891f, 0.004f, 1.000f);

            //// Gradient Declarations
            var gradientColors = new CGColor[] { color3.CGColor, color4.CGColor };
            var gradientLocations = new nfloat[] { 0.0f, 1.0f };
            var gradient = new CGGradient(colorSpace, gradientColors, gradientLocations);

            //// Frames
            var frame = new CGRect(0f, 0f, frameW, frameH);

            //// Subframes
            var group = new CGRect(frame.GetMinX() + 1.0f, frame.GetMinY() + 1.0f, frame.Width - 1.0f, frame.Height - 1.0f);


            //// Group
            {
                context.SaveState();
                context.BeginTransparencyLayer();


                //// Oval Drawing
                var ovalRect = new CGRect(group.GetMinX() + NMath.Floor(group.Width * 0.00000f + 0.5f), group.GetMinY() + NMath.Floor(group.Height * 0.00000f + 0.5f), NMath.Floor(group.Width * 1.00000f + 0.5f) - NMath.Floor(group.Width * 0.00000f + 0.5f), NMath.Floor(group.Height * 1.00000f + 0.5f) - NMath.Floor(group.Height * 0.00000f + 0.5f));
                var ovalPath = UIBezierPath.FromOval(ovalRect);
                context.SaveState();
                ovalPath.AddClip();
                context.DrawLinearGradient(gradient,
                    new CGPoint(ovalRect.GetMidX(), ovalRect.GetMinY()),
                    new CGPoint(ovalRect.GetMidX(), ovalRect.GetMaxY()),
                    0);
                context.RestoreState();


                //// Rectangle Drawing
                context.SaveState();
                context.SetBlendMode(CGBlendMode.DestinationIn);
                context.BeginTransparencyLayer();

                var rectanglePath = UIBezierPath.FromRect(new CGRect(group.GetMinX() + NMath.Floor(group.Width * 0.00000f + 0.5f),
                    group.GetMinY() + NMath.Floor(group.Height * 0.52381f + 0.5f),
                    NMath.Floor(group.Width * 1.00000f + 0.5f) - NMath.Floor(group.Width * 0.00000f + 0.5f),
                    NMath.Floor(group.Height * 1.00000f + 0.5f) - NMath.Floor(group.Height * percent + 0.5f)));
                UIColor.Gray.SetFill();
                rectanglePath.Fill();

                context.EndTransparencyLayer();
                context.RestoreState();


                context.EndTransparencyLayer();
                context.RestoreState();
            }

            context.RestoreState();

        }




        public enum ResizingBehavior
        {
            AspectFit, // The content is proportionally resized to fit into the target rectangle.
            AspectFill, // The content is proportionally resized to completely fill the target rectangle.
            Stretch, // The content is stretched to match the entire target rectangle.
            Center, // The content is centered in the target rectangle, but it is NOT resized.
        };

        public static CGRect ResizingBehaviorApply2(ResizingBehavior behavior, CGRect rect, CGRect target)
        {
            if (rect == target || target == new CGRect(0, 0, 0, 0))
                return rect;

            var scales = new CGSize(0, 0);
            scales.Width = NMath.Abs(target.Width / rect.Width);
            scales.Height = NMath.Abs(target.Height / rect.Height);

            switch (behavior)
            {
                case ResizingBehavior.AspectFit:
                    {
                        scales.Width = NMath.Min(scales.Width, scales.Height);
                        scales.Height = scales.Width;
                        break;
                    }
                case ResizingBehavior.AspectFill:
                    {
                        scales.Width = NMath.Max(scales.Width, scales.Height);
                        scales.Height = scales.Width;
                        break;
                    }
                case ResizingBehavior.Stretch:
                    break;
                case ResizingBehavior.Center:
                    {
                        scales.Width = 1;
                        scales.Height = 1;
                        break;
                    }
            }

            var result = rect.Standardize();
            result.Width *= scales.Width;
            result.Height *= scales.Height;
            result.X = target.X + (target.Width - result.Width) / 2;
            result.Y = target.Y + (target.Height - result.Height) / 2;
            return result;
        }
    }
}
