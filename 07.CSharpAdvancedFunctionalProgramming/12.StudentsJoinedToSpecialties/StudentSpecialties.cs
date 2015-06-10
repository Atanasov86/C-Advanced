using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.StudentsJoinedToSpecialties
{
    public class StudentSpecialties
    {
        public string SpecialityName { get; set; }
        public string FactNum { get; set; }

        public StudentSpecialties (string specialityName, string factNum)
        {
            this.SpecialityName = specialityName;
            this.FactNum = factNum;
        }
    }
}
