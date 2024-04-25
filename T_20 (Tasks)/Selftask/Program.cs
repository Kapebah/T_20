using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Selftask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WriteLine("Объект №1 с целым типом");
                Point<int, int> ints = new Point<int, int>(5, 7);
                ints.Output();
                WriteLine();

                WriteLine("Объект №1 с вещественным типом");
                Point<double, double> doubles = new Point<double, double>(6.3, 9.8);
                doubles.Output();
                WriteLine();

                WriteLine("Объект №1 со строковым типом");
                Point<string, string> strings = new Point<string, string>("98", "32");
                strings.Output();
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
