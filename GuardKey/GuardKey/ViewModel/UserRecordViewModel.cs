using GuardKey.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using static GuardKey.ViewModel.UserRecordListViewModel;

namespace GuardKey.ViewModel
{
    public class UserRecordViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        UserRecordListViewModel lvm;
        public UserRecord Account { get; private set; }

        public UserRecordViewModel()
        {
            Account = new UserRecord();
        }

        public UserRecordListViewModel ListViewModel
        {
            get { return lvm; }
            set
            {
                if (lvm != value)
                {
                    lvm = value;
                    OnPropertyChanged("ListViewModel");
                }
            }
        }

        public string SourceGroupName
        {
            get { return Account.SourceGroupName; }
            set
            {
                if (Account.SourceGroupName != value)
                {
                    Account.SourceGroupName = value;
                    OnPropertyChanged("SourseName");
                }
            }
        }

        public string ResourceName
        {
            get { return Account.ResourceName; }
            set
            {
                if (Account.ResourceName != value)
                {
                    Account.ResourceName = value;
                    OnPropertyChanged("ResourceName ");
                }
            }
        }

        public string UserName
        {
            get { return Account.UserName; }
            set
            {
                if (Account.UserName != value)
                {
                    Account.UserName = value;
                    OnPropertyChanged("UserName");
                }
            }
        }

        public string Password
        {
            get { return Account.Password; }
            set
            {
                if (Account.Password != value)
                {
                    Account.Password = value;
                    OnPropertyChanged("Password");
                }
            }
        }

        public string Description 
        {
            get { return Account.Description; }
            set
            {
                if (Account.Description != value)
                {
                    Account.Description = value;
                    OnPropertyChanged("Description");
                }
            }
        }

        public bool IsValid
        {
            get
            {
                return ((!string.IsNullOrEmpty(SourceGroupName.Trim()))) ||
                    (!string.IsNullOrEmpty(ResourceName.Trim())) ||
                    (!string.IsNullOrEmpty(UserName.Trim())) ||
                    (!string.IsNullOrEmpty(Password.Trim())) ||
                    (!string.IsNullOrEmpty(Description.Trim()));
            }
        }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }


    }
}
