using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPDF.Data
{
    public class Student
    {
        public int StudentId { get; set; }

        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
    }
}
