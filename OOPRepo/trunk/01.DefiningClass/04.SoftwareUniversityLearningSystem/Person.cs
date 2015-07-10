using System;

namespace _04.SoftwareUniversityLearningSystem
{
    public class Person
    {
        private string firstName;

        private string lastName;

        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0} {1}\nAge: {2}", this.FirstName, this.LastName, this.Age);
        }
    }
}
