//MvvmHelpers is created by James Montemagno https://www.nuget.org/packages/Refractored.MvvmHelpers
using MvvmHelpers;
using MvvmHelpers.Commands;
using MyAppProject.Models;
using MyAppProject.Services;
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
        //
        public AsyncCommand AddCommand { get; }
        //
        public AsyncCommand<Timetable> RemoveCommand { get; }  

        public TimetableVM()
        {
            //title
            Title = "The Timetable";

            Timetable = new ObservableRangeCollection<Timetable>();
            TimetableGroups = new ObservableRangeCollection<Grouping<string, Timetable>>();

            //creates a new async command that refresh
            RefreshCommand = new AsyncCommand(Refresh);
            AddCommand = new AsyncCommand(Add);
            RemoveCommand = new AsyncCommand<Timetable>(Remove);
        }

        async Task Add()
        {
            var name = await App.Current.MainPage.DisplayPromptAsync("Name", "Name");
            var timedate = await App.Current.MainPage.DisplayPromptAsync("TimeDate", "TimeDate");
            var room = await App.Current.MainPage.DisplayPromptAsync("Room", "Room");
            var lecturer = await App.Current.MainPage.DisplayPromptAsync("Lecturer", "Lecturer");
            await ServiceDatabase.AddTimeTable(name, timedate, room, lecturer);
            await Refresh();
        }

        async Task Remove(Timetable timetable)
        {
            await ServiceDatabase.RemoveTimeTable(timetable.Id);
            await Refresh();
        }

        //sets delay within async refresh awaitable
        async Task Refresh()
        {
            //if busy is true delays 2000
            IsBusy = true;

            await Task.Delay(2000);

            Timetable.Clear();

            var timetables = await ServiceDatabase.GetTimeTable();

            Timetable.AddRange(timetables);

            //if busy is false nothing happens
            IsBusy= false;
        }




    }
}
