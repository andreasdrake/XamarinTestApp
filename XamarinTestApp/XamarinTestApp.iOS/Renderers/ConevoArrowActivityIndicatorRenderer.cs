using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using XamarinTestApp.Controls;
using XamarinTestApp.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using System.ComponentModel;
using CoreGraphics;

[assembly: ExportRenderer(typeof(ConevoArrowActivityIndicator), typeof(ConevoArrowActivityIndicatorRenderer))]
namespace XamarinTestApp.iOS.Renderers
{
    public class ConevoArrowActivityIndicatorRenderer : ViewRenderer<ConevoArrowActivityIndicator, UIView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ConevoArrowActivityIndicator> e)
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

        public override void Draw(CGRect frame)
        {
            //// Color Declarations
            var color1 = UIColor.FromRGBA(0.475f, 0.710f, 0.110f, 1.000f);
            var color2 = UIColor.FromRGBA(0.075f, 0.620f, 0.184f, 1.000f);
            var color3 = UIColor.FromRGBA(0.682f, 0.780f, 0.016f, 1.000f);
            var color4 = UIColor.FromRGBA(0.000f, 0.494f, 0.192f, 1.000f);
            var color5 = UIColor.FromRGBA(0.004f, 0.388f, 0.184f, 1.000f);


            //// Subframes
            var arrowGroup = new CGRect(frame.GetMinX() + 1.0f, frame.GetMinY() + 1.0f, frame.Width - 2.0f, frame.Height - 2.0f);


            //// ArrowGroup
            {
                //// r1 Drawing
                var r1Path = UIBezierPath.FromRect(new CGRect(arrowGroup.GetMinX() + NMath.Floor(arrowGroup.Width * 0.00000f + 0.5f), arrowGroup.GetMinY() + NMath.Floor(arrowGroup.Height * 0.00000f + 0.5f), NMath.Floor(arrowGroup.Width * 0.16667f + 0.5f) - NMath.Floor(arrowGroup.Width * 0.00000f + 0.5f), NMath.Floor(arrowGroup.Height * 0.08163f + 0.5f) - NMath.Floor(arrowGroup.Height * 0.00000f + 0.5f)));
                color1.SetFill();
                r1Path.Fill();


                //// r2 Drawing
                var r2Path = UIBezierPath.FromRect(new CGRect(arrowGroup.GetMinX() + NMath.Floor(arrowGroup.Width * 0.00000f + 0.5f), arrowGroup.GetMinY() + NMath.Floor(arrowGroup.Height * 0.10204f + 0.5f), NMath.Floor(arrowGroup.Width * 0.16667f + 0.5f) - NMath.Floor(arrowGroup.Width * 0.00000f + 0.5f), NMath.Floor(arrowGroup.Height * 0.18367f + 0.5f) - NMath.Floor(arrowGroup.Height * 0.10204f + 0.5f)));
                color2.SetFill();
                r2Path.Fill();


                //// r3 Drawing
                var r3Path = UIBezierPath.FromRect(new CGRect(arrowGroup.GetMinX() + NMath.Floor(arrowGroup.Width * 0.20833f + 0.5f), arrowGroup.GetMinY() + NMath.Floor(arrowGroup.Height * 0.10204f + 0.5f), NMath.Floor(arrowGroup.Width * 0.37500f + 0.5f) - NMath.Floor(arrowGroup.Width * 0.20833f + 0.5f), NMath.Floor(arrowGroup.Height * 0.18367f + 0.5f) - NMath.Floor(arrowGroup.Height * 0.10204f + 0.5f)));
                color3.SetFill();
                r3Path.Fill();


                //// r4 Drawing
                var r4Path = UIBezierPath.FromRect(new CGRect(arrowGroup.GetMinX() + NMath.Floor(arrowGroup.Width * 0.00000f + 0.5f), arrowGroup.GetMinY() + NMath.Floor(arrowGroup.Height * 0.20408f + 0.5f), NMath.Floor(arrowGroup.Width * 0.16667f + 0.5f) - NMath.Floor(arrowGroup.Width * 0.00000f + 0.5f), NMath.Floor(arrowGroup.Height * 0.28571f + 0.5f) - NMath.Floor(arrowGroup.Height * 0.20408f + 0.5f)));
                color4.SetFill();
                r4Path.Fill();


                //// r5 Drawing
                var r5Path = UIBezierPath.FromRect(new CGRect(arrowGroup.GetMinX() + NMath.Floor(arrowGroup.Width * 0.20833f + 0.5f), arrowGroup.GetMinY() + NMath.Floor(arrowGroup.Height * 0.20408f + 0.5f), NMath.Floor(arrowGroup.Width * 0.37500f + 0.5f) - NMath.Floor(arrowGroup.Width * 0.20833f + 0.5f), NMath.Floor(arrowGroup.Height * 0.28571f + 0.5f) - NMath.Floor(arrowGroup.Height * 0.20408f + 0.5f)));
                color5.SetFill();
                r5Path.Fill();


                //// r6 Drawing
                var r6Path = UIBezierPath.FromRect(new CGRect(arrowGroup.GetMinX() + NMath.Floor(arrowGroup.Width * 0.41667f + 0.5f), arrowGroup.GetMinY() + NMath.Floor(arrowGroup.Height * 0.20408f + 0.5f), NMath.Floor(arrowGroup.Width * 0.58333f + 0.5f) - NMath.Floor(arrowGroup.Width * 0.41667f + 0.5f), NMath.Floor(arrowGroup.Height * 0.28571f + 0.5f) - NMath.Floor(arrowGroup.Height * 0.20408f + 0.5f)));
                color1.SetFill();
                r6Path.Fill();


                //// r7 Drawing
                var r7Path = UIBezierPath.FromRect(new CGRect(arrowGroup.GetMinX() + NMath.Floor(arrowGroup.Width * 0.00000f + 0.5f), arrowGroup.GetMinY() + NMath.Floor(arrowGroup.Height * 0.30612f + 0.5f), NMath.Floor(arrowGroup.Width * 0.16667f + 0.5f) - NMath.Floor(arrowGroup.Width * 0.00000f + 0.5f), NMath.Floor(arrowGroup.Height * 0.38776f + 0.5f) - NMath.Floor(arrowGroup.Height * 0.30612f + 0.5f)));
                color3.SetFill();
                r7Path.Fill();


                //// r8 Drawing
                var r8Path = UIBezierPath.FromRect(new CGRect(arrowGroup.GetMinX() + NMath.Floor(arrowGroup.Width * 0.20833f + 0.5f), arrowGroup.GetMinY() + NMath.Floor(arrowGroup.Height * 0.30612f + 0.5f), NMath.Floor(arrowGroup.Width * 0.37500f + 0.5f) - NMath.Floor(arrowGroup.Width * 0.20833f + 0.5f), NMath.Floor(arrowGroup.Height * 0.38776f + 0.5f) - NMath.Floor(arrowGroup.Height * 0.30612f + 0.5f)));
                color2.SetFill();
                r8Path.Fill();


                //// r9 Drawing
                var r9Path = UIBezierPath.FromRect(new CGRect(arrowGroup.GetMinX() + NMath.Floor(arrowGroup.Width * 0.41667f + 0.5f), arrowGroup.GetMinY() + NMath.Floor(arrowGroup.Height * 0.30612f + 0.5f), NMath.Floor(arrowGroup.Width * 0.58333f + 0.5f) - NMath.Floor(arrowGroup.Width * 0.41667f + 0.5f), NMath.Floor(arrowGroup.Height * 0.38776f + 0.5f) - NMath.Floor(arrowGroup.Height * 0.30612f + 0.5f)));
                color4.SetFill();
                r9Path.Fill();


                //// r10 Drawing
                var r10Path = UIBezierPath.FromRect(new CGRect(arrowGroup.GetMinX() + NMath.Floor(arrowGroup.Width * 0.62500f + 0.5f), arrowGroup.GetMinY() + NMath.Floor(arrowGroup.Height * 0.30612f + 0.5f), NMath.Floor(arrowGroup.Width * 0.79167f + 0.5f) - NMath.Floor(arrowGroup.Width * 0.62500f + 0.5f), NMath.Floor(arrowGroup.Height * 0.38776f + 0.5f) - NMath.Floor(arrowGroup.Height * 0.30612f + 0.5f)));
                color2.SetFill();
                r10Path.Fill();


                //// r11 Drawing
                var r11Path = UIBezierPath.FromRect(new CGRect(arrowGroup.GetMinX() + NMath.Floor(arrowGroup.Width * 0.00000f + 0.5f), arrowGroup.GetMinY() + NMath.Floor(arrowGroup.Height * 0.40816f + 0.5f), NMath.Floor(arrowGroup.Width * 0.16667f + 0.5f) - NMath.Floor(arrowGroup.Width * 0.00000f + 0.5f), NMath.Floor(arrowGroup.Height * 0.48980f + 0.5f) - NMath.Floor(arrowGroup.Height * 0.40816f + 0.5f)));
                color1.SetFill();
                r11Path.Fill();


                //// r12 Drawing
                var r12Path = UIBezierPath.FromRect(new CGRect(arrowGroup.GetMinX() + NMath.Floor(arrowGroup.Width * 0.20833f + 0.5f), arrowGroup.GetMinY() + NMath.Floor(arrowGroup.Height * 0.40816f + 0.5f), NMath.Floor(arrowGroup.Width * 0.37500f + 0.5f) - NMath.Floor(arrowGroup.Width * 0.20833f + 0.5f), NMath.Floor(arrowGroup.Height * 0.48980f + 0.5f) - NMath.Floor(arrowGroup.Height * 0.40816f + 0.5f)));
                color4.SetFill();
                r12Path.Fill();


                //// r13 Drawing
                var r13Path = UIBezierPath.FromRect(new CGRect(arrowGroup.GetMinX() + NMath.Floor(arrowGroup.Width * 0.41667f + 0.5f), arrowGroup.GetMinY() + NMath.Floor(arrowGroup.Height * 0.40816f + 0.5f), NMath.Floor(arrowGroup.Width * 0.58333f + 0.5f) - NMath.Floor(arrowGroup.Width * 0.41667f + 0.5f), NMath.Floor(arrowGroup.Height * 0.48980f + 0.5f) - NMath.Floor(arrowGroup.Height * 0.40816f + 0.5f)));
                color5.SetFill();
                r13Path.Fill();


                //// r14 Drawing
                var r14Path = UIBezierPath.FromRect(new CGRect(arrowGroup.GetMinX() + NMath.Floor(arrowGroup.Width * 0.62500f + 0.5f), arrowGroup.GetMinY() + NMath.Floor(arrowGroup.Height * 0.40816f + 0.5f), NMath.Floor(arrowGroup.Width * 0.79167f + 0.5f) - NMath.Floor(arrowGroup.Width * 0.62500f + 0.5f), NMath.Floor(arrowGroup.Height * 0.48980f + 0.5f) - NMath.Floor(arrowGroup.Height * 0.40816f + 0.5f)));
                color1.SetFill();
                r14Path.Fill();


                //// r15 Drawing
                var r15Path = UIBezierPath.FromRect(new CGRect(arrowGroup.GetMinX() + NMath.Floor(arrowGroup.Width * 0.83333f + 0.5f), arrowGroup.GetMinY() + NMath.Floor(arrowGroup.Height * 0.40816f + 0.5f), NMath.Floor(arrowGroup.Width * 1.00000f + 0.5f) - NMath.Floor(arrowGroup.Width * 0.83333f + 0.5f), NMath.Floor(arrowGroup.Height * 0.48980f + 0.5f) - NMath.Floor(arrowGroup.Height * 0.40816f + 0.5f)));
                color2.SetFill();
                r15Path.Fill();


                //// r16 Drawing
                var r16Path = UIBezierPath.FromRect(new CGRect(arrowGroup.GetMinX() + NMath.Floor(arrowGroup.Width * 0.00000f + 0.5f), arrowGroup.GetMinY() + NMath.Floor(arrowGroup.Height * 0.51020f + 0.5f), NMath.Floor(arrowGroup.Width * 0.16667f + 0.5f) - NMath.Floor(arrowGroup.Width * 0.00000f + 0.5f), NMath.Floor(arrowGroup.Height * 0.59184f + 0.5f) - NMath.Floor(arrowGroup.Height * 0.51020f + 0.5f)));
                color5.SetFill();
                r16Path.Fill();


                //// r17 Drawing
                var r17Path = UIBezierPath.FromRect(new CGRect(arrowGroup.GetMinX() + NMath.Floor(arrowGroup.Width * 0.20833f + 0.5f), arrowGroup.GetMinY() + NMath.Floor(arrowGroup.Height * 0.51020f + 0.5f), NMath.Floor(arrowGroup.Width * 0.37500f + 0.5f) - NMath.Floor(arrowGroup.Width * 0.20833f + 0.5f), NMath.Floor(arrowGroup.Height * 0.59184f + 0.5f) - NMath.Floor(arrowGroup.Height * 0.51020f + 0.5f)));
                color3.SetFill();
                r17Path.Fill();


                //// r18 Drawing
                var r18Path = UIBezierPath.FromRect(new CGRect(arrowGroup.GetMinX() + NMath.Floor(arrowGroup.Width * 0.41667f + 0.5f), arrowGroup.GetMinY() + NMath.Floor(arrowGroup.Height * 0.51020f + 0.5f), NMath.Floor(arrowGroup.Width * 0.58333f + 0.5f) - NMath.Floor(arrowGroup.Width * 0.41667f + 0.5f), NMath.Floor(arrowGroup.Height * 0.59184f + 0.5f) - NMath.Floor(arrowGroup.Height * 0.51020f + 0.5f)));
                color1.SetFill();
                r18Path.Fill();


                //// r19 Drawing
                var r19Path = UIBezierPath.FromRect(new CGRect(arrowGroup.GetMinX() + NMath.Floor(arrowGroup.Width * 0.00000f + 0.5f), arrowGroup.GetMinY() + NMath.Floor(arrowGroup.Height * 0.61224f + 0.5f), NMath.Floor(arrowGroup.Width * 0.16667f + 0.5f) - NMath.Floor(arrowGroup.Width * 0.00000f + 0.5f), NMath.Floor(arrowGroup.Height * 0.69388f + 0.5f) - NMath.Floor(arrowGroup.Height * 0.61224f + 0.5f)));
                color2.SetFill();
                r19Path.Fill();


                //// r20 Drawing
                var r20Path = UIBezierPath.FromRect(new CGRect(arrowGroup.GetMinX() + NMath.Floor(arrowGroup.Width * 0.41667f + 0.5f), arrowGroup.GetMinY() + NMath.Floor(arrowGroup.Height * 0.61224f + 0.5f), NMath.Floor(arrowGroup.Width * 0.58333f + 0.5f) - NMath.Floor(arrowGroup.Width * 0.41667f + 0.5f), NMath.Floor(arrowGroup.Height * 0.69388f + 0.5f) - NMath.Floor(arrowGroup.Height * 0.61224f + 0.5f)));
                color4.SetFill();
                r20Path.Fill();


                //// r21 Drawing
                var r21Path = UIBezierPath.FromRect(new CGRect(arrowGroup.GetMinX() + NMath.Floor(arrowGroup.Width * 0.62500f + 0.5f), arrowGroup.GetMinY() + NMath.Floor(arrowGroup.Height * 0.61224f + 0.5f), NMath.Floor(arrowGroup.Width * 0.79167f + 0.5f) - NMath.Floor(arrowGroup.Width * 0.62500f + 0.5f), NMath.Floor(arrowGroup.Height * 0.69388f + 0.5f) - NMath.Floor(arrowGroup.Height * 0.61224f + 0.5f)));
                color5.SetFill();
                r21Path.Fill();


                //// r22 Drawing
                var r22Path = UIBezierPath.FromRect(new CGRect(arrowGroup.GetMinX() + NMath.Floor(arrowGroup.Width * 0.62500f + 0.5f), arrowGroup.GetMinY() + NMath.Floor(arrowGroup.Height * 0.71429f + 0.5f), NMath.Floor(arrowGroup.Width * 0.79167f + 0.5f) - NMath.Floor(arrowGroup.Width * 0.62500f + 0.5f), NMath.Floor(arrowGroup.Height * 0.79592f + 0.5f) - NMath.Floor(arrowGroup.Height * 0.71429f + 0.5f)));
                color3.SetFill();
                r22Path.Fill();


                //// r23 Drawing
                var r23Path = UIBezierPath.FromRect(new CGRect(arrowGroup.GetMinX() + NMath.Floor(arrowGroup.Width * 0.62500f + 0.5f), arrowGroup.GetMinY() + NMath.Floor(arrowGroup.Height * 0.81633f + 0.5f), NMath.Floor(arrowGroup.Width * 0.79167f + 0.5f) - NMath.Floor(arrowGroup.Width * 0.62500f + 0.5f), NMath.Floor(arrowGroup.Height * 0.89796f + 0.5f) - NMath.Floor(arrowGroup.Height * 0.81633f + 0.5f)));
                color4.SetFill();
                r23Path.Fill();


                //// r24 Drawing
                var r24Path = UIBezierPath.FromRect(new CGRect(arrowGroup.GetMinX() + NMath.Floor(arrowGroup.Width * 0.83333f + 0.5f), arrowGroup.GetMinY() + NMath.Floor(arrowGroup.Height * 0.81633f + 0.5f), NMath.Floor(arrowGroup.Width * 1.00000f + 0.5f) - NMath.Floor(arrowGroup.Width * 0.83333f + 0.5f), NMath.Floor(arrowGroup.Height * 0.89796f + 0.5f) - NMath.Floor(arrowGroup.Height * 0.81633f + 0.5f)));
                color1.SetFill();
                r24Path.Fill();


                //// r25 Drawing
                var r25Path = UIBezierPath.FromRect(new CGRect(arrowGroup.GetMinX() + NMath.Floor(arrowGroup.Width * 0.83333f + 0.5f), arrowGroup.GetMinY() + NMath.Floor(arrowGroup.Height * 0.91837f + 0.5f), NMath.Floor(arrowGroup.Width * 1.00000f + 0.5f) - NMath.Floor(arrowGroup.Width * 0.83333f + 0.5f), NMath.Floor(arrowGroup.Height * 1.00000f + 0.5f) - NMath.Floor(arrowGroup.Height * 0.91837f + 0.5f)));
                color2.SetFill();
                r25Path.Fill();
            }


        }


        public  void DrawBig(CGRect frame)
        {
            //// Color Declarations
            var color1 = UIColor.FromRGBA(0.475f, 0.710f, 0.110f, 1.000f);
            var color2 = UIColor.FromRGBA(0.075f, 0.620f, 0.184f, 1.000f);
            var color = UIColor.FromRGBA(0.682f, 0.780f, 0.016f, 1.000f);
            var color3 = UIColor.FromRGBA(0.000f, 0.494f, 0.192f, 1.000f);
            var color4 = UIColor.FromRGBA(0.004f, 0.388f, 0.184f, 1.000f);
            var color5 = UIColor.FromRGBA(0.000f, 0.494f, 0.192f, 1.000f);
            var _79b51c = UIColor.FromRGBA(0.475f, 0.710f, 0.110f, 1.000f);


            //// Subframes
            var group3 = new CGRect(frame.GetMinX() + 2.0f, frame.GetMinY() + 1.0f, frame.Width - 4.0f, frame.Height - 3.0f);


            //// Group 3
            {
                //// Rectangle Drawing
                var rectanglePath = UIBezierPath.FromRect(new CGRect(group3.GetMinX() + NMath.Floor(group3.Width * 0.00000f + 0.5f), group3.GetMinY() + NMath.Floor(group3.Height * 0.00000f + 0.5f), NMath.Floor(group3.Width * 0.17949f + 0.5f) - NMath.Floor(group3.Width * 0.00000f + 0.5f), NMath.Floor(group3.Height * 0.08861f + 0.5f) - NMath.Floor(group3.Height * 0.00000f + 0.5f)));
                color1.SetFill();
                rectanglePath.Fill();


                //// Rectangle 2 Drawing
                var rectangle2Path = UIBezierPath.FromRect(new CGRect(group3.GetMinX() + NMath.Floor(group3.Width * 0.00000f + 0.5f), group3.GetMinY() + NMath.Floor(group3.Height * 0.10127f + 0.5f), NMath.Floor(group3.Width * 0.17949f + 0.5f) - NMath.Floor(group3.Width * 0.00000f + 0.5f), NMath.Floor(group3.Height * 0.18987f + 0.5f) - NMath.Floor(group3.Height * 0.10127f + 0.5f)));
                color2.SetFill();
                rectangle2Path.Fill();


                //// Rectangle 3 Drawing
                var rectangle3Path = UIBezierPath.FromRect(new CGRect(group3.GetMinX() + NMath.Floor(group3.Width * 0.00000f + 0.5f), group3.GetMinY() + NMath.Floor(group3.Height * 0.20253f + 0.5f), NMath.Floor(group3.Width * 0.17949f + 0.5f) - NMath.Floor(group3.Width * 0.00000f + 0.5f), NMath.Floor(group3.Height * 0.29114f + 0.5f) - NMath.Floor(group3.Height * 0.20253f + 0.5f)));
                color3.SetFill();
                rectangle3Path.Fill();


                //// Group 2
                {
                    //// Rectangle 4 Drawing
                    var rectangle4Path = UIBezierPath.FromRect(new CGRect(group3.GetMinX() + NMath.Floor(group3.Width * 0.00000f + 0.5f), group3.GetMinY() + NMath.Floor(group3.Height * 0.30380f + 0.5f), NMath.Floor(group3.Width * 0.17949f + 0.5f) - NMath.Floor(group3.Width * 0.00000f + 0.5f), NMath.Floor(group3.Height * 0.39241f + 0.5f) - NMath.Floor(group3.Height * 0.30380f + 0.5f)));
                    color.SetFill();
                    rectangle4Path.Fill();
                }


                //// Rectangle 5 Drawing
                var rectangle5Path = UIBezierPath.FromRect(new CGRect(group3.GetMinX() + NMath.Floor(group3.Width * 0.00000f + 0.5f), group3.GetMinY() + NMath.Floor(group3.Height * 0.40506f + 0.5f), NMath.Floor(group3.Width * 0.17949f + 0.5f) - NMath.Floor(group3.Width * 0.00000f + 0.5f), NMath.Floor(group3.Height * 0.49367f + 0.5f) - NMath.Floor(group3.Height * 0.40506f + 0.5f)));
                _79b51c.SetFill();
                rectangle5Path.Fill();


                //// Rectangle 6 Drawing
                var rectangle6Path = UIBezierPath.FromRect(new CGRect(group3.GetMinX() + NMath.Floor(group3.Width * 0.00000f + 0.5f), group3.GetMinY() + NMath.Floor(group3.Height * 0.50633f + 0.5f), NMath.Floor(group3.Width * 0.17949f + 0.5f) - NMath.Floor(group3.Width * 0.00000f + 0.5f), NMath.Floor(group3.Height * 0.59494f + 0.5f) - NMath.Floor(group3.Height * 0.50633f + 0.5f)));
                color4.SetFill();
                rectangle6Path.Fill();


                //// Rectangle 7 Drawing
                var rectangle7Path = UIBezierPath.FromRect(new CGRect(group3.GetMinX() + NMath.Floor(group3.Width * 0.20513f + 0.5f), group3.GetMinY() + NMath.Floor(group3.Height * 0.10127f + 0.5f), NMath.Floor(group3.Width * 0.38462f + 0.5f) - NMath.Floor(group3.Width * 0.20513f + 0.5f), NMath.Floor(group3.Height * 0.18987f + 0.5f) - NMath.Floor(group3.Height * 0.10127f + 0.5f)));
                color.SetFill();
                rectangle7Path.Fill();


                //// Rectangle 8 Drawing
                var rectangle8Path = UIBezierPath.FromRect(new CGRect(group3.GetMinX() + NMath.Floor(group3.Width * 0.20513f + 0.5f), group3.GetMinY() + NMath.Floor(group3.Height * 0.20253f + 0.5f), NMath.Floor(group3.Width * 0.38462f + 0.5f) - NMath.Floor(group3.Width * 0.20513f + 0.5f), NMath.Floor(group3.Height * 0.29114f + 0.5f) - NMath.Floor(group3.Height * 0.20253f + 0.5f)));
                color4.SetFill();
                rectangle8Path.Fill();


                //// Rectangle 9 Drawing
                var rectangle9Path = UIBezierPath.FromRect(new CGRect(group3.GetMinX() + NMath.Floor(group3.Width * 0.20513f + 0.5f), group3.GetMinY() + NMath.Floor(group3.Height * 0.30380f + 0.5f), NMath.Floor(group3.Width * 0.38462f + 0.5f) - NMath.Floor(group3.Width * 0.20513f + 0.5f), NMath.Floor(group3.Height * 0.39241f + 0.5f) - NMath.Floor(group3.Height * 0.30380f + 0.5f)));
                color2.SetFill();
                rectangle9Path.Fill();


                //// Rectangle 10 Drawing
                var rectangle10Path = UIBezierPath.FromRect(new CGRect(group3.GetMinX() + NMath.Floor(group3.Width * 0.20513f + 0.5f), group3.GetMinY() + NMath.Floor(group3.Height * 0.40506f + 0.5f), NMath.Floor(group3.Width * 0.38462f + 0.5f) - NMath.Floor(group3.Width * 0.20513f + 0.5f), NMath.Floor(group3.Height * 0.49367f + 0.5f) - NMath.Floor(group3.Height * 0.40506f + 0.5f)));
                color3.SetFill();
                rectangle10Path.Fill();


                //// Rectangle 11 Drawing
                var rectangle11Path = UIBezierPath.FromRect(new CGRect(group3.GetMinX() + NMath.Floor(group3.Width * 0.41026f + 0.5f), group3.GetMinY() + NMath.Floor(group3.Height * 0.20253f + 0.5f), NMath.Floor(group3.Width * 0.58974f + 0.5f) - NMath.Floor(group3.Width * 0.41026f + 0.5f), NMath.Floor(group3.Height * 0.29114f + 0.5f) - NMath.Floor(group3.Height * 0.20253f + 0.5f)));
                color1.SetFill();
                rectangle11Path.Fill();


                //// Rectangle 12 Drawing
                var rectangle12Path = UIBezierPath.FromRect(new CGRect(group3.GetMinX() + NMath.Floor(group3.Width * 0.41026f + 0.5f), group3.GetMinY() + NMath.Floor(group3.Height * 0.30380f + 0.5f), NMath.Floor(group3.Width * 0.58974f + 0.5f) - NMath.Floor(group3.Width * 0.41026f + 0.5f), NMath.Floor(group3.Height * 0.39241f + 0.5f) - NMath.Floor(group3.Height * 0.30380f + 0.5f)));
                color5.SetFill();
                rectangle12Path.Fill();


                //// Rectangle 13 Drawing
                var rectangle13Path = UIBezierPath.FromRect(new CGRect(group3.GetMinX() + NMath.Floor(group3.Width * 0.41026f + 0.5f), group3.GetMinY() + NMath.Floor(group3.Height * 0.40506f + 0.5f), NMath.Floor(group3.Width * 0.58974f + 0.5f) - NMath.Floor(group3.Width * 0.41026f + 0.5f), NMath.Floor(group3.Height * 0.49367f + 0.5f) - NMath.Floor(group3.Height * 0.40506f + 0.5f)));
                color4.SetFill();
                rectangle13Path.Fill();


                //// Rectangle 14 Drawing
                var rectangle14Path = UIBezierPath.FromRect(new CGRect(group3.GetMinX() + NMath.Floor(group3.Width * 0.61538f + 0.5f), group3.GetMinY() + NMath.Floor(group3.Height * 0.30380f + 0.5f), NMath.Floor(group3.Width * 0.79487f + 0.5f) - NMath.Floor(group3.Width * 0.61538f + 0.5f), NMath.Floor(group3.Height * 0.39241f + 0.5f) - NMath.Floor(group3.Height * 0.30380f + 0.5f)));
                color2.SetFill();
                rectangle14Path.Fill();


                //// Rectangle 15 Drawing
                var rectangle15Path = UIBezierPath.FromRect(new CGRect(group3.GetMinX() + NMath.Floor(group3.Width * 0.61538f + 0.5f), group3.GetMinY() + NMath.Floor(group3.Height * 0.40506f + 0.5f), NMath.Floor(group3.Width * 0.79487f + 0.5f) - NMath.Floor(group3.Width * 0.61538f + 0.5f), NMath.Floor(group3.Height * 0.49367f + 0.5f) - NMath.Floor(group3.Height * 0.40506f + 0.5f)));
                color1.SetFill();
                rectangle15Path.Fill();


                //// Rectangle 16 Drawing
                var rectangle16Path = UIBezierPath.FromRect(new CGRect(group3.GetMinX() + NMath.Floor(group3.Width * 0.82051f + 0.5f), group3.GetMinY() + NMath.Floor(group3.Height * 0.40506f + 0.5f), NMath.Floor(group3.Width * 1.00000f + 0.5f) - NMath.Floor(group3.Width * 0.82051f + 0.5f), NMath.Floor(group3.Height * 0.49367f + 0.5f) - NMath.Floor(group3.Height * 0.40506f + 0.5f)));
                color2.SetFill();
                rectangle16Path.Fill();


                //// Rectangle 17 Drawing
                var rectangle17Path = UIBezierPath.FromRect(new CGRect(group3.GetMinX() + NMath.Floor(group3.Width * 0.41026f + 0.5f), group3.GetMinY() + NMath.Floor(group3.Height * 0.50633f + 0.5f), NMath.Floor(group3.Width * 0.58974f + 0.5f) - NMath.Floor(group3.Width * 0.41026f + 0.5f), NMath.Floor(group3.Height * 0.59494f + 0.5f) - NMath.Floor(group3.Height * 0.50633f + 0.5f)));
                _79b51c.SetFill();
                rectangle17Path.Fill();


                //// Rectangle 18 Drawing
                var rectangle18Path = UIBezierPath.FromRect(new CGRect(group3.GetMinX() + NMath.Floor(group3.Width * 0.00000f + 0.5f), group3.GetMinY() + NMath.Floor(group3.Height * 0.60759f + 0.5f), NMath.Floor(group3.Width * 0.17949f + 0.5f) - NMath.Floor(group3.Width * 0.00000f + 0.5f), NMath.Floor(group3.Height * 0.69620f + 0.5f) - NMath.Floor(group3.Height * 0.60759f + 0.5f)));
                color2.SetFill();
                rectangle18Path.Fill();


                //// Rectangle 19 Drawing
                var rectangle19Path = UIBezierPath.FromRect(new CGRect(group3.GetMinX() + NMath.Floor(group3.Width * 0.20513f + 0.5f), group3.GetMinY() + NMath.Floor(group3.Height * 0.50633f + 0.5f), NMath.Floor(group3.Width * 0.38462f + 0.5f) - NMath.Floor(group3.Width * 0.20513f + 0.5f), NMath.Floor(group3.Height * 0.59494f + 0.5f) - NMath.Floor(group3.Height * 0.50633f + 0.5f)));
                color.SetFill();
                rectangle19Path.Fill();


                //// Rectangle 20 Drawing
                var rectangle20Path = UIBezierPath.FromRect(new CGRect(group3.GetMinX() + NMath.Floor(group3.Width * 0.41026f + 0.5f), group3.GetMinY() + NMath.Floor(group3.Height * 0.60759f + 0.5f), NMath.Floor(group3.Width * 0.58974f + 0.5f) - NMath.Floor(group3.Width * 0.41026f + 0.5f), NMath.Floor(group3.Height * 0.69620f + 0.5f) - NMath.Floor(group3.Height * 0.60759f + 0.5f)));
                color5.SetFill();
                rectangle20Path.Fill();


                //// Rectangle 21 Drawing
                var rectangle21Path = UIBezierPath.FromRect(new CGRect(group3.GetMinX() + NMath.Floor(group3.Width * 0.61538f + 0.5f), group3.GetMinY() + NMath.Floor(group3.Height * 0.60759f + 0.5f), NMath.Floor(group3.Width * 0.79487f + 0.5f) - NMath.Floor(group3.Width * 0.61538f + 0.5f), NMath.Floor(group3.Height * 0.69620f + 0.5f) - NMath.Floor(group3.Height * 0.60759f + 0.5f)));
                color4.SetFill();
                rectangle21Path.Fill();


                //// Rectangle 22 Drawing
                var rectangle22Path = UIBezierPath.FromRect(new CGRect(group3.GetMinX() + NMath.Floor(group3.Width * 0.61538f + 0.5f), group3.GetMinY() + NMath.Floor(group3.Height * 0.70886f + 0.5f), NMath.Floor(group3.Width * 0.79487f + 0.5f) - NMath.Floor(group3.Width * 0.61538f + 0.5f), NMath.Floor(group3.Height * 0.79747f + 0.5f) - NMath.Floor(group3.Height * 0.70886f + 0.5f)));
                color.SetFill();
                rectangle22Path.Fill();


                //// Rectangle 23 Drawing
                var rectangle23Path = UIBezierPath.FromRect(new CGRect(group3.GetMinX() + NMath.Floor(group3.Width * 0.61538f + 0.5f), group3.GetMinY() + NMath.Floor(group3.Height * 0.81013f + 0.5f), NMath.Floor(group3.Width * 0.79487f + 0.5f) - NMath.Floor(group3.Width * 0.61538f + 0.5f), NMath.Floor(group3.Height * 0.89873f + 0.5f) - NMath.Floor(group3.Height * 0.81013f + 0.5f)));
                color5.SetFill();
                rectangle23Path.Fill();


                //// Rectangle 24 Drawing
                var rectangle24Path = UIBezierPath.FromRect(new CGRect(group3.GetMinX() + NMath.Floor(group3.Width * 0.82051f + 0.5f), group3.GetMinY() + NMath.Floor(group3.Height * 0.81013f + 0.5f), NMath.Floor(group3.Width * 1.00000f + 0.5f) - NMath.Floor(group3.Width * 0.82051f + 0.5f), NMath.Floor(group3.Height * 0.89873f + 0.5f) - NMath.Floor(group3.Height * 0.81013f + 0.5f)));
                _79b51c.SetFill();
                rectangle24Path.Fill();


                //// Group
                {
                    //// Rectangle 25 Drawing
                    var rectangle25Path = UIBezierPath.FromRect(new CGRect(group3.GetMinX() + NMath.Floor(group3.Width * 0.82051f + 0.5f), group3.GetMinY() + NMath.Floor(group3.Height * 0.91139f + 0.5f), NMath.Floor(group3.Width * 1.00000f + 0.5f) - NMath.Floor(group3.Width * 0.82051f + 0.5f), NMath.Floor(group3.Height * 1.00000f + 0.5f) - NMath.Floor(group3.Height * 0.91139f + 0.5f)));
                    color2.SetFill();
                    rectangle25Path.Fill();
                }
            }
        }
    }
}

