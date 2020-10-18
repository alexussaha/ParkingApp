using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using ParkingApp.Models;
using Xamarin.Forms;

namespace ParkingApp.ViewModels
{
    public class NewItemViewModel : BaseViewModel
    {
        private string text;
        private string _newAddress;

        

        public string Address
        {
            get => _newAddress;
            set => SetProperty(ref _newAddress, value);
        }

        
        
    }
}
