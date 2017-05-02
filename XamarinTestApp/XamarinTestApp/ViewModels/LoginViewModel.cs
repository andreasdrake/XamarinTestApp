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
        private string _userName = string.Empty;
        private string _password = string.Empty;

        public string UserName
        {
            get { return _userName; }
            set { Set(ref _userName, value); }
        }

        public string Password
        {
            get { return _password; }
            set { Set(ref _password, value); }
        }

        public ICommand LoginCommand
        {
            get { return new RelayCommand(async () => await DoLoginAsync(), CanLogin); }
        }


        private async Task DoLoginAsync()
        {
            await Task.Delay(2000);
        }

        private bool CanLogin()
        {
            return !string.IsNullOrWhiteSpace(UserName) && !string.IsNullOrWhiteSpace(Password);
        }
    }
}
