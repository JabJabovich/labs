using System;
using System.Collections.Generic;
using System.Text;

namespace practice4
{
    public class EOGame : IRunner
    {
            public Player Player { get; set; }
            Display GameUI { get; set; }

            public EOGame(Player player, Display gameUI)
            {
                Player = player;
                GameUI = gameUI;
            }


            private void ProgramLoop()
            {
                try
                {
                    char decision;
                    if (Player.CheckBalance())
                    {
                        do
                        {
                            GameUI.Menu(Player);
                            decision = Char.Parse(Console.ReadLine());
                            switch (decision)
                            {
                                case 'Q':
                                    Console.WriteLine("До скорых встреч");
                                    break;
                                case 'A':
                                    Console.WriteLine("Внесите сумму дло пополнения (общая сумма не может быть больше 9999). Сейчас у вас " + Player.Balance.ToString());
                                    Player.AWChangeBalance(-1);
                                    break;
                                case 'W':
                                    Console.WriteLine("Выберите сумму снятия. Сейчас у вас " + Player.Balance.ToString());
                                    Player.AWChangeBalance(1);
                                    break;
                                case 'P':
                                    GameLoop();
                                    break;
                                default:
                                    Console.WriteLine("Неизвестная операция");
                                    System.Threading.Thread.Sleep(1250);
                                    break;
                            }
                        }
                        while (Player.CheckBalance() && decision != 'Q');
                    }
                    else { Console.WriteLine("У вас не осталось денег - вы все проиграли"); }
                }
                catch (Exception) { throw new Exception(); }
            }

            public void RunGame()
            {
                bool mistake = false;
                do
                {
                    try
                    {
                        mistake = false;
                        ProgramLoop();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Неизвестная операция");
                        System.Threading.Thread.Sleep(1250);
                        mistake = true;
                    }
                }
                while (mistake);
            }

            public void GameLoop()
            {
                try
                {
                    GameUI.GameMenu(Player);
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
                        if (bet > Player.Balance)
                        {
                            Console.WriteLine("Your bet is too big");
                            mistake = true;
                        }
                    } while (mistake);

                    if (Player.Balance + bet >= 9999)
                    {
                        Console.WriteLine("Ваш баланс может превышать 9999, уменьшить ставку до максимально возможной или выйти в меню");
                        char choise2 = char.Parse(Console.ReadLine());
                        if (choise2 == 'N')
                        {
                            return;
                        }
                        else
                        {
                            bet = 9999 - Player.Balance;
                        };
                    }

                    var random = new Random(1);
                    int ComputerNumber = random.Next();
                    bool exit = true;
                    do
                    {
                        switch (choise)
                        {
                            case 'E':
                                Console.WriteLine("Число = " + ComputerNumber);
                                if (Player.CheckWin(0, ComputerNumber))
                                {
                                    Console.WriteLine("Вы победили, {0} будет добавлено к вашему балансу", bet);
                                    Player.ChangeBalance(-bet);
                                }
                                else
                                {
                                    Console.WriteLine("Вы проиграли, ({0}) будет снято с баланса", bet);
                                    Player.ChangeBalance(bet);
                                }
                                break;
                            case 'O':
                                Console.WriteLine("Число = " + ComputerNumber);
                                if (Player.CheckWin(1, ComputerNumber))
                                {
                                    Console.WriteLine("Вы выиграли, {0} будет добавлено к вашему балансу", bet);
                                    Player.ChangeBalance(-(bet));
                                }
                                else
                                {
                                    Console.WriteLine("Вы проиграли, ({0}) будет снято с баланса", bet);
                                    Player.ChangeBalance(bet);
                                }
                                break;
                            default:
                                Console.WriteLine("Невверный ввод");
                                System.Threading.Thread.Sleep(1250);
                                exit = true;
                                break;
                        }
                    } while (!exit);
                    if (Player.CheckBalance())
                    {
                        Console.WriteLine("Нажмите [R]чтоыб сыграть заново или любую другую кнопку чтобы выйти");
                        char restart = char.Parse(Console.ReadLine());
                        if (restart == 'R')
                        {
                            GameLoop();
                        }
                    }

                }
                catch (Exception) { throw new Exception(); }

            }
        }
}
