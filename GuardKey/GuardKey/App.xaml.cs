using GuardKey.Models;
using GuardKey.Views;
using System;
using System.IO;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuardKey
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "userRecord.db";
        public static UserRecordRepository database;
        public static UserRecordRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new UserRecordRepository(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }
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
