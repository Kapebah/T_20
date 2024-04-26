using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WriteLine("Объект №1\n");
                Segment<int, int> segment = new Segment<int, int>(3, 5, 2, 8);
                WriteLine(segment.ToString());
                WriteLine();
                WriteLine($"Длина отрезка: {segment.Length("int")}\n\n");

                WriteLine("Объект №2\n");
                Segment<long, long> segment1 = new Segment<long, long>(2147483543, 1234567987, 453245671, 234567);
                WriteLine(segment1.ToString());
                WriteLine();
                WriteLine($"Длина отрезка: {segment1.Length("long")}\n\n");

                WriteLine("Объект №3\n");
                Segment<double, double> segment2 = new Segment<double, double>(4.6, 3.8, 1.5, 9.2);
                WriteLine(segment2.ToString());
                WriteLine();
                WriteLine($"Длина отрезка: {segment2.Length("double")}\n\n");

                WriteLine("Объект №4\n");
                Segment<byte, byte> segment3 = new Segment<byte, byte>(3, 4, 5, 6);
                WriteLine(segment3.ToString());
                WriteLine();
                WriteLine($"Длина отрезка: {segment3.Length("byte")}\n\n");
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
