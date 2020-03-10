using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.Model
{
    public class Student
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DOB { get; set; }
        public decimal Fee { get; set; }
        public string Remarks { get; set; }
    }
}

