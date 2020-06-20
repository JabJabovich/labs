using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    abstract public class Person : IEmployee
    {
        protected string name;
        protected int age;
        protected int salary;
        protected int startCareer;

        public string Name()
        {
            return name;
        }

        public int Age()
        {
            return age;
        }

        virtual public int workExperience()
        {
            return 2020 - startCareer;
        }

        virtual public int Salary()
        {
            return salary;
        }

        virtual public string Work()
        {
            return "None";
        }

        virtual public int StartCareer()
        {
            return startCareer;
        }

        virtual public void Info()
        {
            Console.WriteLine($"Person: {Work()}");
            Console.WriteLine($"Age: {Age()}");
            Console.WriteLine($"Name: {Name()}");
            Console.WriteLine($"Salary: {Salary()}");
        }
    }
}
