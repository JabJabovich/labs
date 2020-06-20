using System;
using System.Collections.Generic;
using System.Text;

namespace task5
{
    class Equation
    {
        public static int Solve(double a, double b, double c, ref double x1, ref double x2)
        {
           double d = b * b - 4 * a * c;
            if (d < 0)
            {
                return -1;
            }
            else if(d == 0)
            {
                x1 = x2 = -b / 2 * a;
                return 0;
            }else
            {
                x1 = (-b + Math.Sqrt(d)) / 2 * a;
                x2 = (-b - Math.Sqrt(d)) / 2 * a;
                return 1;
            }
        }
    }
}
