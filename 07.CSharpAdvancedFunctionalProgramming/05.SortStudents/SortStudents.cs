using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.StudentsByGroup;

namespace _05.SortStudents
{
    class SortStudents
    {
        static void Main()
        {
            var myStudents = new List<Student>
            {
                new Student("Sara", "Mills", 20, "4000114", "+359 288727272", "smills0@abv.bg", new List<int> {2,2,5,5,6},2),
                new Student("Daniel", "Carter", 22, "4000214","+3592888727273", "dcarter1@buzzfeed.com", new List<int>{3,3,6,6,4},1),
                new Student("Aaron", "Gibson", 24, "4000312","02 888727274", "agibson2@abv.bg", new List<int>{3,4,5,3,4},1),
                new Student("William", "Alexander", 27, "4000415","+359 888727275", "walexander3@abv.bg", new List<int>{4,4,6,6,4},3),
                new Student("Mildred","Hansen", 22, "4000515", "+359 888727276","mhansen4@skype.com",new List<int>{2,2,2,3,5},2),
                new Student("Antonio","Gonzalez", 22, "4000614", "+359 888727277","agonzalez5@zdnet.com",new List<int>{5,2,2,3,5},1),
                new Student("Cheryl","Gray", 31, "4000713", "+359 2888727278","cgray6@yahoo.com",new List<int>{2,5,6,5,5},1),
            };

            var sortedStudents =
                from stu in myStudents
                orderby stu.FirstName descending, stu.LastName descending
                select stu;
            Console.WriteLine("That is with LINQ QUERY:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine("{0} {1}",student.FirstName,student.LastName);
                
            }

            
            var sortedStudentsWithLambda = myStudents.OrderByDescending(stu => stu.FirstName)
                .ThenByDescending(stu => stu.LastName);
            Console.WriteLine("That is with LAMBDA EXPRESSION:");
            foreach (var student in sortedStudentsWithLambda)
            {
                Console.WriteLine("{0} {1}",student.FirstName,student.LastName);
                
            }
        }
    }
}
