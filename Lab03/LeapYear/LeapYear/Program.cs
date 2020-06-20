using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер года:");
            int n = int.Parse(Console.ReadLine());
            if (n % 4 == 0 && n % 100 !=0 || n % 400 == 0)
            {
                Console.WriteLine("Год високосный");
            }
            else
            {
                Console.WriteLine("Год невисокосный");
            }
        }
    }
}
