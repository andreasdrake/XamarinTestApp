using System.ComponentModel;
using CoreGraphics;

using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinTestApp.iOS.Renderers;
using XamarinTestApp.Controls;

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
            DrawCircleDot(rect, Element.FillColor.ToUIColor(), Color.White.ToUIColor());
        }

        private void DrawCircleDot(CGRect frame, UIColor colorFill, UIColor colorStroke)
        {
            //var circleDotStrokePath = UIBezierPath.FromOval(new CGRect(frame.GetMinX() + 1.0f, frame.GetMinY() + 1.0f, frame.Width - 2.0f, frame.Height - 2.0f));
            //colorStroke.SetStroke();
            //circleDotStrokePath.LineWidth = 1.5f;
            //circleDotStrokePath.Stroke();

            //return;



            // Color Declarations
            var color2 = colorFill;// UIColor.FromRGBA(0.051f, 0.094f, 0.161f, 1.000f);

            //// Bezier 2 Drawing
            var bezier2Path = new UIBezierPath();
            bezier2Path.MoveTo(new CGPoint(frame.GetMinX() + 0.95789f * frame.Width, frame.GetMinY() + 0.09893f * frame.Height));
            bezier2Path.AddCurveToPoint(new CGPoint(frame.GetMinX() + 0.95789f * frame.Width, frame.GetMinY() + 0.73626f * frame.Height), new CGPoint(frame.GetMinX() + 0.95789f * frame.Width, frame.GetMinY() + 0.09890f * frame.Height), new CGPoint(frame.GetMinX() + 0.95789f * frame.Width, frame.GetMinY() + 0.73626f * frame.Height));
            bezier2Path.AddLineTo(new CGPoint(frame.GetMinX() + 0.25538f * frame.Width, frame.GetMinY() + 0.73626f * frame.Height));
            bezier2Path.AddCurveToPoint(new CGPoint(frame.GetMinX() + 0.17368f * frame.Width, frame.GetMinY() + 0.92308f * frame.Height), new CGPoint(frame.GetMinX() + 0.22263f * frame.Width, frame.GetMinY() + 0.81115f * frame.Height), new CGPoint(frame.GetMinX() + 0.17368f * frame.Width, frame.GetMinY() + 0.92308f * frame.Height));
            bezier2Path.AddCurveToPoint(new CGPoint(frame.GetMinX() + 0.17368f * frame.Width, frame.GetMinY() + 0.73626f * frame.Height), new CGPoint(frame.GetMinX() + 0.17368f * frame.Width, frame.GetMinY() + 0.92308f * frame.Height), new CGPoint(frame.GetMinX() + 0.17368f * frame.Width, frame.GetMinY() + 0.81115f * frame.Height));
            bezier2Path.AddLineTo(new CGPoint(frame.GetMinX() + 0.03684f * frame.Width, frame.GetMinY() + 0.73626f * frame.Height));
            bezier2Path.AddLineTo(new CGPoint(frame.GetMinX() + 0.03684f * frame.Width, frame.GetMinY() + 0.09890f * frame.Height));
            bezier2Path.AddLineTo(new CGPoint(frame.GetMinX() + 0.95789f * frame.Width, frame.GetMinY() + 0.09890f * frame.Height));
            bezier2Path.AddLineTo(new CGPoint(frame.GetMinX() + 0.95789f * frame.Width, frame.GetMinY() + 0.09893f * frame.Height));
            bezier2Path.ClosePath();
            color2.SetFill();
            bezier2Path.Fill();
            UIColor.White.SetStroke();
            bezier2Path.LineWidth = 2.0f;
            bezier2Path.Stroke();
        }


    }
}
