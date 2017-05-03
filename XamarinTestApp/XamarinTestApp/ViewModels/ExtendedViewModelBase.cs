using GalaSoft.MvvmLight;

namespace XamarinTestApp.ViewModels
{
    public class ExtendedViewModelBase : ViewModelBase
    {
        private string _title = string.Empty;
        private string _busyText = string.Empty;
        private bool _isBusy = false;

        public bool IsBusy
        {
            get { return _isBusy; }
            set { Set(ref _isBusy, value); }
        }
        public string BusyText
        {
            get { return _busyText; }
            set { Set(ref _busyText, value); }
        }

        public string Title
        {
            get { return _title; }
            set { Set(ref _title, value); }
        }
    }
}
