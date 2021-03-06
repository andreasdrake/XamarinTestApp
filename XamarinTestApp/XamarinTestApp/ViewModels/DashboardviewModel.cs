﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Acr.UserDialogs;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;

namespace XamarinTestApp.ViewModels
{
    public class DashboardviewModel : ExtendedViewModelBase
    {
        private bool _quickSaveOk;
        public DashboardviewModel():base()//IUserDialogs dialogsService) : base(dialogsService)
        {
        }

        public ICommand QuickReportCommand
        {
            get { return new RelayCommand(async () => await QuickReportAsync()); }
        }

        public ICommand DialogYesCommand
        {
            get { return new RelayCommand(() => IsBusy = false); }
        }

        public ICommand DialogNoCommand
        {
            get { return new RelayCommand(() => IsBusy = false); }
        }

        public bool QuickSaveOk
        {
            get { return _quickSaveOk; }
            set
            {
                Set(ref _quickSaveOk, value);
                RaisePropertyChanged("ShowSpinner");
            }
        }
        public bool ShowSpinner
        {
            get { return !QuickSaveOk; }
           
        }

        public string Source
        {
            get { return "speaker.svg"; }
        }
        private async Task QuickReportAsync()
        {
            //using (var pg = this.DialogsService.Loading("Signing in..."))
            //{

            //    await Task.Delay(5000);
            //}
            QuickSaveOk = false;

            BusyText = "Reporting...";
            IsBusy = true;
            return;//TEMP

            await Task.Delay(4000);
            BusyText = "Thanks!";
            QuickSaveOk = true;
            await Task.Delay(1500);
            IsBusy = false;
            QuickSaveOk = false;
            BusyText = string.Empty;
        }

    }
}
