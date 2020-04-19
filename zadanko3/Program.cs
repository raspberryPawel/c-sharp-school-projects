using System;

namespace zadanko3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            int dogsLength = 0;

            Console.Write($"Ile masz psów? Możesz dodać do 5 psów: ");
            a = Console.ReadLine();

            Int32.TryParse(a, out dogsLength);

            if (dogsLength > 0 && dogsLength <= 5)
            {
                Dog[] dogsArray = new Dog[dogsLength];

                for (int i = 0; i < dogsLength; i++)
                {
                    string name, buff;
                    int age;
                    Console.Write($"Podaj Imię {i + 1} psa: ");
                    name = Console.ReadLine();
                    Console.Write($"Podaj wiek {i + 1} psa: ");
                    buff = Console.ReadLine();

                    Int32.TryParse(buff, out age);
                    dogsArray[i] = new Dog(name, age);
                }

                ShowDogs(dogsLength, dogsArray, "dodano");

                while (true)
                {
                    Console.WriteLine($"");
                    Console.Write($"Jeśli chcesz edytować dane psa wciśnij 1, jeżeli chcesz wyjść 2: ");
                    string action = Console.ReadLine();
                    int action1;
                    Int32.TryParse(action, out action1);

                    switch (action1)
                    {
                        case 1:
                            string buff;
                            int action2;

                            Console.WriteLine("Wpisz numer psa którego wiek chcesz edytować: ");
                            for (int i = 0; i < dogsLength; i++)
                            {
                                Console.WriteLine($"{i}. {dogsArray[i].Name}, {dogsArray[i].Age}");
                            }
                            buff = Console.ReadLine();
                            Int32.TryParse(buff, out action2);

                            if (action2 >= 0 && action2 < dogsLength)
                            {
                                string buffor;
                                int age;
                                Console.Write($"Podaj wiek {dogsArray[action2].Name}:  ");
                                buffor = Console.ReadLine();
                                Int32.TryParse(buffor, out age);
                                dogsArray[action2].Age = age;
                                ShowDogs(dogsLength, dogsArray, "edytowano");
                            }
                            else { Console.WriteLine("Nie masz takiego psa.. "); }
                            break;
                        default:
                            Environment.Exit(0);
                            break;

                    }
                    Console.WriteLine("");
                }
            }
            else {
                Console.WriteLine("Podałeś nieprawidłową wartość");
            }

            Console.ReadKey();
        }

        private static void ShowDogs(int dogsLength, Dog[] dogsArray, string action)
        {
            Console.WriteLine($"");
            Console.WriteLine($"Poprawnie {action} {(action == "edytowano" ? "wiek psa" : $"{dogsLength} psy")}");
            Console.WriteLine($"");

            for (int i = 0; i < dogsLength; i++)
            {
                Console.WriteLine($"Imię {i + 1} psa: {dogsArray[i].Name}, wiek: {dogsArray[i].Age}");
            }
        }
    }
}
