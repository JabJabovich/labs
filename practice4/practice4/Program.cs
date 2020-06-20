using System;

namespace practice4
{
    class S
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стартовый баланс");
            int balance = int.Parse(Console.ReadLine());
            Player player = new Player(balance);

            Display UI = new Display();

            IRunner runner = new EOGame(player, UI);

            runner.RunGame();

            Console.Clear();

            runner.RunGame();
        }
    }
}
