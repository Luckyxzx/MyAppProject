//https://github.com/praeclarum/sqlite-net?WT.mc_id=friends-0000-jamont
//everything that needs to be known about sqlite to create database

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using MyAppProject.Models;
using SQLite;

//this is a database which would be storing the timetable input from students.
namespace MyAppProject.Services
{
    //
    public static class ServiceDatabase
    {
        //able to access it anytime
        static SQLiteAsyncConnection db;
        //the purpose for init is to call upon it once
        static async Task Init()
        {
            if (db != null)
                return;

            //get an absolute path to the database file
            //give it a data path and directory to go to
            var databasePath = Path.Combine(Xamarin.Essentials.FileSystem.AppDataDirectory, "MyData.db");

            //create connection
            db = new SQLiteAsyncConnection(databasePath);

            //create table
            await db.CreateTableAsync<Timetable>();
        }

        public static async Task AddTimeTable(string name, string timedate, string room, string lecturer)
        {
            await Init();
            var timetable = new Timetable
            {
                Name = name,
                TimeDate = timedate,
                Room = room,
                Lecturer = lecturer
            };

            //insert the timetable
            var id = await db.InsertAsync(timetable);
        }

        public static async Task RemoveTimeTable(int id) 
        {
            await Init();

            //lookup the timetable
            await db.DeleteAsync<Timetable>(id);
        }

        public static async Task<IEnumerable<Timetable>> GetTimeTable()
        {
            await Init();

            //give the whole timetable
            var timetable = await db.Table<Timetable>().ToListAsync();
            return timetable;
        }
    }
}
