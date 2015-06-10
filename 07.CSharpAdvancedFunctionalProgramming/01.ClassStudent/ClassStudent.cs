using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ClassStudent
{
    class Student
    {
        //FirstName, LastName, Age, FacultyNumber, Phone, Email, Marks (IList<int>), GroupNumber.
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public long FacultyNumber { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public List<int> Marks { get; set; }

        public int GroupNumber { get; set; }


        public Student (string firstName,string lastName,int age,long facultyNumber,string phone,string email,List<int> marks,int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }
    }
    class ClassStudent
    {
        static void Main()
        {
            var myStudents = new List<Student>
            {
                new Student("Sara", "Mills", 20, 400018997, "+359888727272", "smills0@marketwatch.com", new List<int> {3,4,5,5,6},2),
                new Student("Daniel", "Carter", 22, 400018998,"+359888727273", "dcarter1@buzzfeed.com", new List<int>{3,3,6,6,4},1),
                new Student("Aaron", "Gibson", 24, 400018999,"+359888727274", "agibson2@house.gov", new List<int>{3,4,5,6,4},1),
                new Student("William", "Alexander", 27, 400019000,"+359888727275", "walexander3@hexun.com", new List<int>{4,4,6,6,4},3),
                new Student("Mildred","Hansen", 22,400019001, "+359888727276","mhansen4@skype.com",new List<int>{4,4,6,3,5},2),
                new Student("Antonio","Gonzalez", 22,400019002, "+359888727277","agonzalez5@zdnet.com",new List<int>{5,3,6,3,5},1),
                new Student("Cheryl","Gray", 31,400019003, "+359888727278","cgray6@yahoo.com",new List<int>{5,5,6,5,5},1),
            };
            
        }
    }
}
