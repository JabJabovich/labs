using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Display
    {
            public static void Menu()
            {
                Console.Clear();
                Console.WriteLine("\t\tИгра Чет-Нечет");
                Console.WriteLine("Press [R] to read rules");
                Console.WriteLine("Press [B] to go to balance menu");
                Console.WriteLine("Press [S] to start game");
                Console.WriteLine("Press [Q] to quit");
            }

            public static void Rules()
            {
                Console.Clear();
                Console.WriteLine("Rules");
                Console.WriteLine("Press any key to go to menu");
                string exit = Console.ReadLine();
                Menu();
            }

            public static void GameMenu(ref int balance)
            {
                Console.Clear();
                Console.WriteLine("Your balance is {0:c}", balance);
                Console.WriteLine("Press [E] for even or [O] for odd number or [Q] to quit and then enter your bet");
            }

        }

}
