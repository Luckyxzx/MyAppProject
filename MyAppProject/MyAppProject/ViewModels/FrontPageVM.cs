using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyAppProject.ViewModels
{
    public class FrontPageVM : BindableObject
    {
        public FrontPageVM()
        {
            IncreaseCount = new Command(OnIncrease);
        }

        public ICommand IncreaseCount { get; }

        int count = 0;
        string countDisplay = "Click Me!!";

        public string CountDisplay
        {
            get => countDisplay;
            set
            {
                if (value == countDisplay)
                    return;
                countDisplay = value;
                OnPropertyChanged();
            }
        }

        void OnIncrease()
        {
            count++;
            CountDisplay = $"You clicked {count} time(s)";
        }
    }
}
