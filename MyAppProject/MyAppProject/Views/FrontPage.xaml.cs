﻿using MyAppProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MvvmHelpers.Commands;

namespace MyAppProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FrontPage : ContentPage
    {
        public FrontPage()
        {
            InitializeComponent();

        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e) => await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");


    }
}