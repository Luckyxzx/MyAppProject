using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using MyAppProject.Views;

namespace MyAppProject
{
    public partial class AppShell : Xamarin.Forms.Shell
    {

        public ICommand HelpCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public ICommand AboutCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));

        public AppShell()
        {
            InitializeComponent();
            BindingContext= this;
        }

        public new object FlyoutHeader { get; set; }

        public new Xamarin.Forms.Aspect FlyoutBackgroundImageAspect { get; set; }


    }
}
