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
using XamarinTestApp.iOS.Renderers;

[assembly: ExportRenderer(typeof(GradientCircleProgress), typeof(GradientCircleProgressRenderer))]
namespace XamarinTestApp.Droid.Renderers
{
    public class GradientCircleProgressRenderer : ViewRenderer<GradientCircleProgress, UIView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<GradientCircleProgress> e)
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
        private void DrawCanvas2(CGRect frame)
        {
            //// General Declarations
            var colorSpace = CGColorSpace.CreateDeviceRGB();
            var context = UIGraphics.GetCurrentContext();

            //// Color Declarations
            var color2 = UIColor.FromRGBA(1.000f, 0.420f, 0.420f, 1.000f);
            var color3 = UIColor.FromRGBA(0.652f, 0.800f, 0.320f, 1.000f);
            var color4 = UIColor.FromRGBA(0.073f, 0.891f, 0.004f, 1.000f);

            //// Gradient Declarations
            var gradientColors = new CGColor[] { color3.CGColor, color4.CGColor };
            var gradientLocations = new nfloat[] { 0.0f, 1.0f };
            var gradient = new CGGradient(colorSpace, gradientColors, gradientLocations);


            //// Subframes
            var group = new CGRect(frame.GetMinX() + 2.0f, frame.GetMinY() + 2.0f, frame.Width - 4.0f, frame.Height - 4.0f);


            //// Group
            {
                context.SaveState();
                context.BeginTransparencyLayer();


                //// Progress Drawing
                var progressRect = new CGRect(group.GetMinX() + NMath.Floor(group.Width * 0.00000f + 0.5f), group.GetMinY() + NMath.Floor(group.Height * 0.00000f + 0.5f), NMath.Floor(group.Width * 1.00000f + 0.5f) - NMath.Floor(group.Width * 0.00000f + 0.5f), NMath.Floor(group.Height * 1.00000f + 0.5f) - NMath.Floor(group.Height * 0.00000f + 0.5f));
                var progressPath = UIBezierPath.FromOval(progressRect);
                context.SaveState();
                progressPath.AddClip();
                context.DrawLinearGradient(gradient,
                    new CGPoint(progressRect.GetMidX(), progressRect.GetMinY()),
                    new CGPoint(progressRect.GetMidX(), progressRect.GetMaxY()),
                    0);
                context.RestoreState();


                //// Mask Drawing
                context.SaveState();
                context.SetBlendMode(CGBlendMode.DestinationIn);
                context.BeginTransparencyLayer();

                var maskPath = UIBezierPath.FromRect(
                    new CGRect(group.GetMinX() + NMath.Floor(group.Width * 0.00000f + 0.5f), 
                    group.GetMinY() + NMath.Floor(group.Height * 0.25000f + 0.5f), 
                    NMath.Floor(group.Width * 1.00000f + 0.5f) - NMath.Floor(group.Width * 0.00000f + 0.5f), 
                    NMath.Floor(group.Height * 1.00000f + 0.5f) - NMath.Floor(group.Height * 0.25000f + 0.5f)));
                color2.SetFill();
                maskPath.Fill();

                context.EndTransparencyLayer();
                context.RestoreState();


                context.EndTransparencyLayer();
                context.RestoreState();
            }
        }



        private void DrawCanvas1(CGRect frame, nfloat yvalue)
        {
            //// General Declarations
            var colorSpace = CGColorSpace.CreateDeviceRGB();
            var context = UIGraphics.GetCurrentContext();

            //// Color Declarations
            var color = UIColor.FromRGBA(0.320f, 0.800f, 0.413f, 1.000f);
            var color3 = UIColor.FromRGBA(0.652f, 0.800f, 0.320f, 1.000f);
            var color4 = UIColor.FromRGBA(0.073f, 0.891f, 0.004f, 1.000f);

            //// Gradient Declarations
            var gradientColors = new CGColor[] { color3.CGColor, color4.CGColor };
            var gradientLocations = new nfloat[] { 0.0f, 1.0f };
            var gradient = new CGGradient(colorSpace, gradientColors, gradientLocations);

            //// Group
            {
                context.SaveState();
                context.BeginTransparencyLayer();


                //// Oval Drawing
                var ovalPath = UIBezierPath.FromOval(new CGRect(5.0f, 5.0f, 40.0f, 40.0f));
                color.SetFill();
                ovalPath.Fill();


                //// Rectangle Drawing
                context.SaveState();
                context.SetBlendMode(CGBlendMode.SourceIn);
                context.BeginTransparencyLayer();

                var rectangleRect = new CGRect(5.0f, yvalue, 40.0f, 40.0f);
                var rectanglePath = UIBezierPath.FromRect(rectangleRect);
                context.SaveState();
                rectanglePath.AddClip();
                context.DrawLinearGradient(gradient,
                    new CGPoint(rectangleRect.GetMidX(), rectangleRect.GetMinY()),
                    new CGPoint(rectangleRect.GetMidX(), rectangleRect.GetMaxY()),
                    0);
                context.RestoreState();

                context.EndTransparencyLayer();
                context.RestoreState();


                context.EndTransparencyLayer();
                context.RestoreState();
            }
        }


        public override void Draw(CGRect frame)
        {
            Bla.DrawCanvasNEW(frame);
            //Bla.DrawCanvas1(frame, 0.53f);
            return;
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
            var ovalRect = new CGRect(frame.GetMinX() + 4.0f, frame.GetMinY() + 4.0f, frame.Width - 8.0f, frame.Height - 8.0f);
            var ovalPath = UIBezierPath.FromOval(ovalRect);
            context.SaveState();
            ovalPath.AddClip();
            context.DrawLinearGradient(backgroundGradientColor,
                new CGPoint(ovalRect.GetMidX(), ovalRect.GetMinY()),
                new CGPoint(ovalRect.GetMidX(), ovalRect.GetMaxY()),
                0);
            context.RestoreState();
            UIColor.White.SetStroke();
            ovalPath.LineWidth = 1.0f;
            ovalPath.Stroke();

        }

    }
}