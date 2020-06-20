using System;

namespace Shapeifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x = ");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("y = ");
            float y = float.Parse(Console.ReadLine());
            if (x * x + y * y < 9 && y > 0)
            {
                Console.WriteLine("Внутри");
            } else if (x * x + y * y == 9 && y >= 0 || Math.Abs(x) < 3 && y == 0)
            {
                Console.WriteLine("На границе");
            }else
            {
                Console.WriteLine("Вне");
            }
        }
    }
}
