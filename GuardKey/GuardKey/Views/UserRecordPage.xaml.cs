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
        public UserRecordViewModel userRecordViewModel { get; set; }
        public UserRecordPage()
        {
            InitializeComponent();


            //ViewModel.ListViewModel = new UserRecordListViewModel();

           BindingContext = userRecordViewModel=new  UserRecordViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            userRecordViewModel.OnAppearing();
        }


    }
}