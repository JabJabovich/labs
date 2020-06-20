using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    public class Admin : Person
    {
        string lab;
        int sienceWorksCount;

        public override int Salary()
        {
            return (workExperience() / 1000) * sienceWorksCount;
        }

        public override string Work()
        {
            return "Admin";
        }

        override public void Info()
        {
            Console.WriteLine($"Person: {Work()}");
            Console.WriteLine($"Age: {Age()}");
            Console.WriteLine($"Name: {Name()}");
            Console.WriteLine($"Salary: {Salary()}");
            Console.WriteLine($"Lab: {lab}");
        }

        public Admin(string name, int age, string lab, int sienceWorksCount, int startCareer)
        {
            this.name = name;
            this.age = age;
            this.sienceWorksCount = sienceWorksCount;
            this.lab = lab;
        }
    }

}
