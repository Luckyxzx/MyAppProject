using Xamarin.Forms;

namespace MyAppProject
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            //because media element is still in early phase this command is required as a safe point when using.
            Device.SetFlags(new[] { "MediaElement_Experimental", "Brush_Experimental" });
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
