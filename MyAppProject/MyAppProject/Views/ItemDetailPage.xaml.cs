using MyAppProject.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MyAppProject.Views
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