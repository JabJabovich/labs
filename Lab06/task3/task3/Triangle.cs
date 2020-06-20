using System;
using System.Collections.Generic;
using System.Text;

namespace task3
{
    class Triangle
    {
        private double Side_A;
        private double Side_B;
        private double Side_C;
        private void CheckIsThisTriangle()
        {
            if (Side_A >= Side_B + Side_C || Side_B >= Side_A + Side_C || Side_C >= Side_A + Side_B)
                throw new ArgumentException("This is not a triangle!");
        }
        public Triangle(double a, double b, double c)
        {
            Side_A = a;
            Side_B = b;
            Side_C = c;
            CheckIsThisTriangle();
        }
        public void PrintTheSides()
        {
            Console.WriteLine("Sides:\n a = {0}\n b = {1}\n c = {2}", Side_A, Side_B, Side_C);
        }

        public double Perimetre()
        {
            return (Side_A + Side_B + Side_C);
        }

        public double Square()
        {
            double p = this.Perimetre()/2;
            return (Math.Sqrt(p*(p-Side_A)*(p-Side_B)*(p-Side_C)));
        }

    }
}
