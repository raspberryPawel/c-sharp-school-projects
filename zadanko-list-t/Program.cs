using System;
using System.Collections.Generic;

namespace zadanko4
{
    class Program
    {
        static void Main(string[] args)
        {
            var tasks = new List<Task>();

            Console.Write("Witaj! ");

            while (true)
            {
                Console.Write("Jeśli chcesz wyjść wpisz 1. Dodać nowe zadanie - 2. Edytować już istniejące 3. Usunąć - 4. Wyświetlić wszystkie - 5, posortować -6, usunąć wszytkie - 7 ");
                int action;
                Int32.TryParse(Console.ReadLine(), out action);
                Console.WriteLine();

                switch (action)
                {
                    case 1:
                        Environment.Exit(0);
                        break;
                    case 2:
                        AddNewTask(tasks);
                        ShowTasks(tasks);
                        break;
                    case 3:
                        ShowTasks(tasks, true);
                        EditTask(tasks);
                        break;
                    case 4:
                        ShowTasks(tasks, true);
                        RemoveTaks(tasks);
                        break;
                    case 5:
                        ShowTasks(tasks, true);
                        break;
                    case 6:
                        SortList(tasks);
                        break;
                    case 7:
                        RemoveAllTasks(tasks);
                        break;
                    default:
                        ShowMessage("Niepoprawna akcja. ");
                        break;

                }

            };
        }

        private static void ShowMessage(string message)
        {
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine();
        }

        private static void RemoveAllTasks(List<Task> tasks)
        {
            try
            {
                tasks.Clear();
                ShowMessage("Zadania poprawnie wyczyszczone. ");
            }
            catch
            {
                ShowMessage("Wystąpił błąd, spróbuj jeszcze raz. ");
            }
        }

      

        private static void SortList(List<Task> tasks)
        {
            try
            {
                tasks.Sort((x, y) => x.Priority.CompareTo(y.Priority));
                ShowMessage("Zadania poprawnie posortowane. ");
                ShowTasks(tasks, true);
                Console.WriteLine();
            }
            catch
            {
                ShowMessage("Wystąpił błąd, spróbuj jeszcze raz. ");
            }
        }

        private static void RemoveTaks(List<Task> tasks)
        {
            Console.Write("Podaj numer zadania które chcesz usunąć: ");
            int index;
            Int32.TryParse(Console.ReadLine(), out index);
            try {
                tasks.Remove(tasks[index - 1]);
                ShowMessage("Poprawnie usunięto zadanie ");
            }
            catch
            {
                ShowMessage("Wystąpił błąd, spróbuj jeszcze raz. ");
            }
        }

        private static void EditTask(List<Task> tasks)
        {
            try
            {
                Console.Write("Podaj numer zadania które chcesz edytować: ");
                int index;
                Int32.TryParse(Console.ReadLine(), out index);
                Console.Write("Podaj nazwę zadania: ");
                tasks[index - 1].Name = Console.ReadLine();
                Console.Write("Podaj priorytet zadania: ");
                int priotity = 0;
                Int32.TryParse(Console.ReadLine(), out priotity);
                tasks[index - 1].Priority = priotity;
                ShowMessage("Poprawnie edytowano zadanie ");
            }
            catch
            {
                ShowMessage("Wystąpił błąd, spróbuj jeszcze raz. ");
            }

        }

        private static void AddNewTask(List<Task> tasks)
        {
            Task newTask = new Task();
            Console.Write("Podaj nazwę nowego zadania: ");
            newTask.Name = Console.ReadLine();

            Console.Write("Podaj priorytet nowego zadania: ");
            int priotity = 0;
            Int32.TryParse(Console.ReadLine(), out priotity);
            newTask.Priority = priotity;
            try {
                tasks.Add(newTask);
                ShowMessage("Poprawnie dodano zadanie. git");
            }
            catch
            {
                ShowMessage("Wystąpił błąd, spróbuj jeszcze raz. ");
            }
        }

        private static void ShowTasks(List<Task> tasks, bool withIndex = false)
        {
            int i = 1;
            foreach (Task task in tasks)
            {
                if (withIndex)
                Console.Write($"{i}. ");
                Console.WriteLine($"{task.Name} ->  {task.Priority}");

                i++;
            }
        }
    }
}
