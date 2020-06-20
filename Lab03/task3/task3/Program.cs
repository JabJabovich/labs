using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты выстрела x и y: ");
            float x, y;
            int score = 0;
            int answer = 1;
            do
            {
                x = float.Parse(Console.ReadLine());
                y = float.Parse(Console.ReadLine());
                if (x * x + y * y <= 1)
                {
                    score += 10;
                    
                }else if(x * x + y * y <= 4)
                {
                    score += 5;
                    
                }else if(x*x + y*y <= 9)
                {
                    score += 1;
                    
                }
                Console.WriteLine("Выстрелите еще раз? Да = 1 Нет = 0");
                answer = int.Parse(Console.ReadLine());
            } while (answer != 0);
            Console.WriteLine("Ваш результат = " + score);
        }
    }
}
