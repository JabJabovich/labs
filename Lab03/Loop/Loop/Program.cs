using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nwhile: \t\t");
            int i = 1;
            while (i <= n)
            {
                Console.Write(" " + i);
                i += 2;
            }
            Console.WriteLine("\ndo while: \t\t");
            i = 1;
            do
            {
                Console.Write(" " + i);
                i += 2;
            } while (i <= n);
            Console.WriteLine("\nfor: \t\t");
            for (i = 1; i <= n; i += 2)
            {
                Console.Write(" " + i);
            }

            double x, x1, x2, y;
            Console.WriteLine("\nВведите границы интервала");
            x1 = float.Parse(Console.ReadLine());
            x2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Вывод:");
            x = x1;
            do
            {
                y = Math.Sin(x);
                Console.Write(" " + y);
                x += 0.01;
            } while (x <= x2);

            int a, b, temp;
            Console.WriteLine("\nВведите a и b");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            temp = a;
            while(temp != b)
            {
                a = temp;
                if (a < b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }
                temp = a - b;
                a = b;
            }
            Console.WriteLine("НОД = " + temp);

            /*int[] MyArray = {1,2,3,4,5,6,7};
            for(i = 0; i < MyArray.Length; ++i)
            {
                if (i % 2 == 0)
                    MyArray[i] = 0;
                Console.Write(MyArray[i] + " ");
            }*/

            int[] MyArray;
            n = int.Parse(Console.ReadLine());
            MyArray = new int[n];
            for(i = 0; i < MyArray.Length; ++i)
            {
                Console.Write("a[{0}] = ", i);
                MyArray[i] = int.Parse(Console.ReadLine());
            }
            foreach (int p in MyArray) Console.Write("{0} ", p);

        }
    }
}
