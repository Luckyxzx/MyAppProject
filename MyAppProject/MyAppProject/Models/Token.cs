using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MyAppProject.Models
{
    public class Token
    {
        public int Id { get; set; }
        public string access_token { get; set; }
        public string error_description { get; set; }
        public DataSetDateTime expire_date { get; set; }

        public Token() { }
    }
}
