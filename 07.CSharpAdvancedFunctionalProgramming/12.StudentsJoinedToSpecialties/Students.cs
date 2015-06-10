using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.StudentsJoinedToSpecialties
{
    public class Student
    {
        public string FactNum { get; set; }
        public string Name { get; set; }

        public Student(string factNum, string name)
        {
            this.FactNum = factNum;
            this.Name = name;
        }
    }
}
