using GuardKey.Models;
using GuardKey.ViewModels;
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
    public partial class AddUserRecordPage : ContentPage
    {

        public UserRecord UserRecord { get; set; }
        public AddUserRecordPage()
        {
            InitializeComponent();
            BindingContext = new AddUserRecordViewModel();
        }
    }
}