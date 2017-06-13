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
/*

NY

package com.example.project;

import android.graphics.Paint;
import android.graphics.PorterDuff;
import android.graphics.PorterDuffXfermode;
import android.graphics.RectF;
import android.graphics.BlurMaskFilter;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Path;

    
public class StyleKitName
{
    private static class GlobalCache
    {
        static PorterDuffXfermode blendModeSourceIn = new PorterDuffXfermode(PorterDuff.Mode.SRC_IN);
    }

    // Resizing Behavior
    public enum ResizingBehavior
    {
        AspectFit, //!< The content is proportionally resized to fit into the target rectangle.
        AspectFill, //!< The content is proportionally resized to completely fill the target rectangle.
        Stretch, //!< The content is stretched to match the entire target rectangle.
        Center, //!< The content is centered in the target rectangle, but it is NOT resized.
    }

    // In Trial version of PaintCode, the code generation is limited to 3 canvases.

    // Canvas Drawings
    // Tab

    private static class CacheForCanvas1
    {
        private static Paint paint = new Paint();
        private static Paint shadowPaint = new Paint();
        private static PaintCodeShadow shadow = new PaintCodeShadow();
        private static RectF bezier2Rect = new RectF();
        private static Path bezier2Path = new Path();
    }


    public static void drawCanvas1(Canvas canvas, RectF frame)
    {
        // General Declarations
        Paint paint = CacheForCanvas1.paint;

        // Local Colors
        int color3 = Color.argb(255, 97, 87, 255);

        // Local Shadows
        PaintCodeShadow shadow = CacheForCanvas1.shadow.get(PaintCodeColor.colorByChangingAlpha(Color.BLACK, 64), 3f, 3f, 5f);

        // Bezier 2
        RectF bezier2Rect = CacheForCanvas1.bezier2Rect;
        bezier2Rect.set(frame.left,
            frame.top,
            frame.left + 219f,
            frame.top + 74f);
        Path bezier2Path = CacheForCanvas1.bezier2Path;
        bezier2Path.reset();
        bezier2Path.moveTo(frame.left, frame.top + frame.height() * 0.93814f);
        bezier2Path.lineTo(frame.left + frame.width(), frame.top + frame.height() * 0.93814f);
        bezier2Path.lineTo(frame.left + frame.width(), frame.top);
        bezier2Path.lineTo(frame.left, frame.top);
        bezier2Path.lineTo(frame.left, frame.top + frame.height() * 0.93814f);
        bezier2Path.close();
        bezier2Path.moveTo(frame.left + frame.width() * 0.11062f, frame.top + frame.height() * 0.93814f);
        bezier2Path.lineTo(frame.left + frame.width() * 0.12832f, frame.top + frame.height());
        bezier2Path.lineTo(frame.left + frame.width() * 0.15044f, frame.top + frame.height() * 0.93814f);
        bezier2Path.lineTo(frame.left + frame.width() * 0.11062f, frame.top + frame.height() * 0.93814f);
        bezier2Path.close();

        paint.reset();
        paint.setFlags(Paint.ANTI_ALIAS_FLAG);
        canvas.saveLayerAlpha(null, 255, Canvas.ALL_SAVE_FLAG);
        {
            canvas.translate(shadow.dx, shadow.dy);

            Paint shadowPaint = CacheForCanvas1.shadowPaint;
            shadowPaint.set(paint);
            shadow.setBlurOfPaint(shadowPaint);
            canvas.drawPath(bezier2Path, shadowPaint);
            shadowPaint.setXfermode(GlobalCache.blendModeSourceIn);
            canvas.saveLayer(null, shadowPaint, Canvas.ALL_SAVE_FLAG);
            {
                canvas.drawColor(shadow.color);
            }
            canvas.restore();
        }
        canvas.restore();
        paint.setStyle(Paint.Style.FILL);
        paint.setColor(color3);
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

class PaintCodeColor extends Color
{
    private static float[] ColorToHSV(int originalColor)
{
    float hsv[] = new float[3];
    RGBToHSV(red(originalColor), green(originalColor), blue(originalColor), hsv);
    return hsv;
}

public static int colorByChangingHue(int originalColor, float newHue)
{
    float hsv[] = ColorToHSV(originalColor);
    hsv[0] = newHue;
    return HSVToColor(alpha(originalColor), hsv);
}

public static int colorByChangingSaturation(int originalColor, float newSaturation)
{
    float hsv[] = ColorToHSV(originalColor);
    hsv[1] = newSaturation;
    return HSVToColor(alpha(originalColor), hsv);
}

public static int colorByChangingValue(int originalColor, float newValue)
{
    float hsv[] = ColorToHSV(originalColor);
    hsv[2] = newValue;
    return HSVToColor(alpha(originalColor), hsv);
}

public static float hue(int color)
{
    return ColorToHSV(color)[0];
}

public static float saturation(int color)
{
    return ColorToHSV(color)[1];
}

public static float brightness(int color)
{
    return ColorToHSV(color)[2];
}

public static int colorByChangingAlpha(int color, int newAlpha)
{
    return argb(newAlpha, red(color), green(color), blue(color));
}

public static int colorByBlendingColors(int c1, float ratio, int c2)
{
    return argb((int)((1f - ratio) * alpha(c1) + ratio * alpha(c2)),
        (int)((1f - ratio) * red(c1) + ratio * red(c2)),
        (int)((1f - ratio) * green(c1) + ratio * green(c2)),
        (int)((1f - ratio) * blue(c1) + ratio * blue(c2)));
}

public static int colorByApplyingHighlight(int color, float ratio)
{
    return colorByBlendingColors(color, ratio, colorByChangingAlpha(WHITE, alpha(color)));
}

public static int colorByApplyingShadow(int color, float ratio)
{
    return colorByBlendingColors(color, ratio, colorByChangingAlpha(BLACK, alpha(color)));
}
}
class PaintCodeShadow
{
    int color;
    float dx, dy;
    private float radius;
    private BlurMaskFilter blurMaskFilter;

    PaintCodeShadow()
    {

    }

    PaintCodeShadow(int color, float dx, float dy, float radius)
    {
        this.get(color, dx, dy, radius);
    }

    PaintCodeShadow get(int color, float dx, float dy, float radius)
    {
        this.color = color;
        this.dx = dx;
        this.dy = dy;

        if (this.radius != radius)
        {
            this.blurMaskFilter = null;
            this.radius = radius;
        }

        return this;
    }

    void setBlurOfPaint(Paint paint)
    {
        if (this.radius <= 0)
            return;

        if (this.blurMaskFilter == null)
            this.blurMaskFilter = new BlurMaskFilter(this.radius, BlurMaskFilter.Blur.NORMAL);

        paint.setMaskFilter(this.blurMaskFilter);
    }
}

     */