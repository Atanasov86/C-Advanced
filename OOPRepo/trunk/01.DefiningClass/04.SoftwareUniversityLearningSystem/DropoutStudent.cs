using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem
{
    class DropoutStudent : Student
    {
        private string dropoutReason;

        public DropoutStudent(string firstName, string lastName, int age, string studentNumber, double averageGrade, string dropoutReason) 
                            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.DropoutReason = dropoutReason;
        }

        public string DropoutReason { get; set; }

        public void Reapply()
        {
            Console.WriteLine(string.Format("Name: {0} {1}\nAge: {2}\nStudent Number: {3}\nAverage Grage: {4}\nDropout Reason: {5}",
                    this.FirstName, this.LastName,this.Age, this.StudentNumber, this.AverageGrade, this.DropoutReason));
        }
    }
}
