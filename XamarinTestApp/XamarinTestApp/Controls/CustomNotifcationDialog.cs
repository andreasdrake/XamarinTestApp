using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinTestApp.Controls
{
    public class CustomNotifcationDialog : BoxView
    {
        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName != null)
            {
                if (propertyName == BoxView.IsVisibleProperty.PropertyName)
                {
                    if (IsVisible)
                    {
                        Animate();
                        //this.Scale = 0;
                        //this.ScaleTo(1, 500, Easing.SinIn);
                    }
                }
            }
        }

        private async Task Animate()
        {
            this.Scale = 0;
            await this.TranslateTo(0, 100, 1);
            await Task.WhenAll(
                
                this.ScaleTo(1,300, Easing.SinIn),
                this.TranslateTo(0, 0, 300, Easing.SinIn)
);

            //this.Scale = 0;
            //this.ScaleTo(1, 500, Easing.SinIn);
        }

        public static readonly BindableProperty FillColorProperty =
              BindableProperty.Create(nameof(FillColor), typeof(Color), typeof(CustomNotifcationDialog), Color.Blue);

        public Color FillColor
        {
            get { return (Color)GetValue(FillColorProperty); }
            set { SetValue(FillColorProperty, value); }
        }
    }
}
