using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinTestApp.Controls
{
    public class ConevoArrowActivityIndicator : BoxView
    {
        private static double _divider = 1.848;
        private static int _defualtArrowHeight = 53;
        private bool _isAnimating = false;

        public ConevoArrowActivityIndicator()
        {
            SetHeightAndProportionalWith(_defualtArrowHeight);
        }

        public static readonly BindableProperty ArrowHeightProperty =
            BindableProperty.Create(
                nameof(ArrowHeight),
                typeof(int),
                typeof(ConevoArrowActivityIndicator),
                _defualtArrowHeight,
                propertyChanged: OnAnyPropertyChanged);

       

        private static void OnAnyPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {       
            var control = (ConevoArrowActivityIndicator)bindable;
            control.SetHeightAndProportionalWith((int)newValue);
        }

        public void SetHeightAndProportionalWith(int height)
        {
            
            HeightRequest = 53;//height;
            WidthRequest = 28;// width;

            //int width = (int)(height / _divider);
            //HeightRequest = height;
            //WidthRequest =  width;
            
             Animate();
        }

        public int ArrowHeight
        {
            get { return (int)GetValue(ArrowHeightProperty); }
            set { SetValue(ArrowHeightProperty, value); }
        }

        private async Task Animate()
        {
            if (_isAnimating)
            {
                return;
            }
            _isAnimating = true;

            while (true)
            {
                await this.RotateYTo(360, 1200, Easing.SinInOut);
                RotationY = 0;
            }
        }
    }
}
