using SyncHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TablesLibrary;
using Xamarin.Forms;

namespace TestingApp
{
    public partial class App : Application
    {
        public App()
        {
            SQLitePCL.Batteries.Init();

            InitializeComponent();

            MainPage = new TestingApp.MainPage();

            SyncDatabaseController sc = new SyncDatabaseController();

            sc.CreateDatabase();
            sc.CreateTable<Client>();
            sc.CreateTable<Location>();
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
