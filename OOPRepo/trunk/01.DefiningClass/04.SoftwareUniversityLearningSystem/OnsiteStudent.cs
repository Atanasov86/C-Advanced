using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem
{
    class OnsiteStudent : CurrentStudent
    {
        private int numberOfVisit;

        public OnsiteStudent(string firstName, string lastName, int age, string studentNumber, double averageGrade, string currentCourse, int numberOfVisit) 
                        : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
            this.NumberOfVisit = numberOfVisit;
        }

        public int NumberOfVisit { get; set; }

        public override string ToString()
        {
            return base.ToString() + String.Format("Number of visits: {0}", this.NumberOfVisit);
        }
    }
}
