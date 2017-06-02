using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinTestApp.Controls
{
    public class IconActivityIndicator : FormsPlugin.Iconize.IconImage
    {
        private bool _stopAnimate;

        public IconActivityIndicator()
        {
            this.SizeChanged += IconActivityIndicatorSizeChanged;
        }

        private void IconActivityIndicatorSizeChanged(object sender, EventArgs e)
        {
            UpdateIcon();
        }

        public static readonly BindableProperty IconKeyProperty =
            BindableProperty.Create(
                nameof(IconKey),
                typeof(string),
                typeof(IconActivityIndicator),
                "", propertyChanged: OnAnyGuiPropertyChanged);

        private static void OnAnyGuiPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var activityIndicator = bindable as IconActivityIndicator;
            activityIndicator?.UpdateIcon();
        }


        public string IconKey
        {
            get { return (string)GetValue(IconKeyProperty); }
            set { SetValue(IconKeyProperty, value); }
        }
       

        public void UpdateIcon()
        {
             ViewExtensions.CancelAnimations(this);
            _stopAnimate = true;
            Icon = IconKey;
            _stopAnimate = false;
            Animate();
        }

        private async Task Animate()
        {
            while (true)
            {
                await this.RotateTo(360, 800, Easing.SinInOut);
                this.Rotation = 0;
                if (_stopAnimate)
                {
                    break;
                }
            }
        }
    }
}
