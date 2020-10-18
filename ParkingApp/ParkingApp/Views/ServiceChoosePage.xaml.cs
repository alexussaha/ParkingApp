using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParkingApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ServiceChoosePage : ContentPage
    {
        public ServiceChoosePage()
        {
            InitializeComponent();
        }

        private async void OnNextClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(ItemsPage));
        }

        private async void OnAddresstClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(NewItemPage));
        }
    }
}