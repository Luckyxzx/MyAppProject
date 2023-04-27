//MvvmHelpers is created by James Montemagno https://www.nuget.org/packages/Refractored.MvvmHelpers
using MvvmHelpers;
using MvvmHelpers.Commands;
using MyAppProject.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using static MyAppProject.ViewModels.FrontPageVM;
using Command = MvvmHelpers.Commands.Command;

namespace MyAppProject.ViewModels
{
    //MVMMHelper  sets to inherit from VMBase which it inherits from BaseViewModel
    public class FrontPageVM : VMBase
    {
        //sets
        public FrontPageVM()
        {
            Onboardings = GetOnboarding();
        }

        //get and set onboardings
        public List<Onboarding> Onboardings { get; set; }

        private List<Onboarding> GetOnboarding()
        {
            //creates a list which when called upon it will display message
            return new List<Onboarding>
            {
                new Onboarding { Heading = "USW Daily News", Caption = "Community Event on the 05/12/2022 attendance would be great" },
                new Onboarding { Heading = "Heavy Rain", Caption = "During next week starting Monday 05/12/2022 expect heavy rain throughout" },
                new Onboarding { Heading = "Assignment Due", Caption = "Please remember students, to hand in their assignments thats due on the 15th of December for CS03032" }
            };
        }

        public class Onboarding
        {
            //creation of variable
            public string Heading { get; set; }

            public string Caption { get; set; }
        }

    }
}
