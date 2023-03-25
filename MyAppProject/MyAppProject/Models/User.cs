using System;
using System.Collections.Generic;
using System.Text;

namespace MyAppProject.Models
{
    //holds user login token
    public class User
    {
        //creation of variable to be called upon when used
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User() { }
        public User(string Username, string Password)
        {
            //bind user = to user pass = pass
            this.Username = Username;
            this.Password = Password;
        }

        //public checkinfo
        public bool CheckInfo()
        {
            if (!this.Username.Equals("") && !this.Password.Equals(""))
                return true;
            else
                return false;
                 
        }
    }
}
