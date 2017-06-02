//using Acr.UserDialogs;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace XamarinTestApp.ViewModels
{
    public class LoginViewModel: ExtendedViewModelBase
    {
        private readonly Action<string> _onUserLoggedInSuccessful;
        public LoginViewModel(/*IUserDialogs dialogs, */Action<string> onUserLoggedInSuccessful):base()//:base(dialogs)
        {
            _onUserLoggedInSuccessful = onUserLoggedInSuccessful ?? throw new ArgumentNullException(nameof(onUserLoggedInSuccessful));
        }

        private string _userName = string.Empty;
        private string _password = string.Empty;

        public string UserName
        {
            get { return _userName; }
            set
            {
                Set(ref _userName, value);
                RaisePropertyChanged("LoginCommand");
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                Set(ref _password, value);
                RaisePropertyChanged("LoginCommand");
            }
        }

        public ICommand LoginCommand
        {
            get { return new RelayCommand(async () => await DoLoginAsync(), CanLogin); }
        }


        private async Task DoLoginAsync()
        {
            //using (var pg = this.DialogsService.Loading("Signing in..."))
            //{

            //    await Task.Delay(5000);
            //}


            BusyText = "Signing in...";
            IsBusy = true;
            await Task.Delay(3500);
            IsBusy = false;
            BusyText = string.Empty;
            _onUserLoggedInSuccessful(UserName);
        }

        private bool CanLogin()
        {
            return !string.IsNullOrWhiteSpace(UserName) && !string.IsNullOrWhiteSpace(Password);
        }
    }
}
