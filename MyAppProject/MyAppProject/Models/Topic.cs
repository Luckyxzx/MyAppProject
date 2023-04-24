using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MyAppProject.Models
{

    public class Topic


    {
        //defines class id, title, creator, message
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        //sets a max length of 250
        [MaxLength(250)]
        public string Title { get; set; }
        //sets a max length of 250
        [MaxLength(250)]
        public string Creator { get; set; }
        //sets a max length of 1000 since message is usually longer
        [MaxLength(1000)]
        public string Message { get; set; }
    }



}
