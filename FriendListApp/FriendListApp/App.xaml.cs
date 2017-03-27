using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FriendListApp.Backend.SQLite;
using Xamarin.Forms;

namespace FriendListApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            SQLiteDataBase dataBase = new SQLiteDataBase();

            MainPage = new NavigationPage(new MainPage(dataBase));
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
