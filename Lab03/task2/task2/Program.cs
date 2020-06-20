using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите m и n: ");
            int k, m, s;
            s = 0;
            k = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            for (int i = 1; i <=100; i++)
            {
                if (i > k && i < m) continue;
                s += i;
            }
            Console.WriteLine("s = " + s);
        }
    }
}
