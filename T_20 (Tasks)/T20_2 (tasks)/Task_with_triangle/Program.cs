using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Task_with_triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Segment<double, double>> segments = new List<Segment<double, double>>();
                List<Triangle<double, double>> triangles = new List<Triangle<double, double>>();
                bool flag = true;

                while (flag)
                {
                    WriteLine("Выберите действие: " +
                        "\n1 - Создать отрезок" +
                        "\n2 - Создать треугольник" +
                        "\n3 - Вывести все отрезки" +
                        "\n4 - Вывести все треугольники" +
                        "\n5 - Вывести длинны отрезков" +
                        "\n6 - Вывести площадь треугольников");
                    switch (ReadKey(true).Key)
                    {
                        case ConsoleKey.D1:
                            Clear();
                            segments.Add(Segment<double, double>.Input());
                            WriteLine();
                            break;
                        case ConsoleKey.D2:
                            Clear();
                            triangles.Add(Triangle<double, double>.Input());
                            WriteLine();
                            break;
                        case ConsoleKey.D3:
                            Clear();
                            foreach(var segment in segments)
                            {
                                WriteLine(segment.ToString());
                                WriteLine();
                            }
                            break;
                        case ConsoleKey.D4:
                            Clear();
                            foreach(var triangle in triangles)
                            {
                                WriteLine(triangle.ToString());
                                WriteLine();
                            }
                            break;
                        case ConsoleKey.D5:
                            Clear();
                            foreach (var segment in segments)
                            {
                                WriteLine($"Длина отрезка: {segment.Length("double"):f2}");
                                WriteLine();
                            }
                            break;
                        case ConsoleKey.D6:
                            Clear();
                            foreach (var triangle in triangles)
                            {
                                WriteLine($"Площадь треугольника: {triangle.Area("double"):f2}");
                                WriteLine();
                            }
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
