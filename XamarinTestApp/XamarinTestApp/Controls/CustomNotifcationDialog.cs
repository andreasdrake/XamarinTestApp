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

        private Label _contentLabel;
        private RoundCornersButton _yesButton;
        private RoundCornersButton _noButton;
        private StackLayout _contentStackLayout;
        private bool _firstTimeAnimatingFromFalse = true;

        public WrappedCustomNotificationDialog()
        {
            CreateContent();
            Children.Add(new CustomNotifcationDialog
            {
                GradientBackgroundStartColor = GradientBackgroundStartColor,
                GradientBackgroundStopColor = GradientBackgroundStopColor,
                StrokeColor = StrokeColor
            });
            //Children.Add(_contentStackLayout);
        }

        public static readonly BindableProperty DialogTextProperty =
            BindableProperty.Create(nameof(DialogText), typeof(string), typeof(WrappedCustomNotificationDialog),
                   propertyChanged: (bindable, oldValue, newValue) =>
                   {
                       var dialog = bindable as WrappedCustomNotificationDialog;
                       if (dialog?._contentLabel != null)
                       {
                           dialog._contentLabel.Text = newValue as string;
                       }
                   });

        public string DialogText
        {
            get { return (string)GetValue(DialogTextProperty); }
            set { SetValue(DialogTextProperty, value); }
        }


        public static readonly BindableProperty ButtonStyleProperty =
        BindableProperty.Create(nameof(ButtonStyle), typeof(Style), typeof(WrappedCustomNotificationDialog),
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                var dialog = bindable as WrappedCustomNotificationDialog;
                if (dialog != null)
                {
                    dialog._yesButton.Style = newValue as Style;
                    dialog._noButton.Style = newValue as Style;
                }
            });

        public Style ButtonStyle
        {
            get { return (Style)GetValue(ButtonStyleProperty); }
            set { SetValue(ButtonStyleProperty, value); }
        }


        public static readonly BindableProperty LabelStyleProperty =
        BindableProperty.Create(nameof(LabelStyle), typeof(Style), typeof(WrappedCustomNotificationDialog), 
            propertyChanged: (bindable, oldValue, newValue)=>
                {
                    var dialog = bindable as WrappedCustomNotificationDialog;
                    if (dialog != null)
                    {
                        dialog._contentLabel.Style = newValue as Style;
                    }
                });

       
        public Style LabelStyle
        {
            get { return (Style)GetValue(LabelStyleProperty); }
            set { SetValue(LabelStyleProperty, value); }
        }


        public static readonly BindableProperty YesCommandProperty =
            BindableProperty.Create(nameof(YesCommand), typeof(ICommand), typeof(WrappedCustomNotificationDialog), 
                   propertyChanged: (bindable, oldValue, newValue) =>
                   {
                       var dialog = bindable as WrappedCustomNotificationDialog;
                       if (dialog != null)
                       {
                           dialog._yesButton.Command = newValue as ICommand;
                       }
                   });

        public ICommand YesCommand
        {
            get { return (ICommand)GetValue(YesCommandProperty); }
            set { SetValue(YesCommandProperty, value); }
        }


        public static readonly BindableProperty NoCommandProperty =
        BindableProperty.Create(nameof(NoCommand), typeof(ICommand), typeof(WrappedCustomNotificationDialog),
                   propertyChanged: (bindable, oldValue, newValue) =>
                   {
                       var dialog = bindable as WrappedCustomNotificationDialog;
                       if (dialog != null)
                       {
                           dialog._noButton.Command = newValue as ICommand;
                       }
                   });

        public ICommand NoCommand
        {
            get { return (ICommand)GetValue(NoCommandProperty); }
            set { SetValue(NoCommandProperty, value); }
        }

        private void CreateContent()
        {
            _contentStackLayout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.End,
                Margin = new Thickness(20, 20, 20, 30),
                //IsVisible = false
            };

            var stackPanelInner = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.End
            };

            _contentLabel = new Label
            {
                //Text = DialogText,
                //TextColor = Color.White,
                //Style = (Style)Application.Current.Resources["LoginPageLabelUnderTitleStyle"],
                Margin = new Thickness(10),
                HorizontalOptions = LayoutOptions.Center,
                LineBreakMode = LineBreakMode.WordWrap
            };

            _yesButton = new RoundCornersButton
            {
                Text = "Yes",
                VerticalOptions = LayoutOptions.End,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                //Style = (Style)Application.Current.Resources["RoundCornersButtonStyle"],
                Command = YesCommand
            };

            _noButton = new RoundCornersButton
            {
                Text = "No",
                VerticalOptions = LayoutOptions.End,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                //Style = (Style)Application.Current.Resources["RoundCornersButtonStyle"],
                Command = NoCommand
            };

            stackPanelInner.Children.Add(_yesButton);
            stackPanelInner.Children.Add(_noButton);

            _contentStackLayout.Children.Add(_contentLabel);
            _contentStackLayout.Children.Add(stackPanelInner);
        }
    

        private void ToggleShowContent()
        {
            Children.Add(_contentStackLayout);
            //if (_contentStackLayout != null)
            //{
            //    _contentStackLayout.IsVisible = !_contentStackLayout.IsVisible;
            //}
            //if (_contentStackLayout != null)
            //{
            //    Children.Add(_contentStackLayout);
            //}
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

        //Mörk 0d1829
        public static readonly BindableProperty GradientBackgroundStartColorProperty =
              BindableProperty.Create(nameof(GradientBackgroundStartColor), typeof(Color), typeof(CustomNotifcationDialog), Color.FromHex("#00dd00"));

        public Color GradientBackgroundStartColor
        {
            get { return (Color)GetValue(GradientBackgroundStartColorProperty); }
            set { SetValue(GradientBackgroundStartColorProperty, value); }
        }

        //Mörk 080a0c
        public static readonly BindableProperty GradientBackgroundStopColorProperty =
            BindableProperty.Create(nameof(GradientBackgroundStopColor), typeof(Color), typeof(CustomNotifcationDialog), Color.FromHex("#009f00"));

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
                    //if (IsVisible)
                    //{
                        Animate(IsVisible);
                    //}
                }
            }
        }

        private async Task Animate(bool animateToShow)
        {
            if (animateToShow)
            { 
                this.Scale = 0;
                //await this.ScaleTo(1, 200, Easing.SinIn);
                await this.TranslateTo(0, 100, 1);
                await Task.WhenAll(
                  this.ScaleTo(1, 300, Easing.SinIn),
                  this.TranslateTo(0, 0, 300, Easing.SinIn));

                ToggleShowContent();
            }
            else
            {
                if (_firstTimeAnimatingFromFalse)
                {
                    _firstTimeAnimatingFromFalse = false;
                    return;
                }
                //await this.ScaleTo(0, 2000, Easing.SinIn);
                //ToggleShowContent();
                //await Task.WhenAll(
                //    this.ScaleTo(0, 300, Easing.SinIn),
                //    this.TranslateTo(-300, -300, 300, Easing.SinIn));

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
