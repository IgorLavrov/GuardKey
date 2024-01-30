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

        private void accounList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}