using GuardKey.Views;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuardKey
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var pin = Preferences.Get("UserPIN", "");
            if (string.IsNullOrEmpty(pin))
            {

                MainPage = new NavigationPage(new RegistrarionPage());
            }
            else
            {
                MainPage = new NavigationPage(new Login());
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
