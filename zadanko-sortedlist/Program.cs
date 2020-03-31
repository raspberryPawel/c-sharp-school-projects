using System;
using System.Collections.Generic;

namespace zadanko_sortedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, Player> playersDict = new SortedList<string, Player>();

            while (true)
            {
                Console.Write("Jeśli chcesz wyjść wpisz 1. Dodać nowego pracownika- 2. Wyświetlić słownik - 3 ");
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

                            playersDict.Add(playerCode, newPlayer);
                        }
                        catch (ArgumentException)
                        {
                            ShowMessage("Pracownik z takim kodem już istnieje.");
                        }
                        break;
                    case 3:
                        foreach (KeyValuePair<string, Player> player in playersDict)
                        {
                            Console.WriteLine($"{player.Value.FirstName} {player.Value.LastName} - {player.Value.PlayerCode}");
                        }
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
