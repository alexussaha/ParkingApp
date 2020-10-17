﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ParkingApp.Services;

namespace ParkingApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }

        

        private void BtnCheck_Click(object sender)
        {
            
        }

    }
}