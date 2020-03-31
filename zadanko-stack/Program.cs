using System;
using System.Collections.Generic;

//najnowszy element ląduje na samym początku listy. 
//pop usuwa najnowszy element [najniższy index]

namespace zadanko_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<Player> players = new Stack<Player>();
            while (true)
            {
                Console.Write("Jeśli chcesz wyjść wpisz 1. Dodać nowego pracownika- 2. Wyświetlić słownik - 3, usuń najnowszy element - 4, wyczyść listę - 5:  ");
                int action;
                Int32.TryParse(Console.ReadLine(), out action);
                Console.WriteLine();

                switch (action)
                {
                    case 1:
                        Environment.Exit(0);
                        break;
                    case 2:
                        try
                        {
                            Player newPlayer = new Player();
                            Console.Write("Podaj imie pracownia: ");
                            newPlayer.FirstName = Console.ReadLine();
                            Console.Write("Podaj nazwisko pracownika: ");
                            newPlayer.LastName = Console.ReadLine();
                            Console.Write("Podaj kod pracownika: ");
                            string playerCode = Console.ReadLine();
                            newPlayer.PlayerCode = playerCode;

                            players.Push(newPlayer);
                        }
                        catch (ArgumentException)
                        {
                            ShowMessage("Pracownik z takim kodem już istnieje.");
                        }
                        break;
                    case 3:
                        if (players.Count > 0)
                        {
                            foreach (Player player in players)
                                Console.WriteLine($"{player.FirstName} {player.LastName} - {player.PlayerCode}");
                        }
                        else Console.WriteLine("Lista jest pusta.");
                        break;
                    case 4:
                        players.Pop();
                        break;
                    case 5:
                        players.Clear();
                        break;

                    default:
                        ShowMessage("Niepoprawna akcja. ");
                        break;

                }
            }
        }

        private static void ShowMessage(string message)
        {
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine();
        }
    }
}
