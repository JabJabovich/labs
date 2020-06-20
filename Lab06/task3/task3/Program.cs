using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Triangle t = new Triangle(5,2,4);
                t.PrintTheSides();
                Console.WriteLine("P = {0}", t.Perimetre());
                Console.WriteLine("S = {0}", t.Square());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            
            
            Console.WriteLine();
        }
    }
}
