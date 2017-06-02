using Xamarin.Forms;

namespace XamarinTestApp.Controls
{
    public class IconToggleButton2 : FormsPlugin.Iconize.IconImage
    {
        public IconToggleButton2()
        {
            IsOn = false; //Default value
            //BackgroundColor = Color.Transparent;
            //Text = ToggledOffIconKey;
            RedrawIcon();
            GestureRecognizers.Add(new TapGestureRecognizer(view =>
            {
                IsOn = !IsOn;
                RedrawIcon();
            }));
        }


        public static readonly BindableProperty IsOnProperty =
            BindableProperty.Create(
                nameof(ToggledOnIconKey),
                typeof(bool),
                typeof(IconToggleButton2),
                false, propertyChanged: OnAnyPropertyChanged);

        public bool IsOn
        {
            get { return (bool)GetValue(IsOnProperty); }
            set { SetValue(IsOnProperty, value); }
        }


        public static readonly BindableProperty ToggledOnIconKeyProperty =
            BindableProperty.Create(
                nameof(ToggledOnIconKey),
                typeof(string),
                typeof(IconToggleButton2),
                "", propertyChanged: OnAnyPropertyChanged);

        public string ToggledOnIconKey
        {
            get { return (string)GetValue(ToggledOnIconKeyProperty); }
            set { SetValue(ToggledOnIconKeyProperty, value); }
        }

        public static readonly BindableProperty ToggledOffIconKeyProperty =
            BindableProperty.Create(
                nameof(ToggledOffIconKey),
                typeof(string),
                typeof(IconToggleButton2),
                "", propertyChanged: OnAnyPropertyChanged);

        public string ToggledOffIconKey
        {
            get { return (string)GetValue(ToggledOffIconKeyProperty); }
            set { SetValue(ToggledOffIconKeyProperty, value); }
        }

        private static void OnAnyPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var thisControl = bindable as IconToggleButton2;
            thisControl?.RedrawIcon();
        }

        public void RedrawIcon()
        {
            //TODO: Add short animation 
            Icon = IsOn ? ToggledOnIconKey : ToggledOffIconKey;
        }

    }
    public class IconToggleButton : FormsPlugin.Iconize.IconButton
    {
        public IconToggleButton()
        {
            IsOn = false; //Default value
            BackgroundColor = Color.Transparent;
            //Text = ToggledOffIconKey;
            RedrawIcon();
            Clicked += IconToggleButtonClicked;
        }
     
        private void IconToggleButtonClicked(object sender, System.EventArgs e)
        {
            IsOn = !IsOn;
            RedrawIcon();
        }

        public static readonly BindableProperty IsOnProperty =
            BindableProperty.Create(
                nameof(ToggledOnIconKey),
                typeof(bool),
                typeof(IconToggleButton),
                false, propertyChanged: OnAnyPropertyChanged);

        public bool IsOn
        {
            get { return (bool)GetValue(IsOnProperty); }
            set { SetValue(IsOnProperty, value); }
        }

     
        public static readonly BindableProperty ToggledOnIconKeyProperty =
            BindableProperty.Create(
                nameof(ToggledOnIconKey),
                typeof(string),
                typeof(IconToggleButton),
                "", propertyChanged: OnAnyPropertyChanged);

        public string ToggledOnIconKey
        {
            get { return (string)GetValue(ToggledOnIconKeyProperty); }
            set { SetValue(ToggledOnIconKeyProperty, value); }
        }

        public static readonly BindableProperty ToggledOffIconKeyProperty =
            BindableProperty.Create(
                nameof(ToggledOffIconKey),
                typeof(string),
                typeof(IconToggleButton),
                "", propertyChanged: OnAnyPropertyChanged);

        public string ToggledOffIconKey
        {
            get { return (string)GetValue(ToggledOffIconKeyProperty); }
            set { SetValue(ToggledOffIconKeyProperty, value); }
        }

        private static void OnAnyPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var thisControl = bindable as IconToggleButton;
            thisControl?.RedrawIcon();
        }

        public void RedrawIcon()
        {
            //TODO: Add short animation 
            Text = IsOn ? ToggledOnIconKey : ToggledOffIconKey;
        }
    }
}
