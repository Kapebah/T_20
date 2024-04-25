using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Hometask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WriteLine("Объект №1\n");
                Calculator<int, int> calculator = new Calculator<int, int>(1, 2);
                calculator.Add();
                calculator.Substract();
                calculator.Multiply();
                calculator.Divide();

                WriteLine("\nОбъект №2\n");
                Calculator<int, double> calculator1 = new Calculator<int, double>(2, 4);
                calculator1.Add();
                calculator1.Substract();
                calculator1.Multiply();
                calculator1.Divide();

                WriteLine("\nОбъект №3\n");
                Calculator<int, string> calculator2 = new Calculator<int, string>(3, "5");
                calculator2.Add();
                calculator2.Substract();
                calculator2.Multiply();
                calculator2.Divide();
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
