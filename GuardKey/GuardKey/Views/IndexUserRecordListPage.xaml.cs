using GuardKey.Models;
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
    public partial class IndexUserRecordListPage : ContentPage
    {
        public IndexUserRecordListPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            accounList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }

        private async void accounList_ItemSelectedAsync(object sender, SelectedItemChangedEventArgs e)
        {
            UserRecord selectedAccount = (UserRecord)e.SelectedItem;
            IndexUserRecordListPage UserRecordPage = new IndexUserRecordListPage();
            UserRecordPage.BindingContext = selectedAccount;
            await Navigation.PushAsync(UserRecordPage);
        }

        //private void Button_Clicked(object sender, EventArgs e)
        //{

        //}
    }
}