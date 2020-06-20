using System;

namespace square_of_triangle
{
    class CastomException:System.Exception
    {

    }
    class Square
    {
        static double Read()
        {
            string temp = Console.ReadLine();
            return Double.Parse(temp);
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите значение периметра треугольника:");
                double p = Read();
                double a = p / 3;
                double s = Math.Sqrt(3)*a*a/4;
                Console.WriteLine("Сторона\tПлощадь\n{0}\t{1}", a, s);
            }
            catch(Exception e)
            {
                Console.WriteLine("Ошибка! {0}", e.Message);
            }
        }
    }
}
