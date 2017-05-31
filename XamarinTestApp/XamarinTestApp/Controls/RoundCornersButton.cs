using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinTestApp.Controls
{
    public class RoundCornersButton : Button
    {
        public static readonly BindableProperty BorderColorProperty =
    BindableProperty.Create(
        nameof(BorderColor),
        typeof(Color),
        typeof(EntryWithCurvedCorners),
        Color.Gray);
        /// <summary>
        /// Gets or sets BorderColor value
        /// </summary>
        public Color BorderColor
        {
            get { return (Color)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }


        public static readonly BindableProperty BorderWidthProperty =
        BindableProperty.Create(
            nameof(BorderWidth),
            typeof(int),
            typeof(EntryWithCurvedCorners),
            Device.OnPlatform<int>(1, 2, 2));
        /// <summary>
        /// Gets or sets BorderWidth value
        /// </summary>
        public int BorderWidth
        {
            get { return (int)GetValue(BorderWidthProperty); }
            set { SetValue(BorderWidthProperty, value); }
        }



    }
}
