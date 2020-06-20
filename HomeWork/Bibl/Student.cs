using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    public class Student : Person
    {
        string faculty;
        string group;

        public override string Work()
        {
            return "Student";
        }

        public override int StartCareer()
        {
            return 0;
        }

        public override int Salary()
        {
            return 0;
        }

        public override int workExperience()
        {
            return 0;
        }

        override public void Info()
        {
            Console.WriteLine($"Person: {Work()}");
            Console.WriteLine($"Age: {Age()}");
            Console.WriteLine($"Name: {Name()}");
            Console.WriteLine($"Group: {group}");
            Console.WriteLine($"Faculty: {faculty}");
        }

        public Student(string name, int age, string faculty, string group)
        {
            this.name = name;
            this.age = age;
            this.faculty = faculty;
            this.group = group;
        }
    }
}
