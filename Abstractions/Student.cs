using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    internal class Student
    {
        private static int _nextId = 1;  
        public int Id { get; private set; }  
        public string Fullname { get; set; }
        public double Point { get; set; }

        
        public Student(string fullname, double point)
        {
            Fullname = fullname;
            Point = point;
            Id = _nextId++;  
        }

    }
}
