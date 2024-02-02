using GuardKey.Models;
using GuardKey.ViewModel;
using GuardKey.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace GuardKey.ViewModels
{
    public class AddUserRecordViewModel:BaseUserRecordViewModel
    {
        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        public AddUserRecordViewModel()
        {
            SaveCommand = new Command(OnSave);
            CancelCommand = new Command(OnCancel);
            UserRecord = new UserRecord();
        }
        private async void OnSave()
        {
            var record = UserRecord;
            await App.Database.AddUserRecordAsync(record);

            var navigationPage = Application.Current.MainPage as NavigationPage;
            await navigationPage?.Navigation.PushAsync(new UserRecordPage());
        }

        private async void OnCancel()
        {
          
            var navigationPage = Application.Current.MainPage as NavigationPage;
            await navigationPage?.Navigation.PushAsync(new UserRecordPage());
        }
    } }

