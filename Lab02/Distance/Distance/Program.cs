using System;

namespace Distance
{
    public struct Distance
    {
        public int foots;
        public int inches;
    }
    class Program
    {
        static void printDistance(Distance a)
        {
            Console.WriteLine("***Distance***");
            Console.WriteLine("foots: {0}'\ninches: {1}''", a.foots, a.inches);
        }
        static Distance structurize(Distance a)
        {
            while(a.inches / 12 != 0)
            {
                a.inches -= 12;
                a.foots += 1;
            }
            return a;
        }
        static void Main(string[] args)
        {
            Distance d1, d2, d3;
            d2.foots = int.Parse(Console.ReadLine());
            d2.inches = int.Parse(Console.ReadLine());
            d3.foots = int.Parse(Console.ReadLine());
            d3.inches = int.Parse(Console.ReadLine());
            d1.inches = d2.inches + d3.inches;
            d1.foots = d2.foots + d3.foots;
            d1 = structurize(d1);
            printDistance(d1);
            printDistance(d2);
            printDistance(d3);
        }
    }
}
