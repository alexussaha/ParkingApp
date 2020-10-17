using System;
using System.Collections.Generic;
using ParkingApp.ViewModels;
using ParkingApp.Views;
using Xamarin.Forms;

namespace ParkingApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(ServiceChoosePage), typeof(ServiceChoosePage));
            Routing.RegisterRoute(nameof(ItemsPage), typeof(ItemsPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }

    }
}
