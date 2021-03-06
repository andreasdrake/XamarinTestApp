﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinTestApp.Controls
{
    public class CustomEntry:Entry
    {
        #region Constructors

        public CustomEntry()
            : base()
        {

        }

        #endregion
        #region Properties

        public static BindableProperty BorderColorProperty = 
            //BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(CustomEntry), Color.Transparent);
            BindableProperty.Create<CustomEntry, Color>(o => o.BorderColor, Color.Transparent);

        public Color BorderColor
        {
            get { return (Color)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }


        public static BindableProperty BorderWidthProperty = 
            //BindableProperty.Create(nameof(BorderWidth), typeof(float), typeof(CustomEntry), 0);
            BindableProperty.Create<CustomEntry, float>(o => o.BorderWidth, 0);

        public float BorderWidth
        {
            get { return (float)GetValue(BorderWidthProperty); }
            set { SetValue(BorderWidthProperty, value); }
        }

        public static BindableProperty BorderRadiusProperty = 
            //BindableProperty.Create(nameof(BorderRadius), typeof(float), typeof(CustomEntry), 0);
        BindableProperty.Create<CustomEntry, float>(o => o.BorderRadius, 0);

        public float BorderRadius
        {
            get { return (float)GetValue(BorderRadiusProperty); }
            set { SetValue(BorderRadiusProperty, value); }
        }

        public static BindableProperty LeftPaddingProperty = 
        //    BindableProperty.Create(nameof(LeftPadding), typeof(int), typeof(CustomEntry), 5);
        BindableProperty.Create<CustomEntry, int>(o => o.LeftPadding, 5);

        public int LeftPadding
        {
            get { return (int)GetValue(LeftPaddingProperty); }
            set { SetValue(LeftPaddingProperty, value); }
        }

        public static BindableProperty RightPaddingProperty = 
        //    BindableProperty.Create(nameof(RightPadding), typeof(int), typeof(CustomEntry), 5);
        BindableProperty.Create<CustomEntry, int>(o => o.RightPadding, 5);

        public int RightPadding
        {
            get { return (int)GetValue(RightPaddingProperty); }
            set { SetValue(RightPaddingProperty, value); }
        }

        #endregion
    }
}
