using System;
using System.Collections.Generic;
using System.Text;
using MyAppProject.Models;
using SQLite;

namespace MyAppProject.Data
{
    public class MyAppDbContext
    {
        private readonly SQLiteConnection db;

        public MyAppDbContext(string dbPath)
        {
            db = new SQLiteConnection(dbPath);
            db.CreateTable<Topic>();
        }

        public void AddTopic(Topic topic)
        {
            db.Insert(topic);
        }

        public List<Topic> GetAllTopics()
        {
            return db.Table<Topic>().ToList();
        }
    }
}
