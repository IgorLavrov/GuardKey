using GuardKey.Models;
using GuardKey.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuardKey.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserRecordPage : ContentPage
    {
        public UserRecordViewModel ViewModel { get; set; }
        public UserRecordPage(UserRecordViewModel vm)
        {
            InitializeComponent();

            ViewModel = vm;

            ViewModel.ListViewModel = new UserRecordListViewModel();

            this.BindingContext = ViewModel;
        }

    }
}