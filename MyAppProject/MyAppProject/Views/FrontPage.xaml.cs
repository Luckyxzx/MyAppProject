using MyAppProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Timers;
using Xamarin.Forms.Xaml;
using MvvmHelpers.Commands;

namespace MyAppProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FrontPage : ContentPage
    {
        public FrontPage()
        {
            //NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();

        }

        //When logout is pressed it'll redirect the user back to the login page with async
        private async void ToolbarItem_Clicked(object sender, EventArgs e) => await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");

        private void Image_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}