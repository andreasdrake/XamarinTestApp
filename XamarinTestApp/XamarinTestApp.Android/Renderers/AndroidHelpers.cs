using Android.Content;
using Android.Util;

namespace XamarinTestApp.Droid.Renderers
{
    public static class AndroidHelpers
    {
        public static float DpToPixels(Context context, float valueInDp)
        {
            DisplayMetrics metrics = context.Resources.DisplayMetrics;
            return TypedValue.ApplyDimension(ComplexUnitType.Dip, valueInDp, metrics);
        }
    }
}