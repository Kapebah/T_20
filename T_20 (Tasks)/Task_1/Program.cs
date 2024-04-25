using System;
using System.Collections.Generic;
using static System.Console;


namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {


                List<Tourfirm> tourfirms = new List<Tourfirm>();
                bool flag = true;

                while (flag)
                {
                    WriteLine("1 - Поиск ИНН и прибыли фирмы" +
                        "\n2 - Сумарная прибыль всех фирм" +
                        "\n3 - Наибольшая прибыль" +
                        "\n4 - Удаление фирм" +
                        "\n5 - Добавление новой фирмы" +
                        "\n6 - Вывести все фирмы" +
                        "\n7 - Выйти");
                    switch (ReadKey(true).Key)
                    {
                        case ConsoleKey.D1:
                            Clear();
                            Write("Введите название фирмы: ");
                            string name = ReadLine();
                            foreach (var firm in tourfirms)
                            {
                                if (firm.Name == name)
                                {
                                    WriteLine($"ИНН фирмы: {firm.Inn}\nПрибыль: {firm.Income}$");
                                }
                                else
                                {
                                    Write($"Фирмы {name} нет\n");
                                }
                            }
                            break;
                        case ConsoleKey.D2:
                            Clear();
                            double totalIncome = 0;
                            foreach (var firm in tourfirms)
                            {
                                totalIncome += firm.Income;
                            }
                            WriteLine($"Прибыль всех фирм: {totalIncome}");
                            break;
                        case ConsoleKey.D3:
                            Clear();
                            tourfirms.Sort();
                            WriteLine($"Наибольшую прибыль имеет: {tourfirms[tourfirms.Count - 1].Name}  {tourfirms[tourfirms.Count - 1].Income}");
                            break;
                        case ConsoleKey.D4:
                            Clear();
                            Tourfirm tourfirm = null;
                            foreach (var firm in tourfirms)
                            {
                                if (firm.Income == 0)
                                {
                                    tourfirm = firm;
                                }
                            }
                            tourfirms.Remove(tourfirm);
                            WriteLine($"Вы удалили обанкротившуюся турфирму {tourfirm.Name}");
                            break;
                        case ConsoleKey.D5:
                            tourfirms.Add(Tourfirm.Input());
                            break;
                        case ConsoleKey.D6:
                            Clear();
                            tourfirms.Sort();
                            foreach (var firm in tourfirms)
                            {
                                WriteLine(firm.ToString());
                                WriteLine();
                            }
                            break;
                        case ConsoleKey.D7:
                            Environment.Exit(0);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
