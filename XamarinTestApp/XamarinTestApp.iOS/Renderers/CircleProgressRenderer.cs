using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using XamarinTestApp.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinTestApp.Controls;
using System.ComponentModel;
using CoreGraphics;

[assembly: ExportRenderer(typeof(CircleProgress), typeof(CircleProgressRenderer))]
namespace XamarinTestApp.iOS.Renderers
{
    public class CircleProgressRenderer : ViewRenderer<CircleProgress, UIView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<CircleProgress> e)
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
        public override void Draw(CGRect rect)
        {
            DrawActivity(rect, ResizingBehavior.AspectFit, 0.163f, 0.327f,0.761f);
        }

        public void DrawActivity(CGRect targetFrame, ResizingBehavior resizing, nfloat moveLevel, nfloat exersizeLevel, nfloat standLevel)
        {
            //// General Declarations
            var colorSpace = CGColorSpace.CreateDeviceRGB();
            var context = UIGraphics.GetCurrentContext();

            //// Resize to Target Frame
            context.SaveState();
            var resizedFrame = ResizingBehaviorApply(resizing, new CGRect(0, 0, 156.0f, 195.0f), targetFrame);
            context.TranslateCTM(resizedFrame.X, resizedFrame.Y);
            context.ScaleCTM(resizedFrame.Width / 156.0f, resizedFrame.Height / 195.0f);


            //// Color Declarations
            var move1 = UIColor.FromRGBA(0.976f, 0.000f, 0.055f, 1.000f);
            var move2 = UIColor.FromRGBA(1.000f, 0.000f, 0.674f, 1.000f);
            var exercise1 = UIColor.FromRGBA(0.513f, 0.927f, 0.000f, 1.000f);
            var exercise2 = UIColor.FromRGBA(0.706f, 1.000f, 0.000f, 1.000f);
            var stand1 = UIColor.FromRGBA(0.000f, 0.851f, 0.830f, 1.000f);
            var stand2 = UIColor.FromRGBA(0.000f, 1.000f, 0.904f, 1.000f);

            //// Gradient Declarations
            var moveGradientColors = new CGColor[] { move1.CGColor, move2.CGColor };
            var moveGradientLocations = new nfloat[] { 0.0f, 1.0f };
            var moveGradient = new CGGradient(colorSpace, moveGradientColors, moveGradientLocations);
            var exerciseGradientColors = new CGColor[] { exercise1.CGColor, exercise2.CGColor };
            var exerciseGradientLocations = new nfloat[] { 0.0f, 1.0f };
            var exerciseGradient = new CGGradient(colorSpace, exerciseGradientColors, exerciseGradientLocations);
            var standGradientColors = new CGColor[] { stand1.CGColor, stand2.CGColor };
            var standGradientLocations = new nfloat[] { 0.0f, 1.0f };
            var standGradient = new CGGradient(colorSpace, standGradientColors, standGradientLocations);

            //// Variable Declarations
            var moveDash = moveLevel * 408.0f + 6.0f;
            var exersizeDash = exersizeLevel * 295.0f + 6.0f;
            var standDash = standLevel * 182.0f + 6.0f;

            //// ColorGroup
            {
                //// MaskOval Drawing
                var maskOvalPath = UIBezierPath.FromOval(new CGRect(4.0f, 26.0f, 148.0f, 148.0f));
                context.SaveState();
                maskOvalPath.AddClip();
                context.DrawLinearGradient(moveGradient, new CGPoint(78.0f, 26.0f), new CGPoint(78.0f, 174.0f), 0);
                context.RestoreState();


                //// ExerciseOval Drawing
                var exerciseOvalPath = UIBezierPath.FromOval(new CGRect(22.0f, 44.0f, 112.0f, 112.0f));
                context.SaveState();
                exerciseOvalPath.AddClip();
                context.DrawLinearGradient(exerciseGradient, new CGPoint(78.0f, 44.0f), new CGPoint(78.0f, 156.0f), 0);
                context.RestoreState();
                UIColor.Black.SetStroke();
                exerciseOvalPath.LineWidth = 1.0f;
                exerciseOvalPath.Stroke();


                //// StandOval Drawing
                var standOvalPath = UIBezierPath.FromOval(new CGRect(40.0f, 62.0f, 76.0f, 76.0f));
                context.SaveState();
                standOvalPath.AddClip();
                context.DrawLinearGradient(standGradient, new CGPoint(78.0f, 62.0f), new CGPoint(78.0f, 138.0f), 0);
                context.RestoreState();
                UIColor.Black.SetStroke();
                standOvalPath.LineWidth = 1.0f;
                standOvalPath.Stroke();
            }


            //// MaskGroup
            {
                context.SaveState();
                context.TranslateCTM(78.0f, 100.0f);
                context.RotateCTM(90.0f * NMath.PI / 180.0f);

                context.SetBlendMode(CGBlendMode.DestinationIn);
                context.BeginTransparencyLayer();


                //// MoveMask Drawing
                var moveMaskPath = new UIBezierPath();
                moveMaskPath.MoveTo(new CGPoint(-65.0f, 0.0f));
                moveMaskPath.AddCurveToPoint(new CGPoint(0.0f, -65.0f), new CGPoint(-65.0f, -35.9f), new CGPoint(-35.9f, -65.0f));
                moveMaskPath.AddCurveToPoint(new CGPoint(65.0f, 0.0f), new CGPoint(35.9f, -65.0f), new CGPoint(65.0f, -35.9f));
                moveMaskPath.AddCurveToPoint(new CGPoint(-0.0f, 65.0f), new CGPoint(65.0f, 35.9f), new CGPoint(35.9f, 65.0f));
                moveMaskPath.AddCurveToPoint(new CGPoint(-65.0f, 0.0f), new CGPoint(-35.9f, 65.0f), new CGPoint(-65.0f, 35.9f));
                moveMaskPath.ClosePath();
                UIColor.Black.SetStroke();
                moveMaskPath.LineWidth = 17.0f;
                moveMaskPath.LineCapStyle = CGLineCap.Round;
                context.SaveState();
                var moveMaskPattern = new nfloat[] { moveDash, 408.0f };
                context.SetLineDash(1.0f, moveMaskPattern);
                moveMaskPath.Stroke();
                context.RestoreState();


                //// ExerciseMask Drawing
                var exerciseMaskPath = new UIBezierPath();
                exerciseMaskPath.MoveTo(new CGPoint(-47.0f, 0.0f));
                exerciseMaskPath.AddCurveToPoint(new CGPoint(0.0f, -47.0f), new CGPoint(-47.0f, -25.96f), new CGPoint(-25.96f, -47.0f));
                exerciseMaskPath.AddCurveToPoint(new CGPoint(47.0f, 0.0f), new CGPoint(25.96f, -47.0f), new CGPoint(47.0f, -25.96f));
                exerciseMaskPath.AddCurveToPoint(new CGPoint(-0.0f, 47.0f), new CGPoint(47.0f, 25.96f), new CGPoint(25.96f, 47.0f));
                exerciseMaskPath.AddCurveToPoint(new CGPoint(-47.0f, 0.0f), new CGPoint(-25.96f, 47.0f), new CGPoint(-47.0f, 25.96f));
                exerciseMaskPath.ClosePath();
                UIColor.Black.SetStroke();
                exerciseMaskPath.LineWidth = 17.0f;
                exerciseMaskPath.LineCapStyle = CGLineCap.Round;
                context.SaveState();
                var exerciseMaskPattern = new nfloat[] { exersizeDash, 295.0f };
                context.SetLineDash(1.0f, exerciseMaskPattern);
                exerciseMaskPath.Stroke();
                context.RestoreState();


                //// StandMask Drawing
                var standMaskPath = new UIBezierPath();
                standMaskPath.MoveTo(new CGPoint(-29.0f, 0.0f));
                standMaskPath.AddCurveToPoint(new CGPoint(0.0f, -29.0f), new CGPoint(-29.0f, -16.02f), new CGPoint(-16.02f, -29.0f));
                standMaskPath.AddCurveToPoint(new CGPoint(29.0f, 0.0f), new CGPoint(16.02f, -29.0f), new CGPoint(29.0f, -16.02f));
                standMaskPath.AddCurveToPoint(new CGPoint(-0.0f, 29.0f), new CGPoint(29.0f, 16.02f), new CGPoint(16.02f, 29.0f));
                standMaskPath.AddCurveToPoint(new CGPoint(-29.0f, 0.0f), new CGPoint(-16.02f, 29.0f), new CGPoint(-29.0f, 16.02f));
                standMaskPath.ClosePath();
                UIColor.Black.SetStroke();
                standMaskPath.LineWidth = 17.0f;
                standMaskPath.LineCapStyle = CGLineCap.Round;
                context.SaveState();
                var standMaskPattern = new nfloat[] { standDash, 182.0f };
                context.SetLineDash(1.0f, standMaskPattern);
                standMaskPath.Stroke();
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

        public CGRect ResizingBehaviorApply(ResizingBehavior behavior, CGRect rect, CGRect target)
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


/*
 
using System;
using Foundation;
using UIKit;
using CoreGraphics;

namespace Activity
{
    [Register("StyleKitName")]
    public class StyleKitName : NSObject
    {

        //// Initialization

        static StyleKitName()
        {
        }

        //// Drawing Methods

        public static void DrawActivity(nfloat moveLevel, nfloat exersizeLevel, nfloat standLevel)
        {
            DrawActivity(new CGRect(0.0f, 0.0f, 156.0f, 195.0f), ResizingBehavior.AspectFit, moveLevel, exersizeLevel, standLevel);
        }

        public static void DrawActivity(CGRect targetFrame, ResizingBehavior resizing, nfloat moveLevel, nfloat exersizeLevel, nfloat standLevel)
        {
            //// General Declarations
            var colorSpace = CGColorSpace.CreateDeviceRGB();
            var context = UIGraphics.GetCurrentContext();
            
            //// Resize to Target Frame
            context.SaveState();
            var resizedFrame = ResizingBehaviorApply(resizing, new CGRect(0, 0, 156.0f, 195.0f), targetFrame);
            context.TranslateCTM(resizedFrame.X, resizedFrame.Y);
            context.ScaleCTM(resizedFrame.Width / 156.0f, resizedFrame.Height / 195.0f);


            //// Color Declarations
            var move1 = UIColor.FromRGBA(0.976f, 0.000f, 0.055f, 1.000f);
            var move2 = UIColor.FromRGBA(1.000f, 0.000f, 0.674f, 1.000f);
            var exercise1 = UIColor.FromRGBA(0.513f, 0.927f, 0.000f, 1.000f);
            var exercise2 = UIColor.FromRGBA(0.706f, 1.000f, 0.000f, 1.000f);
            var stand1 = UIColor.FromRGBA(0.000f, 0.851f, 0.830f, 1.000f);
            var stand2 = UIColor.FromRGBA(0.000f, 1.000f, 0.904f, 1.000f);

            //// Gradient Declarations
            var moveGradientColors = new CGColor[] { move1.CGColor, move2.CGColor };
            var moveGradientLocations = new nfloat[] { 0.0f, 1.0f };
            var moveGradient = new CGGradient(colorSpace, moveGradientColors, moveGradientLocations);
            var exerciseGradientColors = new CGColor[] { exercise1.CGColor, exercise2.CGColor };
            var exerciseGradientLocations = new nfloat[] { 0.0f, 1.0f };
            var exerciseGradient = new CGGradient(colorSpace, exerciseGradientColors, exerciseGradientLocations);
            var standGradientColors = new CGColor[] { stand1.CGColor, stand2.CGColor };
            var standGradientLocations = new nfloat[] { 0.0f, 1.0f };
            var standGradient = new CGGradient(colorSpace, standGradientColors, standGradientLocations);

            //// Variable Declarations
            var moveDash = moveLevel * 408.0f + 6.0f;
            var exersizeDash = exersizeLevel * 295.0f + 6.0f;
            var standDash = standLevel * 182.0f + 6.0f;

            //// ColorGroup
            {
                //// MaskOval Drawing
                var maskOvalPath = UIBezierPath.FromOval(new CGRect(4.0f, 26.0f, 148.0f, 148.0f));
                context.SaveState();
                maskOvalPath.AddClip();
                context.DrawLinearGradient(moveGradient, new CGPoint(78.0f, 26.0f), new CGPoint(78.0f, 174.0f), 0);
                context.RestoreState();


                //// ExerciseOval Drawing
                var exerciseOvalPath = UIBezierPath.FromOval(new CGRect(22.0f, 44.0f, 112.0f, 112.0f));
                context.SaveState();
                exerciseOvalPath.AddClip();
                context.DrawLinearGradient(exerciseGradient, new CGPoint(78.0f, 44.0f), new CGPoint(78.0f, 156.0f), 0);
                context.RestoreState();
                UIColor.Black.SetStroke();
                exerciseOvalPath.LineWidth = 1.0f;
                exerciseOvalPath.Stroke();


                //// StandOval Drawing
                var standOvalPath = UIBezierPath.FromOval(new CGRect(40.0f, 62.0f, 76.0f, 76.0f));
                context.SaveState();
                standOvalPath.AddClip();
                context.DrawLinearGradient(standGradient, new CGPoint(78.0f, 62.0f), new CGPoint(78.0f, 138.0f), 0);
                context.RestoreState();
                UIColor.Black.SetStroke();
                standOvalPath.LineWidth = 1.0f;
                standOvalPath.Stroke();
            }


            //// MaskGroup
            {
                context.SaveState();
                context.TranslateCTM(78.0f, 100.0f);
                context.RotateCTM(90.0f * NMath.PI / 180.0f);

                context.SetBlendMode(CGBlendMode.DestinationIn);
                context.BeginTransparencyLayer();


                //// MoveMask Drawing
                var moveMaskPath = new UIBezierPath();
                moveMaskPath.MoveTo(new CGPoint(-65.0f, 0.0f));
                moveMaskPath.AddCurveToPoint(new CGPoint(0.0f, -65.0f), new CGPoint(-65.0f, -35.9f), new CGPoint(-35.9f, -65.0f));
                moveMaskPath.AddCurveToPoint(new CGPoint(65.0f, 0.0f), new CGPoint(35.9f, -65.0f), new CGPoint(65.0f, -35.9f));
                moveMaskPath.AddCurveToPoint(new CGPoint(-0.0f, 65.0f), new CGPoint(65.0f, 35.9f), new CGPoint(35.9f, 65.0f));
                moveMaskPath.AddCurveToPoint(new CGPoint(-65.0f, 0.0f), new CGPoint(-35.9f, 65.0f), new CGPoint(-65.0f, 35.9f));
                moveMaskPath.ClosePath();
                UIColor.Black.SetStroke();
                moveMaskPath.LineWidth = 17.0f;
                moveMaskPath.LineCapStyle = CGLineCap.Round;
                context.SaveState();
                var moveMaskPattern = new nfloat[] { moveDash, 408.0f };
                context.SetLineDash(1.0f, moveMaskPattern);
                moveMaskPath.Stroke();
                context.RestoreState();


                //// ExerciseMask Drawing
                var exerciseMaskPath = new UIBezierPath();
                exerciseMaskPath.MoveTo(new CGPoint(-47.0f, 0.0f));
                exerciseMaskPath.AddCurveToPoint(new CGPoint(0.0f, -47.0f), new CGPoint(-47.0f, -25.96f), new CGPoint(-25.96f, -47.0f));
                exerciseMaskPath.AddCurveToPoint(new CGPoint(47.0f, 0.0f), new CGPoint(25.96f, -47.0f), new CGPoint(47.0f, -25.96f));
                exerciseMaskPath.AddCurveToPoint(new CGPoint(-0.0f, 47.0f), new CGPoint(47.0f, 25.96f), new CGPoint(25.96f, 47.0f));
                exerciseMaskPath.AddCurveToPoint(new CGPoint(-47.0f, 0.0f), new CGPoint(-25.96f, 47.0f), new CGPoint(-47.0f, 25.96f));
                exerciseMaskPath.ClosePath();
                UIColor.Black.SetStroke();
                exerciseMaskPath.LineWidth = 17.0f;
                exerciseMaskPath.LineCapStyle = CGLineCap.Round;
                context.SaveState();
                var exerciseMaskPattern = new nfloat[] { exersizeDash, 295.0f };
                context.SetLineDash(1.0f, exerciseMaskPattern);
                exerciseMaskPath.Stroke();
                context.RestoreState();


                //// StandMask Drawing
                var standMaskPath = new UIBezierPath();
                standMaskPath.MoveTo(new CGPoint(-29.0f, 0.0f));
                standMaskPath.AddCurveToPoint(new CGPoint(0.0f, -29.0f), new CGPoint(-29.0f, -16.02f), new CGPoint(-16.02f, -29.0f));
                standMaskPath.AddCurveToPoint(new CGPoint(29.0f, 0.0f), new CGPoint(16.02f, -29.0f), new CGPoint(29.0f, -16.02f));
                standMaskPath.AddCurveToPoint(new CGPoint(-0.0f, 29.0f), new CGPoint(29.0f, 16.02f), new CGPoint(16.02f, 29.0f));
                standMaskPath.AddCurveToPoint(new CGPoint(-29.0f, 0.0f), new CGPoint(-16.02f, 29.0f), new CGPoint(-29.0f, 16.02f));
                standMaskPath.ClosePath();
                UIColor.Black.SetStroke();
                standMaskPath.LineWidth = 17.0f;
                standMaskPath.LineCapStyle = CGLineCap.Round;
                context.SaveState();
                var standMaskPattern = new nfloat[] { standDash, 182.0f };
                context.SetLineDash(1.0f, standMaskPattern);
                standMaskPath.Stroke();
                context.RestoreState();


                context.EndTransparencyLayer();

                context.RestoreState();
            }
            
            context.RestoreState();

        }

        public static void DrawActivityComposition(nfloat moveLevel, nfloat exersizeLevel, nfloat standLevel)
        {
            //// General Declarations
            var context = UIGraphics.GetCurrentContext();

            //// Color Declarations
            var move1 = UIColor.FromRGBA(0.976f, 0.000f, 0.055f, 1.000f);
            var move1HSBA = new nfloat[4];
            move1.GetHSBA(out move1HSBA[0], out move1HSBA[1], out move1HSBA[2], out move1HSBA[3]);

            var moveBkg = UIColor.FromHSBA(move1HSBA[0], move1HSBA[1], 0.196f, move1HSBA[3]);
            var exercise1 = UIColor.FromRGBA(0.513f, 0.927f, 0.000f, 1.000f);
            var exercise1HSBA = new nfloat[4];
            exercise1.GetHSBA(out exercise1HSBA[0], out exercise1HSBA[1], out exercise1HSBA[2], out exercise1HSBA[3]);

            var exerciseBkg = UIColor.FromHSBA(exercise1HSBA[0], exercise1HSBA[1], 0.204f, exercise1HSBA[3]);
            var stand1 = UIColor.FromRGBA(0.000f, 0.851f, 0.830f, 1.000f);
            var stand1HSBA = new nfloat[4];
            stand1.GetHSBA(out stand1HSBA[0], out stand1HSBA[1], out stand1HSBA[2], out stand1HSBA[3]);

            var standBkg = UIColor.FromHSBA(stand1HSBA[0], stand1HSBA[1], 0.2f, stand1HSBA[3]);

            //// Shadow Declarations
            var shadow = new NSShadow();
            shadow.ShadowColor = UIColor.Black;
            shadow.ShadowOffset = new CGSize(0.0f, 0.0f);
            shadow.ShadowBlurRadius = 1.0f;

            //// ColorGroup
            {
                //// MaskOval Drawing
                var maskOvalPath = UIBezierPath.FromOval(new CGRect(4.0f, 26.0f, 148.0f, 148.0f));
                moveBkg.SetFill();
                maskOvalPath.Fill();


                //// ExerciseOval Drawing
                var exerciseOvalPath = UIBezierPath.FromOval(new CGRect(22.0f, 44.0f, 112.0f, 112.0f));
                exerciseBkg.SetFill();
                exerciseOvalPath.Fill();
                UIColor.Black.SetStroke();
                exerciseOvalPath.LineWidth = 1.0f;
                exerciseOvalPath.Stroke();


                //// StandOval Drawing
                var standOvalPath = UIBezierPath.FromOval(new CGRect(40.0f, 62.0f, 76.0f, 76.0f));
                standBkg.SetFill();
                standOvalPath.Fill();
                UIColor.Black.SetStroke();
                standOvalPath.LineWidth = 1.0f;
                standOvalPath.Stroke();
            }


            //// SymbolGroup
            {
                context.SaveState();
                context.SetBlendMode(CGBlendMode.SourceAtop);
                context.BeginTransparencyLayer();


                //// Symbol Drawing
                var symbolRect = new CGRect(0.0f, 0.0f, 156.0f, 195.0f);
                context.SaveState();
                context.ClipToRect(symbolRect);
                context.TranslateCTM(symbolRect.X, symbolRect.Y);

                StyleKitName.DrawActivity(new CGRect(new CGPoint(), symbolRect.Size), ResizingBehavior.Stretch, moveLevel, exersizeLevel, standLevel);
                context.RestoreState();


                context.EndTransparencyLayer();
                context.RestoreState();
            }


            //// Oval Drawing
            var ovalPath = UIBezierPath.FromOval(new CGRect(57.5f, 79.5f, 41.0f, 41.0f));
            UIColor.Black.SetFill();
            ovalPath.Fill();


            //// MoveArrow
            {
                //// Bezier Drawing
                var bezierPath = new UIBezierPath();
                bezierPath.MoveTo(new CGPoint(76.5f, 35.5f));
                bezierPath.AddLineTo(new CGPoint(83.5f, 35.5f));
                UIColor.Black.SetStroke();
                bezierPath.LineWidth = 2.0f;
                bezierPath.LineCapStyle = CGLineCap.Round;
                bezierPath.Stroke();


                //// Bezier 2 Drawing
                context.SaveState();
                context.TranslateCTM(83.5f, 35.5f);
                context.RotateCTM(-45.0f * NMath.PI / 180.0f);

                var bezier2Path = new UIBezierPath();
                bezier2Path.MoveTo(new CGPoint(-5.5f, -0.0f));
                bezier2Path.AddLineTo(new CGPoint(0.0f, 0.0f));
                UIColor.Black.SetStroke();
                bezier2Path.LineWidth = 2.0f;
                bezier2Path.LineCapStyle = CGLineCap.Round;
                bezier2Path.Stroke();

                context.RestoreState();


                //// Bezier 3 Drawing
                context.SaveState();
                context.TranslateCTM(83.5f, 35.5f);
                context.RotateCTM(45.0f * NMath.PI / 180.0f);

                var bezier3Path = new UIBezierPath();
                bezier3Path.MoveTo(new CGPoint(-5.5f, -0.0f));
                bezier3Path.AddLineTo(new CGPoint(0.0f, 0.0f));
                UIColor.Black.SetStroke();
                bezier3Path.LineWidth = 2.0f;
                bezier3Path.LineCapStyle = CGLineCap.Round;
                bezier3Path.Stroke();

                context.RestoreState();
            }


            //// ExerciseArrow
            {
                //// Bezier 4 Drawing
                var bezier4Path = new UIBezierPath();
                bezier4Path.MoveTo(new CGPoint(76.5f, 53.5f));
                bezier4Path.AddLineTo(new CGPoint(83.5f, 53.5f));
                UIColor.Black.SetStroke();
                bezier4Path.LineWidth = 2.0f;
                bezier4Path.LineCapStyle = CGLineCap.Round;
                bezier4Path.Stroke();


                //// Bezier 5 Drawing
                context.SaveState();
                context.TranslateCTM(83.5f, 53.5f);
                context.RotateCTM(-45.0f * NMath.PI / 180.0f);

                var bezier5Path = new UIBezierPath();
                bezier5Path.MoveTo(new CGPoint(-5.5f, -0.0f));
                bezier5Path.AddLineTo(new CGPoint(0.0f, 0.0f));
                UIColor.Black.SetStroke();
                bezier5Path.LineWidth = 2.0f;
                bezier5Path.LineCapStyle = CGLineCap.Round;
                bezier5Path.Stroke();

                context.RestoreState();


                //// Bezier 6 Drawing
                context.SaveState();
                context.TranslateCTM(83.5f, 53.5f);
                context.RotateCTM(45.0f * NMath.PI / 180.0f);

                var bezier6Path = new UIBezierPath();
                bezier6Path.MoveTo(new CGPoint(-5.5f, -0.0f));
                bezier6Path.AddLineTo(new CGPoint(0.0f, 0.0f));
                UIColor.Black.SetStroke();
                bezier6Path.LineWidth = 2.0f;
                bezier6Path.LineCapStyle = CGLineCap.Round;
                bezier6Path.Stroke();

                context.RestoreState();


                //// Bezier 7 Drawing
                context.SaveState();
                context.TranslateCTM(87.5f, 53.5f);
                context.RotateCTM(-45.0f * NMath.PI / 180.0f);

                var bezier7Path = new UIBezierPath();
                bezier7Path.MoveTo(new CGPoint(-5.5f, -0.0f));
                bezier7Path.AddLineTo(new CGPoint(0.0f, 0.0f));
                UIColor.Black.SetStroke();
                bezier7Path.LineWidth = 2.0f;
                bezier7Path.LineCapStyle = CGLineCap.Round;
                bezier7Path.Stroke();

                context.RestoreState();


                //// Bezier 8 Drawing
                context.SaveState();
                context.TranslateCTM(87.5f, 53.5f);
                context.RotateCTM(45.0f * NMath.PI / 180.0f);

                var bezier8Path = new UIBezierPath();
                bezier8Path.MoveTo(new CGPoint(-5.5f, -0.0f));
                bezier8Path.AddLineTo(new CGPoint(0.0f, 0.0f));
                UIColor.Black.SetStroke();
                bezier8Path.LineWidth = 2.0f;
                bezier8Path.LineCapStyle = CGLineCap.Round;
                bezier8Path.Stroke();

                context.RestoreState();
            }


            //// StandArrow
            {
                context.SaveState();
                context.TranslateCTM(80.0f, 71.5f);
                context.RotateCTM(-90.0f * NMath.PI / 180.0f);



                //// Bezier 9 Drawing
                var bezier9Path = new UIBezierPath();
                bezier9Path.MoveTo(new CGPoint(-3.5f, 0.0f));
                bezier9Path.AddLineTo(new CGPoint(3.5f, 0.0f));
                UIColor.Black.SetStroke();
                bezier9Path.LineWidth = 2.0f;
                bezier9Path.LineCapStyle = CGLineCap.Round;
                bezier9Path.Stroke();


                //// Bezier 10 Drawing
                context.SaveState();
                context.TranslateCTM(3.5f, 0.0f);
                context.RotateCTM(-45.0f * NMath.PI / 180.0f);

                var bezier10Path = new UIBezierPath();
                bezier10Path.MoveTo(new CGPoint(-5.5f, -0.0f));
                bezier10Path.AddLineTo(new CGPoint(0.0f, 0.0f));
                UIColor.Black.SetStroke();
                bezier10Path.LineWidth = 2.0f;
                bezier10Path.LineCapStyle = CGLineCap.Round;
                bezier10Path.Stroke();

                context.RestoreState();


                //// Bezier 11 Drawing
                context.SaveState();
                context.TranslateCTM(3.5f, 0.0f);
                context.RotateCTM(45.0f * NMath.PI / 180.0f);

                var bezier11Path = new UIBezierPath();
                bezier11Path.MoveTo(new CGPoint(-5.5f, -0.0f));
                bezier11Path.AddLineTo(new CGPoint(0.0f, 0.0f));
                UIColor.Black.SetStroke();
                bezier11Path.LineWidth = 2.0f;
                bezier11Path.LineCapStyle = CGLineCap.Round;
                bezier11Path.Stroke();

                context.RestoreState();



                context.RestoreState();
            }


            //// Text Drawing
            var textRect = new CGRect(6.0f, 25.5f, 58.0f, 19.0f);
            {
                var textContent = "MOVE";
                context.SaveState();
                context.SetShadow(shadow.ShadowOffset, shadow.ShadowBlurRadius, shadow.ShadowColor.CGColor);
                move1.SetFill();
                var textStyle = new NSMutableParagraphStyle();
                textStyle.Alignment = UITextAlignment.Right;
                var textFontAttributes = new UIStringAttributes { Font = UIFont.SystemFontOfSize(13.0f), ForegroundColor = move1, ParagraphStyle = textStyle };
                var textTextHeight = new NSString(textContent).GetBoundingRect(new CGSize(textRect.Width, nfloat.MaxValue), NSStringDrawingOptions.UsesLineFragmentOrigin, textFontAttributes, null).Height;
                context.SaveState();
                context.ClipToRect(textRect);
                new NSString(textContent).DrawString(new CGRect(textRect.GetMinX(), textRect.GetMinY() + (textRect.Height - textTextHeight) / 2.0f, textRect.Width, textTextHeight), textFontAttributes);
                context.RestoreState();
                context.RestoreState();

            }


            //// Text 2 Drawing
            var text2Rect = new CGRect(6.0f, 42.0f, 58.0f, 19.0f);
            {
                var textContent = "EXERCISE";
                context.SaveState();
                context.SetShadow(shadow.ShadowOffset, shadow.ShadowBlurRadius, shadow.ShadowColor.CGColor);
                exercise1.SetFill();
                var text2Style = new NSMutableParagraphStyle();
                text2Style.Alignment = UITextAlignment.Right;
                var text2FontAttributes = new UIStringAttributes { Font = UIFont.SystemFontOfSize(13.0f), ForegroundColor = exercise1, ParagraphStyle = text2Style };
                var text2TextHeight = new NSString(textContent).GetBoundingRect(new CGSize(text2Rect.Width, nfloat.MaxValue), NSStringDrawingOptions.UsesLineFragmentOrigin, text2FontAttributes, null).Height;
                context.SaveState();
                context.ClipToRect(text2Rect);
                new NSString(textContent).DrawString(new CGRect(text2Rect.GetMinX(), text2Rect.GetMinY() + (text2Rect.Height - text2TextHeight) / 2.0f, text2Rect.Width, text2TextHeight), text2FontAttributes);
                context.RestoreState();
                context.RestoreState();

            }


            //// Text 3 Drawing
            var text3Rect = new CGRect(6.0f, 61.0f, 58.0f, 19.0f);
            {
                var textContent = "STAND";
                context.SaveState();
                context.SetShadow(shadow.ShadowOffset, shadow.ShadowBlurRadius, shadow.ShadowColor.CGColor);
                stand1.SetFill();
                var text3Style = new NSMutableParagraphStyle();
                text3Style.Alignment = UITextAlignment.Right;
                var text3FontAttributes = new UIStringAttributes { Font = UIFont.SystemFontOfSize(13.0f), ForegroundColor = stand1, ParagraphStyle = text3Style };
                var text3TextHeight = new NSString(textContent).GetBoundingRect(new CGSize(text3Rect.Width, nfloat.MaxValue), NSStringDrawingOptions.UsesLineFragmentOrigin, text3FontAttributes, null).Height;
                context.SaveState();
                context.ClipToRect(text3Rect);
                new NSString(textContent).DrawString(new CGRect(text3Rect.GetMinX(), text3Rect.GetMinY() + (text3Rect.Height - text3TextHeight) / 2.0f, text3Rect.Width, text3TextHeight), text3FontAttributes);
                context.RestoreState();
                context.RestoreState();

            }
        }




        public enum ResizingBehavior
        {
            AspectFit, // The content is proportionally resized to fit into the target rectangle.
            AspectFill, // The content is proportionally resized to completely fill the target rectangle.
            Stretch, // The content is stretched to match the entire target rectangle.
            Center, // The content is centered in the target rectangle, but it is NOT resized.
        };

        public static CGRect ResizingBehaviorApply(ResizingBehavior behavior, CGRect rect, CGRect target)
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

     
     */
