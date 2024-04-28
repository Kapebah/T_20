using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Task_with_triangle
{
    class Segment<T, K> : Point<T, K> where T : Segment<T, K>
    {
        /// <summary>
        /// Координаты точек
        /// </summary>
        public T X1 { get; set; }
        public T Y1 { get; set; }
        public K X2 { get; set; }
        public K Y2 { get; set; }

        /// <summary>
        /// Конструкторы
        /// </summary>
        public Segment() { }
        public Segment(T x1, T y1, K x2, K y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        /// <summary>
        /// Метод вывода
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"Точки отрезка: \nX1 = {X1}\t\tX2 = {X2}\nY1 = {Y1}\t\tY2 = {Y2}";

        public dynamic Length(string format)
        {
            if (format == "int" || format == "long" || format == "double")
            {
                dynamic x1 = X1;
                dynamic y1 = Y1;
                dynamic x2 = X2;
                dynamic y2 = Y2;
                return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            }
            else { WriteLine("!!! Неверный формат\n"); return 0; }
        }

        public static Segment<T, K> Input()
        {
            Write("Введите координаты первой точки отрезка: \nx = ");
            T x1 = (T)Convert.ChangeType(ReadLine(), typeof(T));
            Write("y = ");
            T y1 = (T)Convert.ChangeType(ReadLine(), typeof(T));
            Write("\nВведите координаты второй точки отрезка: \nx = ");
            K x2 = (K)Convert.ChangeType(ReadLine(), typeof(K));
            Write("y = ");
            K y2 = (K)Convert.ChangeType(ReadLine(), typeof(K));

            return new Segment<T, K>(x1, y1, x2, y2);
        }
    }
}
