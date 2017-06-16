using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinTestApp.iOS.Renderers;
using XamarinTestApp.Effects;
using CoreGraphics;

//Solution found at: https://github.com/SeeD-Seifer/ShadowEffectDemo
[assembly: ResolutionGroupName("XamarinTestApp.Effects")]
[assembly: ExportEffect(typeof(PanelShadowEffect), "PanelShadowEffect")]
namespace XamarinTestApp.iOS.Renderers
{
    public class PanelShadowEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            try
            {
                var effect = (ShadowEffect)Element.Effects.FirstOrDefault(e => e is ShadowEffect);
                if (effect == null)
                {
                    return;
                }
                var control = Control;
                if (control == null)
                {
                    var renderer = Platform.GetRenderer((VisualElement)Element);
                    control = renderer.ViewController.View;
                }
                control.Layer.CornerRadius = effect.Radius;
                control.Layer.ShadowColor = effect.Color.ToCGColor();
                control.Layer.ShadowOffset = new CGSize(effect.DistanceX, effect.DistanceY);
                control.Layer.ShadowOpacity = 0.9f;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: {0}", ex.Message);
            }
        }

        protected override void OnDetached()
        {
        }
    }
}