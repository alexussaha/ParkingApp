using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ParkingApp.Services;
using ParkingApp.Views;

namespace ParkingApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
