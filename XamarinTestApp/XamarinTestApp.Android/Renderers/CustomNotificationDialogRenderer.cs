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


using Android.Graphics.Drawables;
using Android.Graphics;
using XamarinTestApp.Droid.Renderers;
using Xamarin.Forms;
using XamarinTestApp.Controls;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomNotifcationDialog), typeof(CustomNotificationDialogRenderer))]
namespace XamarinTestApp.Droid.Renderers
{
    public class CustomNotificationDialogRenderer : ViewRenderer<CustomNotifcationDialog, Android.Views.View>
    {
        public CustomNotificationDialogRenderer()
        {
            this.SetWillNotDraw(false);
        }

        protected override void OnElementChanged(ElementChangedEventArgs<CustomNotifcationDialog> e)
        {
            base.OnElementChanged(e);
            if (Control == null)
            {
                var circleDotView = new Android.Views.View(Forms.Context);
                SetNativeControl(circleDotView);
            }
        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            //if (e.PropertyName == CustomNotifcationDialog.ActiveProperty.PropertyName)
            //{
                Invalidate();
            //}
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
            private static Paint paint = new Paint();
            private static RectF bezier2Rect = new RectF();
            private static Path bezier2Path = new Path();
        }
    }
}

/*
[assembly: ExportRenderer(typeof(CircleDot), typeof(CircleDotRenderer))]
namespace DevProtocol.Xam.CircleDotDemo.Droid.Renderers
{
	public class CircleDotRenderer: ViewRenderer<CircleDot, Android.Views.View>
	{
		public CircleDotRenderer()
		{
			this.SetWillNotDraw(false);
		}

		protected override void OnElementChanged(ElementChangedEventArgs<CircleDot> e)
		{
			base.OnElementChanged(e);
			if (Control == null)
			{
				var circleDotView = new Android.Views.View(Forms.Context);
				SetNativeControl(circleDotView);
			}
		}

		protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);
			if (e.PropertyName == CircleDot.ActiveProperty.PropertyName)
			{
				Invalidate();
			}
		}*/

//Code generated from PaintCodeApp
/*
 package com.example.project;

import android.graphics.Paint;
import android.graphics.RectF;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Path;


public class StyleKitName
{

    
    public enum ResizingBehavior
    {
        AspectFit, 
        AspectFill, 
        Stretch, 
        Center, 
    }
    
    private static class CacheForCanvas1
    {
        private static Paint paint = new Paint();
        private static RectF bezier2Rect = new RectF();
        private static Path bezier2Path = new Path();
    }


    public static void drawCanvas1(Canvas canvas, RectF frame)
    {
        Paint paint = CacheForCanvas1.paint;
        
        int color2 = Color.argb(255, 13, 24, 41);
        
        RectF bezier2Rect = CacheForCanvas1.bezier2Rect;
        bezier2Rect.set(frame.right - 211.89f,
            frame.top + 9.4f,
            frame.right - 9.26f,
            frame.top + 87.69f);
        Path bezier2Path = CacheForCanvas1.bezier2Path;
        bezier2Path.reset();
        bezier2Path.moveTo(frame.left + frame.width() * 0.95789f, frame.top + frame.height() * 0.09893f);
        bezier2Path.cubicTo(frame.left + frame.width() * 0.95789f, frame.top + frame.height() * 0.0989f, frame.left + frame.width() * 0.95789f, frame.top + frame.height() * 0.73626f, frame.left + frame.width() * 0.95789f, frame.top + frame.height() * 0.73626f);
        bezier2Path.lineTo(frame.left + frame.width() * 0.25538f, frame.top + frame.height() * 0.73626f);
        bezier2Path.cubicTo(frame.left + frame.width() * 0.22263f, frame.top + frame.height() * 0.81115f, frame.left + frame.width() * 0.17368f, frame.top + frame.height() * 0.92308f, frame.left + frame.width() * 0.17368f, frame.top + frame.height() * 0.92308f);
        bezier2Path.cubicTo(frame.left + frame.width() * 0.17368f, frame.top + frame.height() * 0.92308f, frame.left + frame.width() * 0.17368f, frame.top + frame.height() * 0.81115f, frame.left + frame.width() * 0.17368f, frame.top + frame.height() * 0.73626f);
        bezier2Path.lineTo(frame.left + frame.width() * 0.03684f, frame.top + frame.height() * 0.73626f);
        bezier2Path.lineTo(frame.left + frame.width() * 0.03684f, frame.top + frame.height() * 0.0989f);
        bezier2Path.lineTo(frame.left + frame.width() * 0.95789f, frame.top + frame.height() * 0.0989f);
        bezier2Path.lineTo(frame.left + frame.width() * 0.95789f, frame.top + frame.height() * 0.09893f);
        bezier2Path.close();

        paint.reset();
        paint.setFlags(Paint.ANTI_ALIAS_FLAG);
        paint.setStyle(Paint.Style.FILL);
        paint.setColor(color2);
        canvas.drawPath(bezier2Path, paint);

        paint.reset();
        paint.setFlags(Paint.ANTI_ALIAS_FLAG);
        paint.setStrokeWidth(2f);
        paint.setStrokeMiter(10f);
        canvas.save();
        paint.setStyle(Paint.Style.STROKE);
        paint.setColor(Color.WHITE);
        canvas.drawPath(bezier2Path, paint);
        canvas.restore();
    }
    
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
