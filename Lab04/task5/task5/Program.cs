using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения коэффициентов функции a, b и c: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double x1 = 0; double x2 = 0;
            int solution = Equation.Solve(a, b, c, ref x1, ref x2);
            switch (solution)
            {
                case (-1):
                    Console.WriteLine("Вещественных корней уравнения с коэффициентами a = {0} b = {1} c = {2} нет.",a,b,c);
                    break;
                case (0):
                    Console.WriteLine("Корень уравнения с коэффициентами a = {0} b = {1} c = {2} x = {3}.", a, b, c, x1);
                    break;
                case (1):
                    Console.WriteLine("Корни уравнения с коэффициентами a = {0} b = {1} c = {2} x1 = {3} x2 = {4}.", a, b, c,x1,x2);
                    break;
            }


        }
    }
}
