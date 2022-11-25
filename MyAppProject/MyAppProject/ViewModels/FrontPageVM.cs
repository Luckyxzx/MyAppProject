using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Command = MvvmHelpers.Commands.Command;

namespace MyAppProject.ViewModels
{
    public class FrontPageVM : BaseViewModel
    {
        public FrontPageVM()
        {
            //implement increasecount as command (onincrease)
            IncreaseCount = new Command(OnIncrease);
            //bindable property that will auto work inside app with the help of mvmmhelpers
            Title = "Front Page";
        }

        //defines a command
        public ICommand IncreaseCount { get; }

        //int
        int count = 0;
        //string
        string countDisplay = "Click Me!!";
        //gets countdisplay and sets the property 
        public string CountDisplay
        {
            get => countDisplay;
            //set the property reference to countdisplay and pass in the value. Handles it all auto
            set => SetProperty(ref countDisplay, value);
        }

        //increase the count when the button is pressed and prints messaged with countdisplay
        void OnIncrease()
        {
            count++;
            CountDisplay = $"You clicked {count} time(s)";
        }
    }
}
