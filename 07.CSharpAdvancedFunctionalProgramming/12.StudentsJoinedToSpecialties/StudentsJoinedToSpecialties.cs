using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.StudentsJoinedToSpecialties
{
    class StudentsJoinedToSpecialties
    {
        static void Main()
        {
            var students = new List<Student>
            {
                new Student("215314", "Milena Kirova"),
                new Student("203114","Stefan Popov"),
                new Student("203314","Asya Manova"),
                new Student("203914","Diana Petrova"),	
                new Student("203814","Ivan Ivanov")	
            };

            var studentSpecialties = new List<StudentSpecialties>
            {
                new StudentSpecialties("Web Developer",	"203314"),
                new StudentSpecialties("Web Developer",	"203114"),
                new StudentSpecialties("PHP Developer",	"203814"),
                new StudentSpecialties("PHP Developer",	"203914"),
                new StudentSpecialties("QA Engineer", "203314"),
                new StudentSpecialties("Web Developer",	"203914")

            };

            var result =
                from student in students
                join studentSpecialty in studentSpecialties on student.FactNum equals studentSpecialty.FactNum
                select
                    new
                    {
                        StudentName = student.Name,
                        FactNum = student.FactNum,
                        Specialty = studentSpecialty.SpecialityName
                    };
            var sortedResult =
                from student in result
                orderby student.StudentName
                select student;
            foreach (var student in sortedResult)
            {
                Console.WriteLine("{0}   {1}   {2}",student.StudentName,student.FactNum,student.Specialty);
            }
        }
    }
}
