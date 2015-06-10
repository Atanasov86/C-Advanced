using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.StudentsByGroup;

namespace _10.StudentsEnrolledIn2014
{
    class StudentsEnrolledIn2014
    {
        static void Main()
        {
            var myStudents = new List<Student>
            {
                new Student("Sara", "Mills", 20, "1000114", "+359 288727272", "smills0@abv.bg", new List<int> {2,2,5,5,6},2),
                new Student("Daniel", "Carter", 22, "1000214","+3592888727273", "dcarter1@buzzfeed.com", new List<int>{3,3,6,6,4},1),
                new Student("Aaron", "Gibson", 24, "1000312","02 888727274", "agibson2@abv.bg", new List<int>{3,4,5,3,4},1),
                new Student("William", "Alexander", 27, "1000415","+359 888727275", "walexander3@abv.bg", new List<int>{4,4,6,6,4},3),
                new Student("Mildred","Hansen", 22, "1000515", "+359 888727276","mhansen4@skype.com",new List<int>{2,2,2,3,5},2),
                new Student("Antonio","Gonzalez", 22, "1000614", "+359 888727277","agonzalez5@zdnet.com",new List<int>{5,2,2,3,5},1),
                new Student("Cheryl","Gray", 31, "1000713", "+359 2888727278","cgray6@yahoo.com",new List<int>{2,5,6,5,5},1),
            };

            var enrolledStudentsIn2014 =
                from student in myStudents
                where student.FacultyNumber.Contains("14")
                select student;

            foreach (var student in enrolledStudentsIn2014)
            {
                Console.WriteLine("{0} {1} -> {2}",student.FirstName,student.LastName,student.FacultyNumber);
            }
            
        }
    }
}
