using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Каков тип треугольника? \n 1 - Равносторонний 2 - Обыкновенный");
            int ans = int.Parse(Console.ReadLine());
            switch (ans)
            {
                case (1):
                    Console.WriteLine("Введите сторону треугольника");
                    int a = int.Parse(Console.ReadLine());
                    double s = Operation.TriangleSquare(a);
                    Console.WriteLine("Площадь = " + s);
                    break;
                case (2):
                    Console.WriteLine("Введите стороны треугольника");
                    try
                    {
                        a = int.Parse(Console.ReadLine());
                        int b = int.Parse(Console.ReadLine());
                        int c = int.Parse(Console.ReadLine());
                        s = Operation.TriangleSquare(a, b, c);
                        Console.WriteLine("Площадь = " + s);
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Такого треугольника не существует");
                    }
                    break;
            }
        }
    }
}
