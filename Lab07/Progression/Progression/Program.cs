using System;

namespace Progression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первый член арифметической прогрессии и ее разность: ");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("d = ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер желаемого члена прогрессии:");
            int k = int.Parse(Console.ReadLine());
            ArithmeticProgression arith = new ArithmeticProgression(a, d);
            Console.WriteLine("Желаемый член прогрессии равен {0}", arith.GetElement(k));

            Console.WriteLine("Введите первый член геометрической прогрессии и ее делитель: ");
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("q = ");
            int q = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер желаемого члена прогрессии:");
            k = int.Parse(Console.ReadLine());
            GeometricProgression geom = new GeometricProgression(b, q);
            Console.WriteLine("Желаемый член прогрессии равен {0}", geom.GetElement(k));
        }
    }
}
