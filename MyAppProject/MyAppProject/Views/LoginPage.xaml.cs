//Libs
//MvvmHelpers is created by James Montemagno https://www.nuget.org/packages/Refractored.MvvmHelpers
using MyAppProject.Models;
using MyAppProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

//Code to hold the buttons
namespace MyAppProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {

        //Public initialize
        public LoginPage()
        {
            InitializeComponent();
        }

        //direct to front page when button is pressed
        private async void SignInButton(object sender, EventArgs e)
        {
            User user = new User(En_User.Text, En_Pass.Text);
            if (user.CheckInfo())
            {
                _ = DisplayAlert("Login", "Login Success", "Ok");
                await Shell.Current.GoToAsync($"//{nameof(FrontPage)}");
            }
            else
            {
                _ = DisplayAlert("Login", "Login Incorrect, Please input correct Username/Password or Register", "Ok");
                await Shell.Current.GoToAsync($"//{nameof(RegPage)}");
            }
        }

        //direct to register page when button is pressed
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(RegPage)}");
        }


    }
}