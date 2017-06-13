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
using Xamarin.Forms;
using XamarinTestApp.Controls;
using XamarinTestApp.Droid.Renderers;
using Xamarin.Forms.Platform.Android;
using Android.Graphics;

[assembly: ExportRenderer(typeof(ConevoArrowActivityIndicator), typeof(ConevoArrowActivityIndicatorRenderer))]
namespace XamarinTestApp.Droid.Renderers
{
    public class ConevoArrowActivityIndicatorRenderer : ViewRenderer<ConevoArrowActivityIndicator, Android.Views.View>
    {
        public ConevoArrowActivityIndicatorRenderer()
        {
            SetWillNotDraw(false);
        }

        protected override void OnElementChanged(ElementChangedEventArgs<ConevoArrowActivityIndicator> e)
        {
            base.OnElementChanged(e);
            if (Control == null)
            {
                var conevoArrowView = new Android.Views.View(Forms.Context);
                SetNativeControl(conevoArrowView);
            }
        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            //if (e.PropertyName == CustomNotifcationDialog.ActiveProperty.PropertyName)
            //{
            //Invalidate();
            //}
        }
        protected override void OnDraw(Canvas canvas)
        {
            var element = this.Element;
            var rect = new Rect();
            GetDrawingRect(rect);

            DrawCanvas(canvas, new RectF( rect));
        }
        public enum ResizingBehavior
        {
            AspectFit,
            AspectFill,
            Stretch,
            Center,
        }

        private static class CacheForCanvas1
        {
            public static Paint paint = new Paint();
            public static RectF arrowGroup = new RectF();
            public static RectF r1Rect = new RectF();
            public static Path r1Path = new Path();
            public static RectF r2Rect = new RectF();
            public static Path r2Path = new Path();
            public static RectF r3Rect = new RectF();
            public static Path r3Path = new Path();
            public static RectF r4Rect = new RectF();
            public static Path r4Path = new Path();
            public static RectF r5Rect = new RectF();
            public static Path r5Path = new Path();
            public static RectF r6Rect = new RectF();
            public static Path r6Path = new Path();
            public static RectF r7Rect = new RectF();
            public static Path r7Path = new Path();
            public static RectF r8Rect = new RectF();
            public static Path r8Path = new Path();
            public static RectF r9Rect = new RectF();
            public static Path r9Path = new Path();
            public static RectF r10Rect = new RectF();
            public static Path r10Path = new Path();
            public static RectF r11Rect = new RectF();
            public static Path r11Path = new Path();
            public static RectF r12Rect = new RectF();
            public static Path r12Path = new Path();
            public static RectF r13Rect = new RectF();
            public static Path r13Path = new Path();
            public static RectF r14Rect = new RectF();
            public static Path r14Path = new Path();
            public static RectF r15Rect = new RectF();
            public static Path r15Path = new Path();
            public static RectF r16Rect = new RectF();
            public static Path r16Path = new Path();
            public static RectF r17Rect = new RectF();
            public static Path r17Path = new Path();
            public static RectF r18Rect = new RectF();
            public static Path r18Path = new Path();
            public static RectF r19Rect = new RectF();
            public static Path r19Path = new Path();
            public static RectF r20Rect = new RectF();
            public static Path r20Path = new Path();
            public static RectF r21Rect = new RectF();
            public static Path r21Path = new Path();
            public static RectF r22Rect = new RectF();
            public static Path r22Path = new Path();
            public static RectF r23Rect = new RectF();
            public static Path r23Path = new Path();
            public static RectF r24Rect = new RectF();
            public static Path r24Path = new Path();
            public static RectF r25Rect = new RectF();
            public static Path r25Path = new Path();
        }

