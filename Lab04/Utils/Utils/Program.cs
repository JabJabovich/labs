using System;

namespace Utils
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x и y");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int greater = Utils.Greater(x, y);
            if (x != y)
                Console.WriteLine("Наибольшим из {0} и {1} является {2}", x, y, greater);
            else
                Console.WriteLine("Числа равны");
            Console.WriteLine("До swap: \t " + x + " " + y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("После swap: \t" + x + " " + y);
            int f;
            bool ok;
            Console.WriteLine("Число для теста Factorial: ");
            x = int.Parse(Console.ReadLine());
            ok = Utils.Factorial(x, out f);
            if (ok)
                Console.WriteLine("Factorial(" + x + ") = " + f);
            else
                Console.WriteLine("Факториал не компьютизируем");
        }
    }
}
