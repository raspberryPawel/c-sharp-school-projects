using System;

namespace zadanko2
{
    class Program
    {
        static void Dodawanie(ref int x, ref int y) //przekazując przez referencję dajemy dostęp do zmiennej z poziomu funkcji (zmiana tutaj powoduje zmianę w funkcji Main)
        {
           // x = 1234;
            Console.WriteLine($"Wynik to {x + y}");
        }

        static void Odejmowanie(int x, int y) //przekazując przez wartość void ma dostęp tylko do wartości (zmiana jest lokalna -> nie ma wpływu na funkcje main)
        {
           // x = 1234;
            Console.WriteLine($"Wynik to {x - y}");
        }

        static void Main(string[] args)
        {
            string a, b, action;
            int a1, b1, action1;
            Console.WriteLine("Kalkulator Dodawanie i Odejmowanie"); 

            Console.Write("Podaj pierwszą liczbę: ");
            a = Console.ReadLine();

            Console.Write("Podaj drugą liczbę: ");
            b = Console.ReadLine();

            Console.Write("Wpisz: Dodawanie - 1, Odejmowanie - 2: ");
            action = Console.ReadLine();

            Int32.TryParse(action, out action1);
            Int32.TryParse(a, out a1);
            Int32.TryParse(b, out b1);

            switch (action1)
            {
                case 1:
                    Console.Write($"Akcja: Dodawanie.");
                    Dodawanie(ref a1, ref b1);
                    break;
                case 2:
                    Console.Write($"Akcja: Odejmowanie.");
                    Odejmowanie(a1, b1);
                    break;
                default:
                    Console.WriteLine($"Podałeś nieprawidłową akcję.");
                    break;
            }

            //Console.WriteLine($"a1: {a1}"); //po akcji dodawanie a1 = 1234 po akcji odejmownaie a1 = to co wpisane;

            Console.ReadKey();
        }
    }
}