        public static void DrawCanvas(Canvas canvas, RectF frame)
        {
            // General Declarations
            Paint paint = CacheForCanvas1.paint;

            // Local Colors
            Android.Graphics.Color color3 = Android.Graphics.Color.Argb(255, 174, 199, 4);
            Android.Graphics.Color color2 = Android.Graphics.Color.Argb(255, 19, 158, 47);
            Android.Graphics.Color color1 = Android.Graphics.Color.Argb(255, 121, 181, 28);
            Android.Graphics.Color color4 = Android.Graphics.Color.Argb(255, 0, 126, 49);
            Android.Graphics.Color color5 = Android.Graphics.Color.Argb(255, 1, 99, 47);

            // ArrowGroup
            {
                RectF arrowGroup = CacheForCanvas1.arrowGroup;
                arrowGroup.Set(frame.Left + 1f,
                    frame.Top + 1f,
                    frame.Right - 1f,
                    frame.Bottom - 1f);

                // r1
                RectF r1Rect = CacheForCanvas1.r1Rect;
                r1Rect.Set(arrowGroup.Left,
                    arrowGroup.Top,
                    arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.16667f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.08163f + 0.5f));
                Path r1Path = CacheForCanvas1.r1Path;
                r1Path.Reset();
                r1Path.MoveTo(r1Rect.Left, r1Rect.Top);
                r1Path.LineTo(r1Rect.Right, r1Rect.Top);
                r1Path.LineTo(r1Rect.Right, r1Rect.Bottom);
                r1Path.LineTo(r1Rect.Left, r1Rect.Bottom);
                r1Path.Close();

                paint.Reset();
                paint.Flags = PaintFlags.AntiAlias;
                
                paint.SetStyle(Paint.Style.Fill);
                paint.Color = color1;
                canvas.DrawPath(r1Path, paint);

                // r2
                RectF r2Rect = CacheForCanvas1.r2Rect;
                r2Rect.Set(arrowGroup.Left,
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.10204f + 0.5f),
                    arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.16667f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.18367f + 0.5f));
                Path r2Path = CacheForCanvas1.r2Path;
                r2Path.Reset();
                r2Path.MoveTo(r2Rect.Left, r2Rect.Top);
                r2Path.LineTo(r2Rect.Right, r2Rect.Top);
                r2Path.LineTo(r2Rect.Right, r2Rect.Bottom);
                r2Path.LineTo(r2Rect.Left, r2Rect.Bottom);
                r2Path.Close();

                paint.Reset();
                paint.Flags = PaintFlags.AntiAlias;
                paint.SetStyle(Paint.Style.Fill);
                paint.Color=color2;
                canvas.DrawPath(r2Path, paint);

