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


        public WrappedCustomNotificationDialog()
        {
            this.Children.Add(new CustomNotifcationDialog {  FillColor = FillColor});
        }

        public static readonly BindableProperty YesCommandProperty =
            BindableProperty.Create(nameof(YesCommand), typeof(ICommand), typeof(WrappedCustomNotificationDialog));

        public ICommand YesCommand
        {
            get { return (ICommand)GetValue(YesCommandProperty); }
            set { SetValue(YesCommandProperty, value); }
        }

        private void AddContent()
        {
            var contentGrid = new Grid
            {
                //HorizontalOptions = LayoutOptions.CenterAndExpand,
                //VerticalOptions = LayoutOptions.Start,
                Margin = new Thickness(10, 20, 10, 30)
            };

            contentGrid.RowDefinitions = new RowDefinitionCollection
            {
             
                new RowDefinition { Height = GridLength.Auto },
                new RowDefinition { Height = GridLength.Auto },
                new RowDefinition { Height = GridLength.Star }
            };
            contentGrid.ColumnDefinitions = new ColumnDefinitionCollection
            {
                new ColumnDefinition { Width = GridLength.Star },
                new ColumnDefinition { Width = GridLength.Star }
            };

            var label = new Label {
                Text = "Test av text",
                TextColor = Color.White,
                Margin = new Thickness(10,20,10,30),
                HorizontalOptions = LayoutOptions.Center
            };

            var yesButton = new Button
            {
                Text = "Yes",
                HorizontalOptions = LayoutOptions.Center
            };
            var noButton = new Button
            {
                Text = "No",
                HorizontalOptions = LayoutOptions.Center
            };
            contentGrid.Children.Add(label, 0, 0);
            Grid.SetColumnSpan(label, 2);

            contentGrid.Children.Add(yesButton, 0, 1);
            contentGrid.Children.Add(noButton, 1, 1);

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


        public static readonly BindableProperty FillColorProperty =
            BindableProperty.Create(nameof(FillColor), typeof(Color), typeof(WrappedCustomNotificationDialog), Color.FromHex("#0d1829"));

        public Color FillColor
        {
            get { return (Color)GetValue(FillColorProperty); }
            set { SetValue(FillColorProperty, value); }
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName != null)
            {
                if (propertyName == Grid.IsVisibleProperty.PropertyName)
                {
                    
                        Animate(IsVisible);
                        //this.Scale = 0;
                        //this.ScaleTo(1, 500, Easing.SinIn);
                    
                    
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
