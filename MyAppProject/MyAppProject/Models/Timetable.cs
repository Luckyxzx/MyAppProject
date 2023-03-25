using MyAppProject.ViewModels;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAppProject.Models
{

    //library contains simple attributes that can be use to control construction table which is used for my database
    public class Timetable
    {
        //setting the public string for my variables
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string TimeDate { get; set; }
        public string Room { get; set; }
        public string Lecturer { get; set; }
        public string Image { get; set;}
    }
     
}
