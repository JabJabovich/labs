using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    public class Teacher : Person
    {
        protected string faculty;

        public override string Work()
        {
            return "Teacher";
        }

        override public void Info()
        {
            Console.WriteLine($"Person: {Work()}");
            Console.WriteLine($"Age: {Age()}");
            Console.WriteLine($"Name: {Name()}");
            Console.WriteLine($"Salary: {Salary()}");
            Console.WriteLine($"Faculty: {faculty}");
        }

        public Teacher(string name, int age, string faculty, int startCareer, int salary)
        {
            this.name = name;
            this.age = age;
            this.faculty = faculty;
            this.startCareer = startCareer;
            this.salary = salary;
        }
    }
}
