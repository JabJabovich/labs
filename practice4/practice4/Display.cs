using System;
using System.Collections.Generic;
using System.Text;

namespace practice4
{
    public class Display
    {
        public void Menu(Player player)
        {
            Console.Clear();
            Console.WriteLine("Ваш баланс равен " + player.Balance.ToString());
            Console.WriteLine("\t\tИгра Чет-Нечет");
            Console.WriteLine("Нажмите [A] чтобы добавить очки к балансу");
            Console.WriteLine("Нажмите [W] чтобы снять очки с баланса");
            Console.WriteLine("Нажмите [P] чтобы начать игру");
            Console.WriteLine("Нажмите [D] чтобы посмотреть список игроков");
            Console.WriteLine("Нажмите [Q] чтобы выйти из игры");
        }

        public void GameMenu(Player player)
        {
            Console.Clear();
            Console.WriteLine("Your balance is {0:c}", player.Balance);
            Console.WriteLine("Press [E] for even or [O] for odd number or [Q] to quit and then enter your bet");
        }

    }
}