                // r3
                RectF r3Rect = CacheForCanvas1.r3Rect;
                r3Rect.Set(arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.20833f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.10204f + 0.5f),
                    arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.375f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.18367f + 0.5f));
                Path r3Path = CacheForCanvas1.r3Path;
                r3Path.Reset();
                r3Path.MoveTo(r3Rect.Left, r3Rect.Top);
                r3Path.LineTo(r3Rect.Right, r3Rect.Top);
                r3Path.LineTo(r3Rect.Right, r3Rect.Bottom);
                r3Path.LineTo(r3Rect.Left, r3Rect.Bottom);
                r3Path.Close();

                paint.Reset();
                paint.Flags = PaintFlags.AntiAlias;
                paint.SetStyle(Paint.Style.Fill);
                paint.Color=color3;
                canvas.DrawPath(r3Path, paint);

                // r4
                RectF r4Rect = CacheForCanvas1.r4Rect;
                r4Rect.Set(arrowGroup.Left,
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.20408f + 0.5f),
                    arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.16667f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.28571f + 0.5f));
                Path r4Path = CacheForCanvas1.r4Path;
                r4Path.Reset();
                r4Path.MoveTo(r4Rect.Left, r4Rect.Top);
                r4Path.LineTo(r4Rect.Right, r4Rect.Top);
                r4Path.LineTo(r4Rect.Right, r4Rect.Bottom);
                r4Path.LineTo(r4Rect.Left, r4Rect.Bottom);
                r4Path.Close();

                paint.Reset();
                paint.Flags = PaintFlags.AntiAlias;
                paint.SetStyle(Paint.Style.Fill);
                paint.Color=color4;
                canvas.DrawPath(r4Path, paint);

                // r5
                RectF r5Rect = CacheForCanvas1.r5Rect;
                r5Rect.Set(arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.20833f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.20408f + 0.5f),
                    arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.375f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.28571f + 0.5f));
                Path r5Path = CacheForCanvas1.r5Path;
                r5Path.Reset();
                r5Path.MoveTo(r5Rect.Left, r5Rect.Top);
                r5Path.LineTo(r5Rect.Right, r5Rect.Top);
                r5Path.LineTo(r5Rect.Right, r5Rect.Bottom);
                r5Path.LineTo(r5Rect.Left, r5Rect.Bottom);
                r5Path.Close();

                paint.Reset();
                paint.Flags = PaintFlags.AntiAlias;
                paint.SetStyle(Paint.Style.Fill);
                paint.Color=color5;
                canvas.DrawPath(r5Path, paint);

                // r6
                RectF r6Rect = CacheForCanvas1.r6Rect;
                r6Rect.Set(arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.41667f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.20408f + 0.5f),
                    arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.58333f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.28571f + 0.5f));
                Path r6Path = CacheForCanvas1.r6Path;
                r6Path.Reset();
                r6Path.MoveTo(r6Rect.Left, r6Rect.Top);
                r6Path.LineTo(r6Rect.Right, r6Rect.Top);
                r6Path.LineTo(r6Rect.Right, r6Rect.Bottom);
                r6Path.LineTo(r6Rect.Left, r6Rect.Bottom);
                r6Path.Close();

                paint.Reset();
                paint.Flags = PaintFlags.AntiAlias;
                paint.SetStyle(Paint.Style.Fill);
                paint.Color=color1;
                canvas.DrawPath(r6Path, paint);

                // r7
                RectF r7Rect = CacheForCanvas1.r7Rect;
                r7Rect.Set(arrowGroup.Left,
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.30612f + 0.5f),
                    arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.16667f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.38776f + 0.5f));
                Path r7Path = CacheForCanvas1.r7Path;
                r7Path.Reset();
                r7Path.MoveTo(r7Rect.Left, r7Rect.Top);
                r7Path.LineTo(r7Rect.Right, r7Rect.Top);
                r7Path.LineTo(r7Rect.Right, r7Rect.Bottom);
                r7Path.LineTo(r7Rect.Left, r7Rect.Bottom);
                r7Path.Close();

                paint.Reset();
                paint.Flags = PaintFlags.AntiAlias;
                paint.SetStyle(Paint.Style.Fill);
                paint.Color=color3;
                canvas.DrawPath(r7Path, paint);

                // r8
                RectF r8Rect = CacheForCanvas1.r8Rect;
                r8Rect.Set(arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.20833f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.30612f + 0.5f),
                    arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.375f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.38776f + 0.5f));
                Path r8Path = CacheForCanvas1.r8Path;
                r8Path.Reset();
                r8Path.MoveTo(r8Rect.Left, r8Rect.Top);
                r8Path.LineTo(r8Rect.Right, r8Rect.Top);
                r8Path.LineTo(r8Rect.Right, r8Rect.Bottom);
                r8Path.LineTo(r8Rect.Left, r8Rect.Bottom);
                r8Path.Close();

                paint.Reset();
                paint.Flags = PaintFlags.AntiAlias;
                paint.SetStyle(Paint.Style.Fill);
                paint.Color=color2;
                canvas.DrawPath(r8Path, paint);

                // r9
                RectF r9Rect = CacheForCanvas1.r9Rect;
                r9Rect.Set(arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.41667f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.30612f + 0.5f),
                    arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.58333f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.38776f + 0.5f));
                Path r9Path = CacheForCanvas1.r9Path;
                r9Path.Reset();
                r9Path.MoveTo(r9Rect.Left, r9Rect.Top);
                r9Path.LineTo(r9Rect.Right, r9Rect.Top);
                r9Path.LineTo(r9Rect.Right, r9Rect.Bottom);
                r9Path.LineTo(r9Rect.Left, r9Rect.Bottom);
                r9Path.Close();

                paint.Reset();
                paint.Flags = PaintFlags.AntiAlias;
                paint.SetStyle(Paint.Style.Fill);
                paint.Color=color4;
                canvas.DrawPath(r9Path, paint);

                // r10
                RectF r10Rect = CacheForCanvas1.r10Rect;
                r10Rect.Set(arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.625f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.30612f + 0.5f),
                    arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.79167f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.38776f + 0.5f));
                Path r10Path = CacheForCanvas1.r10Path;
                r10Path.Reset();
                r10Path.MoveTo(r10Rect.Left, r10Rect.Top);
                r10Path.LineTo(r10Rect.Right, r10Rect.Top);
                r10Path.LineTo(r10Rect.Right, r10Rect.Bottom);
                r10Path.LineTo(r10Rect.Left, r10Rect.Bottom);
                r10Path.Close();

                paint.Reset();
                paint.Flags = PaintFlags.AntiAlias;
                paint.SetStyle(Paint.Style.Fill);
                paint.Color=color2;
                canvas.DrawPath(r10Path, paint);

                // r11
                RectF r11Rect = CacheForCanvas1.r11Rect;
                r11Rect.Set(arrowGroup.Left,
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.40816f + 0.5f),
                    arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.16667f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.4898f + 0.5f));
                Path r11Path = CacheForCanvas1.r11Path;
                r11Path.Reset();
                r11Path.MoveTo(r11Rect.Left, r11Rect.Top);
                r11Path.LineTo(r11Rect.Right, r11Rect.Top);
                r11Path.LineTo(r11Rect.Right, r11Rect.Bottom);
                r11Path.LineTo(r11Rect.Left, r11Rect.Bottom);
                r11Path.Close();

                paint.Reset();
                paint.Flags = PaintFlags.AntiAlias;
                paint.SetStyle(Paint.Style.Fill);
                paint.Color=color1;
                canvas.DrawPath(r11Path, paint);

                // r12
                RectF r12Rect = CacheForCanvas1.r12Rect;
                r12Rect.Set(arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.20833f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.40816f + 0.5f),
                    arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.375f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.4898f + 0.5f));
                Path r12Path = CacheForCanvas1.r12Path;
                r12Path.Reset();
                r12Path.MoveTo(r12Rect.Left, r12Rect.Top);
                r12Path.LineTo(r12Rect.Right, r12Rect.Top);
                r12Path.LineTo(r12Rect.Right, r12Rect.Bottom);
                r12Path.LineTo(r12Rect.Left, r12Rect.Bottom);
                r12Path.Close();

                paint.Reset();
                paint.Flags = PaintFlags.AntiAlias;
                paint.SetStyle(Paint.Style.Fill);
                paint.Color=color4;
                canvas.DrawPath(r12Path, paint);

                // r13
                RectF r13Rect = CacheForCanvas1.r13Rect;
                r13Rect.Set(arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.41667f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.40816f + 0.5f),
                    arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.58333f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.4898f + 0.5f));
                Path r13Path = CacheForCanvas1.r13Path;
                r13Path.Reset();
                r13Path.MoveTo(r13Rect.Left, r13Rect.Top);
                r13Path.LineTo(r13Rect.Right, r13Rect.Top);
                r13Path.LineTo(r13Rect.Right, r13Rect.Bottom);
                r13Path.LineTo(r13Rect.Left, r13Rect.Bottom);
                r13Path.Close();

                paint.Reset();
                paint.Flags = PaintFlags.AntiAlias;
                paint.SetStyle(Paint.Style.Fill);
                paint.Color=color5;
                canvas.DrawPath(r13Path, paint);

                // r14
                RectF r14Rect = CacheForCanvas1.r14Rect;
                r14Rect.Set(arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.625f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.40816f + 0.5f),
                    arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.79167f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.4898f + 0.5f));
                Path r14Path = CacheForCanvas1.r14Path;
                r14Path.Reset();
                r14Path.MoveTo(r14Rect.Left, r14Rect.Top);
                r14Path.LineTo(r14Rect.Right, r14Rect.Top);
                r14Path.LineTo(r14Rect.Right, r14Rect.Bottom);
                r14Path.LineTo(r14Rect.Left, r14Rect.Bottom);
                r14Path.Close();

                paint.Reset();
                paint.Flags = PaintFlags.AntiAlias;
                paint.SetStyle(Paint.Style.Fill);
                paint.Color=color1;
                canvas.DrawPath(r14Path, paint);

                // r15
                RectF r15Rect = CacheForCanvas1.r15Rect;
                r15Rect.Set(arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.83333f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.40816f + 0.5f),
                    arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.4898f + 0.5f));
                Path r15Path = CacheForCanvas1.r15Path;
                r15Path.Reset();
                r15Path.MoveTo(r15Rect.Left, r15Rect.Top);
                r15Path.LineTo(r15Rect.Right, r15Rect.Top);
                r15Path.LineTo(r15Rect.Right, r15Rect.Bottom);
                r15Path.LineTo(r15Rect.Left, r15Rect.Bottom);
                r15Path.Close();

                paint.Reset();
                paint.Flags = PaintFlags.AntiAlias;
                paint.SetStyle(Paint.Style.Fill);
                paint.Color=color2;
                canvas.DrawPath(r15Path, paint);

                // r16
                RectF r16Rect = CacheForCanvas1.r16Rect;
                r16Rect.Set(arrowGroup.Left,
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.5102f + 0.5f),
                    arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.16667f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.59184f + 0.5f));
                Path r16Path = CacheForCanvas1.r16Path;
                r16Path.Reset();
                r16Path.MoveTo(r16Rect.Left, r16Rect.Top);
                r16Path.LineTo(r16Rect.Right, r16Rect.Top);
                r16Path.LineTo(r16Rect.Right, r16Rect.Bottom);
                r16Path.LineTo(r16Rect.Left, r16Rect.Bottom);
                r16Path.Close();

                paint.Reset();
                paint.Flags = PaintFlags.AntiAlias;
                paint.SetStyle(Paint.Style.Fill);
                paint.Color=color5;
                canvas.DrawPath(r16Path, paint);

                // r17
                RectF r17Rect = CacheForCanvas1.r17Rect;
                r17Rect.Set(arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.20833f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.5102f + 0.5f),
                    arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.375f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.59184f + 0.5f));
                Path r17Path = CacheForCanvas1.r17Path;
                r17Path.Reset();
                r17Path.MoveTo(r17Rect.Left, r17Rect.Top);
                r17Path.LineTo(r17Rect.Right, r17Rect.Top);
                r17Path.LineTo(r17Rect.Right, r17Rect.Bottom);
                r17Path.LineTo(r17Rect.Left, r17Rect.Bottom);
                r17Path.Close();

                paint.Reset();
                paint.Flags = PaintFlags.AntiAlias;
                paint.SetStyle(Paint.Style.Fill);
                paint.Color=color3;
                canvas.DrawPath(r17Path, paint);

                // r18
                RectF r18Rect = CacheForCanvas1.r18Rect;
                r18Rect.Set(arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.41667f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.5102f + 0.5f),
                    arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.58333f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.59184f + 0.5f));
                Path r18Path = CacheForCanvas1.r18Path;
                r18Path.Reset();
                r18Path.MoveTo(r18Rect.Left, r18Rect.Top);
                r18Path.LineTo(r18Rect.Right, r18Rect.Top);
                r18Path.LineTo(r18Rect.Right, r18Rect.Bottom);
                r18Path.LineTo(r18Rect.Left, r18Rect.Bottom);
                r18Path.Close();

                paint.Reset();
                paint.Flags = PaintFlags.AntiAlias;
                paint.SetStyle(Paint.Style.Fill);
                paint.Color=color1;
                canvas.DrawPath(r18Path, paint);

                // r19
                RectF r19Rect = CacheForCanvas1.r19Rect;
                r19Rect.Set(arrowGroup.Left,
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.61224f + 0.5f),
                    arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.16667f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.69388f + 0.5f));
                Path r19Path = CacheForCanvas1.r19Path;
                r19Path.Reset();
                r19Path.MoveTo(r19Rect.Left, r19Rect.Top);
                r19Path.LineTo(r19Rect.Right, r19Rect.Top);
                r19Path.LineTo(r19Rect.Right, r19Rect.Bottom);
                r19Path.LineTo(r19Rect.Left, r19Rect.Bottom);
                r19Path.Close();

                paint.Reset();
                paint.Flags = PaintFlags.AntiAlias;
                paint.SetStyle(Paint.Style.Fill);
                paint.Color=color2;
                canvas.DrawPath(r19Path, paint);

                // r20
                RectF r20Rect = CacheForCanvas1.r20Rect;
                r20Rect.Set(arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.41667f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.61224f + 0.5f),
                    arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.58333f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.69388f + 0.5f));
                Path r20Path = CacheForCanvas1.r20Path;
                r20Path.Reset();
                r20Path.MoveTo(r20Rect.Left, r20Rect.Top);
                r20Path.LineTo(r20Rect.Right, r20Rect.Top);
                r20Path.LineTo(r20Rect.Right, r20Rect.Bottom);
                r20Path.LineTo(r20Rect.Left, r20Rect.Bottom);
                r20Path.Close();

                paint.Reset();
                paint.Flags = PaintFlags.AntiAlias;
                paint.SetStyle(Paint.Style.Fill);
                paint.Color=color4;
                canvas.DrawPath(r20Path, paint);

                // r21
                RectF r21Rect = CacheForCanvas1.r21Rect;
                r21Rect.Set(arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.625f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.61224f + 0.5f),
                    arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.79167f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.69388f + 0.5f));
                Path r21Path = CacheForCanvas1.r21Path;
                r21Path.Reset();
                r21Path.MoveTo(r21Rect.Left, r21Rect.Top);
                r21Path.LineTo(r21Rect.Right, r21Rect.Top);
                r21Path.LineTo(r21Rect.Right, r21Rect.Bottom);
                r21Path.LineTo(r21Rect.Left, r21Rect.Bottom);
                r21Path.Close();

                paint.Reset();
                paint.Flags = PaintFlags.AntiAlias;
                paint.SetStyle(Paint.Style.Fill);
                paint.Color=color5;
                canvas.DrawPath(r21Path, paint);

                // r22
                RectF r22Rect = CacheForCanvas1.r22Rect;
                r22Rect.Set(arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.625f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.71429f + 0.5f),
                    arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.79167f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.79592f + 0.5f));
                Path r22Path = CacheForCanvas1.r22Path;
                r22Path.Reset();
                r22Path.MoveTo(r22Rect.Left, r22Rect.Top);
                r22Path.LineTo(r22Rect.Right, r22Rect.Top);
                r22Path.LineTo(r22Rect.Right, r22Rect.Bottom);
                r22Path.LineTo(r22Rect.Left, r22Rect.Bottom);
                r22Path.Close();

                paint.Reset();
                paint.Flags = PaintFlags.AntiAlias;
                paint.SetStyle(Paint.Style.Fill);
                paint.Color=color3;
                canvas.DrawPath(r22Path, paint);

                // r23
                RectF r23Rect = CacheForCanvas1.r23Rect;
                r23Rect.Set(arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.625f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.81633f + 0.5f),
                    arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.79167f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.89796f + 0.5f));
                Path r23Path = CacheForCanvas1.r23Path;
                r23Path.Reset();
                r23Path.MoveTo(r23Rect.Left, r23Rect.Top);
                r23Path.LineTo(r23Rect.Right, r23Rect.Top);
                r23Path.LineTo(r23Rect.Right, r23Rect.Bottom);
                r23Path.LineTo(r23Rect.Left, r23Rect.Bottom);
                r23Path.Close();

                paint.Reset();
                paint.Flags = PaintFlags.AntiAlias;
                paint.SetStyle(Paint.Style.Fill);
                paint.Color=color4;
                canvas.DrawPath(r23Path, paint);

                // r24
                RectF r24Rect = CacheForCanvas1.r24Rect;
                r24Rect.Set(arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.83333f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.81633f + 0.5f),
                    arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.89796f + 0.5f));
                Path r24Path = CacheForCanvas1.r24Path;
                r24Path.Reset();
                r24Path.MoveTo(r24Rect.Left, r24Rect.Top);
                r24Path.LineTo(r24Rect.Right, r24Rect.Top);
                r24Path.LineTo(r24Rect.Right, r24Rect.Bottom);
                r24Path.LineTo(r24Rect.Left, r24Rect.Bottom);
                r24Path.Close();

                paint.Reset();
                paint.Flags = PaintFlags.AntiAlias;
                paint.SetStyle(Paint.Style.Fill);
                paint.Color=color1;
                canvas.DrawPath(r24Path, paint);

                // r25
                RectF r25Rect = CacheForCanvas1.r25Rect;
                r25Rect.Set(arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() * 0.83333f + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() * 0.91837f + 0.5f),
                    arrowGroup.Left + (float)Math.Floor(arrowGroup.Width() + 0.5f),
                    arrowGroup.Top + (float)Math.Floor(arrowGroup.Height() + 0.5f));
                Path r25Path = CacheForCanvas1.r25Path;
                r25Path.Reset();
                r25Path.MoveTo(r25Rect.Left, r25Rect.Top);
                r25Path.LineTo(r25Rect.Right, r25Rect.Top);
                r25Path.LineTo(r25Rect.Right, r25Rect.Bottom);
                r25Path.LineTo(r25Rect.Left, r25Rect.Bottom);
                r25Path.Close();

                paint.Reset();
                paint.Flags = PaintFlags.AntiAlias;
                paint.SetStyle(Paint.Style.Fill);
                paint.Color=color2;
                canvas.DrawPath(r25Path, paint);
            }
        }
    }
}

/*
 package com.example.project;

import android.graphics.Paint;
import android.graphics.RectF;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Path;


    
public class StyleKitName
{


   

   


    


    // Resizing Behavior
    public static void resizingBehaviorApply(ResizingBehavior behavior, RectF rect, RectF target, RectF result)
    {
        if (rect.equals(target) || target == null)
        {
            result.set(rect);
            return;
        }

        if (behavior == ResizingBehavior.Stretch)
        {
            result.set(target);
            return;
        }

        float xRatio = Math.abs(target.width() / rect.width());
        float yRatio = Math.abs(target.height() / rect.height());
        float scale = 0f;

        switch (behavior)
        {
            case AspectFit:
                {
                    scale = Math.min(xRatio, yRatio);
                    break;
                }
            case AspectFill:
                {
                    scale = Math.max(xRatio, yRatio);
                    break;
                }
            case Center:
                {
                    scale = 1f;
                    break;
                }
        }

        float newWidth = Math.abs(rect.width() * scale);
        float newHeight = Math.abs(rect.height() * scale);
        result.set(target.centerX() - newWidth / 2,
            target.centerY() - newHeight / 2,
            target.centerX() + newWidth / 2,
            target.centerY() + newHeight / 2);
    }


}
     */