using System;

namespace ProjektZaliczeniowy
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            int a1, b1;
            Console.WriteLine("Dzielenie liczb");
            Console.Write("Podaj pierwszą liczbę: ");
            a = Console.ReadLine();
            Console.Write("Podaj drugą liczbę: ");
            b = Console.ReadLine();

            Int32.TryParse(a, out a1);
            Int32.TryParse(b, out b1);

            try
            {
                int wynik = a1 / b1;
                Console.Write($"Wynik {a1}/{b1} to: {wynik}");
            }
            catch (DivideByZeroException e) //wyłapanie próby podzielenia przez 0
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
