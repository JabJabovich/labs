using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Game
    {
        public static bool CheckBalance(int balance)
        {
            return balance > 0;
        }

        public static void ChangeBalance(ref int balance, int changer)
        {
            balance -= changer;
        }

        public static void GameLoop(ref int balance)
        {
            try
            {
                Display.GameMenu(ref balance);
                char choise = char.Parse(Console.ReadLine());
                if (choise == 'Q')
                {
                    return;
                }
                bool mistake = false;
                int bet;
                do
                {
                    mistake = false;
                    bet = (int)uint.Parse(Console.ReadLine());
                    if (bet > balance)
                    {
                        Console.WriteLine("Your bet is too big");
                        mistake = true;
                    }
                } while (mistake);
                var random = new Random();
                int ComputerNumber = random.Next();
                bool exit = true;
                do
                {
                    switch (choise)
                    {
                        case 'E':
                            Console.WriteLine("Number = " + (int)ComputerNumber / 10000);
                            if (CheckWin(0, ComputerNumber))
                            {
                                Console.WriteLine("You win, {0:c} will be added to your balance", bet);
                                ChangeBalance(ref balance, -bet);
                            }
                            else
                            {
                                Console.WriteLine("You lost and lose your bet ({0:c})", bet);
                                ChangeBalance(ref balance, bet);
                            }
                            break;
                        case 'O':
                            Console.WriteLine("Number = " + (int)ComputerNumber / 10000);
                            if (CheckWin(1, ComputerNumber))
                            {
                                Console.WriteLine("You win, {0:c} will be added to your balance", bet);
                                ChangeBalance(ref balance, -(bet));
                            }
                            else
                            {
                                Console.WriteLine("You lost and lose your bet ({0:c})", bet);
                                ChangeBalance(ref balance, bet);
                            }
                            break;
                        default:
                            Console.WriteLine("Wrong operation. Try again");
                            choise = char.Parse(Console.ReadLine());
                            exit = true;
                            break;
                    }
                } while (!exit);
                if (CheckBalance(balance))
                {
                    Console.WriteLine("If you want to play again enter [R] or any key to exit");
                    char restart = char.Parse(Console.ReadLine());
                    if (restart == 'R')
                    {
                        GameLoop(ref balance);
                    }
                }

            }
            catch (Exception) { throw new Exception(); }

        }

        public static bool CheckWin(int key, int number)
        {
            return ((number % 2) - key == 0);
        }

        public static void MaKeGameBalance(ref int balance, ref bool success, int key)
        {

            int m = (int)uint.Parse(Console.ReadLine());
            if (Game.CheckBalance((int)balance - (key * m)))
            {
                Game.ChangeBalance(ref balance, (key * m));
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Success");
                System.Threading.Thread.Sleep(1250);
                success = true;
            }
            else
            {
                Console.WriteLine("You cannot withdraw this sum");
            }
        }

        public static void Balance(ref int balance)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Your current balanse is {0:c}", balance);
                bool success = false;
                if (balance == 0)
                {
                    Console.Write("How much money will you add? ");
                    MaKeGameBalance(ref balance, ref success, -1);
                }
                else
                {
                    Console.WriteLine("Would you like to add [A] some money or withdraw [W] them? Press[Q] to quit");
                    char choise = Char.Parse(Console.ReadLine());
                    if (choise == 'Q')
                    {
                        return;
                    }
                    do
                    {
                        switch (choise)
                        {
                            case 'A':
                                Console.Write("How much money will you add? ");
                                MaKeGameBalance(ref balance, ref success, -1);
                                break;
                            case 'W':
                                Console.Write("How much money will you withdraw? ");
                                MaKeGameBalance(ref balance, ref success, 1);
                                break;
                            case 'Q':
                                success = true;
                                break;
                            default:
                                Console.WriteLine("Wrong Operation");
                                choise = Char.Parse(Console.ReadLine());
                                break;
                        }
                    }
                    while (!success);
                }
            }
            catch (Exception) { throw new Exception(); }
        }

        public static void ProgramLoop(ref int balance)
        {
            try
            {
                char decision = 'S';
                if (CheckBalance(balance))
                {
                    do
                    {
                        Display.Menu();
                        decision = Char.Parse(Console.ReadLine());
                        switch (decision)
                        {
                            case 'Q':
                                break;
                            case 'B':
                                Balance(ref balance);
                                break;
                            case 'R':
                                Display.Rules();
                                break;
                            case 'S':
                                GameLoop(ref balance);
                                break;
                            default:
                                Console.WriteLine("Unknown opperation");
                                System.Threading.Thread.Sleep(1250);
                                break;
                        }
                    }
                    while (CheckBalance(balance) && decision != 'Q');
                    if (decision == 'Q')
                    {
                        Console.WriteLine("See you soon");
                    }
                    else
                    {
                        Console.WriteLine("You are out of money! Game over");
                    }
                }
            }
            catch (Exception) { throw new Exception(); }

        }
    }
}
