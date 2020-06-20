using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    public class Manager : Person
    {
        public override int Salary()
        {
            return workExperience() * 3 / 1000;
        }

        public override string Work()
        {
            return "Manager";
        }

        override public void Info()
        {
            Console.WriteLine($"Person: {Work()}");
            Console.WriteLine($"Age: {Age()}");
            Console.WriteLine($"Name: {Name()}");
            Console.WriteLine($"Salary: {Salary()}");
        }

        public Manager(string name, int age, int startCareer)
        {
            this.name = name;
            this.age = age;
        }
    }
}
