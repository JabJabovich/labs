using System;
using System.Collections.Generic;
using System.Text;

namespace task4
{
    class Operation
    {
        private static bool TriangleCheck(int a, int b, int c)
        {
            if (a + b <= c || b + c <= a || a + c <= b)
                return false;
            else
                return true;
        }

        public static double TriangleSquare(int a, int b, int c)
        {
           
            if (TriangleCheck(a, b, c))
            {
                float p = (float)(a + b + c) / 2;
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return s;
            }
            else
                throw new ArgumentException("Такого треугольника не существует");
   

        }
        public static double TriangleSquare(int a)
        {
            return Math.Sqrt(3) * Math.Pow(a,2) / 4;
        }
    }
}
