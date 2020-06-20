using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array;
            Console.WriteLine("Enter the length of array");
            int n = int.Parse(Console.ReadLine());
            Array = new int[n];
            for (int i = 0; i < Array.Length; ++i)
            {
                Console.Write("а[{0}]= ", i);
                Array[i] = int.Parse(Console.ReadLine());
            }
            SumOfElemets(Array);
            AverageValue(Array);
            SumOfPolarElemets(Array);
            SumOfOddOrEvenElemetns(Array);

        }

        private static void SumOfOddOrEvenElemetns(int[] Array)
        {
            int answer;
            Console.WriteLine("Are u wanna add up odd or even elemets(1 = odd; 2 = even)");
            answer = int.Parse(Console.ReadLine());
            int sum = 0;
            switch (answer)
            {
                case (1):
                    for (int i = 0; i < Array.Length; ++i)
                    {
                        if (Array[i] % 2 == 1)
                            sum += Array[i];
                    }
                    Console.WriteLine("Sum of odd elements = " + sum);
                    break;
                case (2):
                    for (int i = 0; i < Array.Length; ++i)
                    {
                        if (Array[i] % 2 == 0)
                            sum += Array[i];
                    }
                    Console.WriteLine("Sum of even elements = " + sum);
                    break;
            }
        }

        private static void SumOfPolarElemets(int[] Array)
        {
            int answer;
            Console.WriteLine("Are u wanna add up + or - elemets(1 = +; 2 = -)");
            answer = int.Parse(Console.ReadLine());
            int sum = 0;
            switch (answer)
            {
                case (1):
                    for (int i = 0; i < Array.Length; ++i)
                    {
                        if (Array[i] > 0)
                            sum += Array[i];
                    }
                    Console.WriteLine("Sum of + elements = " + sum);
                    break;
                case (2):
                    for (int i = 0; i < Array.Length; ++i)
                    {
                        if (Array[i] < 0)
                            sum += Array[i];
                    }
                    Console.WriteLine("Sum of - elements = " + sum);
                    break;
            }
        }

        private static void AverageValue(int[] Array)
        {
            double averageValue = 0;
            for (int i = 0; i < Array.Length; ++i)
            {
                averageValue += Array[i];
            }
            averageValue /= Array.Length;
            Console.WriteLine("Average value = " + averageValue);
        }

        private static void SumOfElemets(int[] Array)
        {
            int sum = 0;
            for (int i = 0; i < Array.Length; ++i)
            {
                sum += Array[i];
            }
            Console.WriteLine("Summa of all elements = " + sum);
        }
    }
}
