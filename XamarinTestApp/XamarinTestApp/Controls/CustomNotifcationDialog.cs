using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinTestApp.Controls
{

    public class WrappedCustomNotificationDialog : Grid
    {
        /*
         
              <custom:RoundCornersButton Grid.Row="9" Margin="0,20,0,20" Text="Sign in"
                                           Style="{StaticResource RoundCornersButtonStyle}"    
                                           Command="{Binding Path=LoginCommand}"
                                           HorizontalOptions="FillAndExpand"/>

             */

        public WrappedCustomNotificationDialog()
        {
            Children.Add(new CustomNotifcationDialog
            {
                GradientBackgroundStartColor = GradientBackgroundStartColor,
                GradientBackgroundStopColor = GradientBackgroundStopColor,
                StrokeColor = StrokeColor
            });
        }

        public static readonly BindableProperty YesCommandProperty =
            BindableProperty.Create(nameof(YesCommand), typeof(ICommand), typeof(WrappedCustomNotificationDialog));

        public ICommand YesCommand
        {
            get { return (ICommand)GetValue(YesCommandProperty); }
            set { SetValue(YesCommandProperty, value); }
        }
        public static readonly BindableProperty NoCommandProperty =
        BindableProperty.Create(nameof(NoCommand), typeof(ICommand), typeof(WrappedCustomNotificationDialog));

        public ICommand NoCommand
        {
            get { return (ICommand)GetValue(NoCommandProperty); }
            set { SetValue(NoCommandProperty, value); }
        }

        private void AddContent()
        {
            var contentGrid = new Grid
            {
                //HorizontalOptions = LayoutOptions.CenterAndExpand,
                //VerticalOptions = LayoutOptions.Start,
                Margin = new Thickness(20, 20, 20, 30)
            };

            contentGrid.RowDefinitions = new RowDefinitionCollection
            {             
                new RowDefinition { Height = GridLength.Star },
                //new RowDefinition { Height = GridLength.Star },
                new RowDefinition { Height = GridLength.Auto }
            };

            contentGrid.ColumnDefinitions = new ColumnDefinitionCollection
            {
                new ColumnDefinition { Width = GridLength.Star },
                new ColumnDefinition { Width = 10 },
                new ColumnDefinition { Width = GridLength.Star }
            };

            var label = new Label {
                Text = "Do you want do report 8 h for SCB? Bla bla a lot of extra test text here...",
                TextColor = Color.White,
                Style = (Style)Application.Current.Resources["LoginPageLabelUnderTitleStyle"],
                Margin = new Thickness(10),
                HorizontalOptions = LayoutOptions.Center,
                LineBreakMode = LineBreakMode.WordWrap
            };

            var yesButton = new RoundCornersButton
            {
                Text = "Yes",
                VerticalOptions = LayoutOptions.End,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Style = (Style)Application.Current.Resources["RoundCornersButtonStyle"],
                Command = YesCommand
            };
            var noButton = new RoundCornersButton
            {
                Text = "No",
                VerticalOptions = LayoutOptions.End,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Style = (Style)Application.Current.Resources["RoundCornersButtonStyle"],
                Command = NoCommand
            };
            contentGrid.Children.Add(label, 0, 0);
            Grid.SetColumnSpan(label, 3);

            contentGrid.Children.Add(yesButton, 0, 1);
            contentGrid.Children.Add(noButton, 2, 1);

            //this.Children.Add(label);
            this.Children.Add(contentGrid);
        }


        //public static readonly BindableProperty ContentProperty =
        //    BindableProperty.Create(nameof(Content), typeof(View), typeof(WrappedCustomNotificationDialog), null, 
        //        propertyChanged: OnAnyPropertyChanged);

        //public View Content
        //{
        //    get { return (View)GetValue(FillColorProperty); }
        //    set { SetValue(FillColorProperty, value); }
        //}
        //private static void OnAnyPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        //{
        //    var thisControl = bindable as WrappedCustomNotificationDialog;
        //    if (thisControl != null)
        //    {
        //        if (!thisControl.Children.Contains(thisControl.Content))
        //        {
        //            thisControl.Children.Add(thisControl.Content);
        //        }
        //    }
        //}


        public static readonly BindableProperty StrokeColorProperty =
                BindableProperty.Create(nameof(StrokeColor), typeof(Color), typeof(CustomNotifcationDialog), Color.White);

        public Color StrokeColor
        {
            get { return (Color)GetValue(StrokeColorProperty); }
            set { SetValue(StrokeColorProperty, value); }
        }


        public static readonly BindableProperty GradientBackgroundStartColorProperty =
              BindableProperty.Create(nameof(GradientBackgroundStartColor), typeof(Color), typeof(CustomNotifcationDialog), Color.FromHex("#0d1829"));

        public Color GradientBackgroundStartColor
        {
            get { return (Color)GetValue(GradientBackgroundStartColorProperty); }
            set { SetValue(GradientBackgroundStartColorProperty, value); }
        }

        public static readonly BindableProperty GradientBackgroundStopColorProperty =
            BindableProperty.Create(nameof(GradientBackgroundStopColor), typeof(Color), typeof(CustomNotifcationDialog), Color.FromHex("#080a0c"));

        public Color GradientBackgroundStopColor
        {
            get { return (Color)GetValue(GradientBackgroundStopColorProperty); }
            set { SetValue(GradientBackgroundStopColorProperty, value); }
        }
        //protected override void OnPropertyChanging([CallerMemberName] string propertyName = null)
        //{
        //    base.OnPropertyChanging(propertyName);
        //    if (propertyName != null)
        //    {
        //        if (propertyName == Grid.IsVisibleProperty.PropertyName)
        //        {
        //            if (!IsVisible)
        //            {
        //                Animate(false);
        //            }
        //        }
        //    }
        //}

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName != null)
            {
                if (propertyName == Grid.IsVisibleProperty.PropertyName)
                {
                    if (IsVisible)
                    {
                        Animate(true);
                    }
                }
            }
        }

        private async Task Animate(bool animateToShow)
        {
            if (animateToShow)
            { 
                this.Scale = 0;
                await this.TranslateTo(0, 100, 1);
                await Task.WhenAll(
                    this.ScaleTo(1, 300, Easing.SinIn),
                    this.TranslateTo(0, 0, 300, Easing.SinIn));

                AddContent();
            }
            else
            {
                await Task.WhenAll(
                    this.ScaleTo(0, 300, Easing.SinIn),
                    this.TranslateTo(-300, -300, 300, Easing.SinIn));

            }

        }

    }

    public class CustomNotifcationDialog : BoxView
    {
        public CustomNotifcationDialog()
        {
            
            //GestureRecognizers.Add(new TapGestureRecognizer(view =>
            //{
            //    IsVisible = !IsVisible;
            //}));
        }
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
                this.TranslateTo(0, 0, 300, Easing.CubicInOut)
            );
            
        }

        public static readonly BindableProperty StrokeColorProperty =
             BindableProperty.Create(nameof(StrokeColor), typeof(Color), typeof(CustomNotifcationDialog), Color.White);

        public Color StrokeColor
        {
            get { return (Color)GetValue(StrokeColorProperty); }
            set { SetValue(StrokeColorProperty, value); }
        }


        public static readonly BindableProperty GradientBackgroundStartColorProperty =
              BindableProperty.Create(nameof(GradientBackgroundStartColor), typeof(Color), typeof(CustomNotifcationDialog), Color.FromHex("#0d1829"));

        public Color GradientBackgroundStartColor
        {
            get { return (Color)GetValue(GradientBackgroundStartColorProperty); }
            set { SetValue(GradientBackgroundStartColorProperty, value); }
        }

        public static readonly BindableProperty GradientBackgroundStopColorProperty =
            BindableProperty.Create(nameof(GradientBackgroundStopColor), typeof(Color), typeof(CustomNotifcationDialog), Color.FromHex("#080a0c"));

        public Color GradientBackgroundStopColor
        {
            get { return (Color)GetValue(GradientBackgroundStopColorProperty); }
            set { SetValue(GradientBackgroundStopColorProperty, value); }
        }
    }
}
