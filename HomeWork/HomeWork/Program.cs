﻿using System;

namespace HomeWork
{
    class Program
    {
        public static void Main(string[] args)
        {
            Person teacher = new Teacher("A", 25, "IKT", 2015, 400);
            Person student = new Student("Rusinov", 19, "IKT", "K3121");
            Person admin = new Admin("B", 41, "404", 80, 1999);
            Person manager = new Manager("C", 35, 2001);

            Person[] Persons = { teacher, student, admin, manager };

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("\n***********************************");
                Persons[i].Info();
                
            }
        }
    }
}
