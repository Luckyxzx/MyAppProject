using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyAppProject.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HealthSafety : ContentPage
	{

        //When logout is pressed it'll redirect the user back to the login page with async
        private async void ToolbarItem_Clicked(object sender, EventArgs e) => await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");


        public HealthSafety ()
		{
			InitializeComponent ();
		}
	}
}