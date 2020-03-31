using System;
using System.Collections.Generic;
using System.Linq;

namespace zadanko_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Player> playersDict = new Dictionary<int, Player>();

            while (true) {
                Console.Write("Jeśli chcesz wyjść wpisz 1. Dodać nowego pracownika- 2. Wyświetlić słownik - 3;");
                int action;
                Int32.TryParse(Console.ReadLine(), out action);
                Console.WriteLine();

                switch (action)
                {
                    case 1:
                        Environment.Exit(0);
                        break;
                    case 2:
                        Player newPlayer = new Player();
                        Console.Write("Podaj imie pracownia: ");
                        newPlayer.FirstName = Console.ReadLine();
                        Console.Write("Podaj nazwisko pracownika: ");
                        newPlayer.LastName = Console.ReadLine();
                        Console.Write("Podaj kod pracownika: ");
                        newPlayer.PlayerCode = Console.ReadLine();

                        playersDict.Add(playersDict.Count() + 1, newPlayer);
                        break;
                    case 3:
                        foreach (KeyValuePair<int, Player> player in playersDict)
                        {
                            Console.WriteLine($"{player.Key}. {player.Value.FirstName} {player.Value.LastName} - {player.Value.PlayerCode}");
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
