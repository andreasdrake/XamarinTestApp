using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamarinTestApp.Droid.Renderers;
using Xamarin.Forms;
using XamarinTestApp.Controls;
using Xamarin.Forms.Platform.Android;
using Android.Graphics;
using Android.Util;

[assembly: ExportRenderer(typeof(CircleControl), typeof(CircleControlRenderer))]
namespace XamarinTestApp.Droid.Renderers
{
    public class CircleControlRenderer : BoxRenderer
    {
        private float _cornerRadius;
        private RectF _bounds;
        private Path _path;
        protected override void OnElementChanged(ElementChangedEventArgs<BoxView> e)
        {
            base.OnElementChanged(e);

            if (Element == null)
            {
                return;
            }
            var element = (CircleControl)Element;
            int radius = (int)(element.Width / 2);

            _cornerRadius = TypedValue.ApplyDimension(ComplexUnitType.Dip, (float)radius, Context.Resources.DisplayMetrics);

        }

        protected override void OnSizeChanged(int w, int h, int oldw, int oldh)
        {
            base.OnSizeChanged(w, h, oldw, oldh);
            if (w != oldw && h != oldh)
            {
                _bounds = new RectF(0, 0, w, h);
            }

            _path = new Path();
            _path.Reset();
            _path.AddRoundRect(_bounds, _cornerRadius, _cornerRadius, Path.Direction.Cw);
            _path.Close();
        }

        public override void Draw(Canvas canvas)
        {
            canvas.Save();
            canvas.ClipPath(_path);
            base.Draw(canvas);
            canvas.Restore();
        }
    }
}