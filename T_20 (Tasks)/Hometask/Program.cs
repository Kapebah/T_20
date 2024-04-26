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
                calculator.Add("int");
                calculator.Substract("int");
                calculator.Multiply("int");
                calculator.Divide("int");

                WriteLine("\nОбъект №2\n");
                Calculator<int, double> calculator1 = new Calculator<int, double>(2, 4);
                calculator1.Add("double");
                calculator1.Substract("double");
                calculator1.Multiply("double");
                calculator1.Divide("double");

                WriteLine("\nОбъект №3\n");
                Calculator<int, string> calculator2 = new Calculator<int, string>(3, "5");
                calculator2.Add("string");
                calculator2.Substract("string");
                calculator2.Multiply("string");
                calculator2.Divide("string");
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
