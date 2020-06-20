using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int balance = 0;
            bool mistake = false;
            do
            {
                try
                {
                    mistake = false;
                    if (balance == 0) { Game.Balance(ref balance); }
                    Game.ProgramLoop(ref balance);
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong, please wait");
                    System.Threading.Thread.Sleep(1000);
                    mistake = true;
                }
            }
            while (mistake);
        }
    }
}
