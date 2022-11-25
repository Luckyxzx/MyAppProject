//MvvmHelpers is created by James Montemagno https://www.nuget.org/packages/Refractored.MvvmHelpers
using MvvmHelpers;
using MvvmHelpers.Commands;
using MyAppProject.Models;
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
    //MVMMHelper  sets to inherit from VMBase which it inherits from BaseViewModel
    public class TimetableVM : VMBase
    {
        //within MVMMhelpers
        //observablerangecollection contains observablecollection with inherit along with alot more others || addrange || removerange || replace || replacerange
        public ObservableRangeCollection<Timetable> Timetable { get; set; }
        //have a list of lists
        public ObservableRangeCollection<Grouping<string, Timetable>> TimetableGroups { get; }

        //pulls data and wait 2 sec async
        public AsyncCommand RefreshCommand { get; }

        public TimetableVM()
        {
            //title
            Title = "Timetable";

            Timetable = new ObservableRangeCollection<Timetable>();
            TimetableGroups = new ObservableRangeCollection<Grouping<string, Timetable>>();

            var image = "usw_logo.png";
            Timetable.Add(new Timetable { Name = "Game Engine Design", TimeDate = "MON 9:00-11:00, 13:00-15:00", Room = "J202", Image = image });
            Timetable.Add(new Timetable { Name = "Parallel Programming", TimeDate = "MON 15:00-17:00", Room = "J208", Image = image });
            Timetable.Add(new Timetable { Name = "Indivudla Project", TimeDate = "WED 9:00-10:00, 10:30-11:30", Room = "G303", Image = image });

            RefreshCommand = new AsyncCommand(Refresh);
        }

        async Task Refresh()
        {
            IsBusy = true;

            await Task.Delay(2000);

            IsBusy= false;
        }




    }
}
