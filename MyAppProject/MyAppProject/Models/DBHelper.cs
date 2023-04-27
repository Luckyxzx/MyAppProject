using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;
using MyAppProject.Models;
using System.Data.Common;
using System.Diagnostics;
using MyAppProject.Views;


namespace MyAppProject.Helpers
{
    //uses the SQLite lib to create an engine which can be used for the forum page
    public class DBHelper
    {
        private readonly SQLiteAsyncConnection database;

        //Constructor initialize new instance of DBHelper class and CreateTableASync which creates a table if it doesn't exist
        public DBHelper(string dbPath)
        {
            //SQLiteAsyncConnection class with the specified dbPath parameter
            database = new SQLiteAsyncConnection(dbPath);

            //creates a table if it doesn't exist
            database.CreateTableAsync<Topic>().Wait();
        }

        //gets all the record which is in the topic table and return to a list of topic objects
        public Task<List<Topic>> GetAllTopicsAsync()
        {
            return database.Table<Topic>().ToListAsync();
        }

        // it either updates or inserts topic obj to a topic table all dependent on if it already exists or not, also return used rows
        public Task<int> SaveTopicAsync(Topic topic)
        {
            if (topic.Id != 0)
            {
                return database.UpdateAsync(topic);
            }
            else
            {
                return database.InsertAsync(topic);
            }
        }

        //Delete specified topic when pressed hold from the forum page, also returns used rows
        public Task<int> DeleteTopicAsync(Topic topic)
        {
            return database.DeleteAsync(topic);
        }

    }

}

