using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem
{
    public class Student : Person
    {
        private string studentNumber;

        private double averageGrade;

        public Student(string firstName, string lastName, int age, string studentNumber, double averageGrade) : base(firstName, lastName, age)
        {
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
        }

        public string StudentNumber { get; set; }

        public double AverageGrade { get; set; }

        public override string ToString()
        {
            return string.Format("{0}\nStudent Number: {1}\nAverage Grade: {2}", base.ToString(), this.StudentNumber,
                this.AverageGrade);
        }
    }
}
