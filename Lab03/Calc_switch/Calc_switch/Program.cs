using System;

namespace Calc_switch
{

    class CCalculatorExeption : Exception
    {
        public string getMessage()
        {
            return this.MessageTP;
        }
        private string MessageTP;
        public CCalculatorExeption(int key)
        {
            if (key == 1)
            {
                MessageTP = "Can't devide on zero";
            }
            else if(key == 2)
            {
                MessageTP = "Unknown operation";
            }
        }
    }   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A = ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Operation = ");
            string op = Console.ReadLine();
            Console.WriteLine("B = ");
            float b = float.Parse(Console.ReadLine());
            bool ok = true;
            float res = 0;
            switch (op)
            {
                case ("+"):
                    res = a + b;
                    break;
                case ("-"):
                    res = a - b;
                    break;
                case ("*"):
                    res = a * b;
                    break;
                case ("/"):
                case (":"):
                    res = a / b;
                    break;
                default:
                    ok = false;
                    break;
            }
            if (ok) {
                Console.WriteLine(" = {0}", res);
            }
            else
            {
                Console.WriteLine("Ошибка ввода");
            }
        }
    }
}
