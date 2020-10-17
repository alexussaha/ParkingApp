using System.ComponentModel;
using Xamarin.Forms;
using ParkingApp.ViewModels;

namespace ParkingApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }


    }
}