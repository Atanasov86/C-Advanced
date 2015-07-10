using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _04.SoftwareUniversityLearningSystem
{
    class SULStest
    {
        static void Main()
        {
            
            Trainer trainerAK = new SeniorTrainer("Atanas","Kolev",22); 
            SeniorTrainer trainerSN = new SeniorTrainer("Svetlin","Nakov",30);

            Trainer trainerFK = new JuniorTrainer("Filip","Kolev",22);

            DropoutStudent studentAA = new DropoutStudent("Anton","Atanasov",29,"400123",4.67,"some reason");

            Student studentBB = new GraduateStudent("Boiko","Borisov",34,"400124",3.23);

            CurrentStudent currentStudentSS = new OnlineStudent("Stamat","Stamatov",23,"400143",4.56,"OOP");
            CurrentStudent currentStudentAS = new OnsiteStudent("Atanas", "Stamatov", 26, "400144", 5.56, "Java",5);
            CurrentStudent currentStudentTL = new OnlineStudent("Tonka", "Lambova", 29, "400145", 3.56, "JavaScript");

            List<Person> persons = new List<Person>()
            {
                trainerAK,
                trainerSN,
                trainerFK,
                studentAA,
                studentBB,
                currentStudentTL,
                currentStudentAS,
                currentStudentSS
            };

            trainerAK.CreateCourse("OOP");
            trainerSN.DeleteCourse("Advanced C#");

            var sortedCurrentStudent =
                persons.Where(person => person is CurrentStudent)
                    .OrderBy(person => ((Student) person).AverageGrade).Select(person => person);
            Console.WriteLine();
           
            foreach (var person in sortedCurrentStudent)
            {
                
                Console.WriteLine(person);
                Console.WriteLine();
            }
            studentAA.Reapply();
        }
    }
}
