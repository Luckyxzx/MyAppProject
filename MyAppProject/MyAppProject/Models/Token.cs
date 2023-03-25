using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MyAppProject.Models
{
    public class Token
    {
        //simple public string to be called upon to use
        public int Id { get; set; }
        public string access_token { get; set; }
        public string error_description { get; set; }
        public DataSetDateTime expire_date { get; set; }

        //create token
        public Token() { }
    }
}
