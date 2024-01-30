using GuardKey.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace GuardKey.ViewModel
{
    
        public class UserRecordListViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<UserRecordViewModel> Accounts { get; set; }
            public event PropertyChangedEventHandler PropertyChanged;
            public ICommand CreateAccountCommand { get; set; }
            public ICommand DeleteAccountCommand { get; set; }
            public ICommand SaveAccountCommand { get; set; }
            public ICommand BackCommand { get; set; }

            UserRecordViewModel selectedAccount;
            public INavigation Navigation { get; set; }

            public UserRecordListViewModel()
            {
                Accounts = new ObservableCollection<UserRecordViewModel>();
                CreateAccountCommand = new Command(CreateAccount);
                DeleteAccountCommand = new Command(DeleteAccount);
                SaveAccountCommand = new Command(SaveAccount);
                BackCommand = new Command(Back);
            }

            public UserRecordViewModel SelectedAccount
            {
                get { return selectedAccount; }
                set
                {
                    if (selectedAccount != value)
                    {
                        UserRecordViewModel tempAccount = value;
                        selectedAccount = null;
                        OnPropertyChanged("SelectedAccount");
                        Navigation.PushAsync(new UserRecordPage(tempAccount));
                    }
                }
            }

            protected void OnPropertyChanged(string propName)
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }

            private void CreateAccount()
            {
                Navigation.PushAsync(new UserRecordPage(new UserRecordViewModel() { ListViewModel = this }));
            }

            private void Back()
            {
                Navigation.PopAsync();
            }

            private void SaveAccount(object accountObject)
            {UserRecordViewModel account = accountObject as UserRecordViewModel;
                if (account != null && account.IsValid && !Accounts.Contains(account))
                {
                    Accounts.Add(account);
                }
                Back();
            }

            private void DeleteAccount(object accountObject)
            {
                UserRecordViewModel account = accountObject as UserRecordViewModel;
                if (account != null)
                {
                    Accounts.Remove(account);
                }
                Back();
            }
        }


    }

