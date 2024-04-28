using System;
using static System.Console;

namespace Task_with_triangle
{
    class Triangle<T, K> : Segment<T, K> 
    {
        /// <summary>
        /// Третья вершина треугольника
        /// </summary>
        public T X3 { get; set; }
        public K Y3 { get; set; }

        /// <summary>
        /// Конструкторы
        /// </summary>
        public Triangle() { }
        public Triangle(T x1, T y1, K x2, K y2, T x3, K y3) : base(x1, y1, x2, y2)
        {
            (dynamic a, dynamic b, dynamic c) = CalculateSides(x1, y1, x2, y2, x3, y3);
            if (a < (b + c) && b < (a + c) && c < (a + b))
            {
                X3 = x3; Y3 = y3;
            }
            else { Write($"Треугольник не существует."); }
        }

        /// <summary>
        /// Метод расчёта сторон треугольника
        /// </summary>
        /// <returns></returns>
        private (dynamic, dynamic, dynamic) CalculateSides(T x1, T y1, K x2, K y2, T x3, K y3)
        {
            dynamic side1 = Math.Sqrt(Math.Pow((dynamic)x2 - x1, 2) + Math.Pow((dynamic)y2 - y1, 2));
            dynamic side2 = Math.Sqrt(Math.Pow((dynamic)x3 - x2, 2) + Math.Pow((dynamic)y3 - y2, 2));
            dynamic side3 = Math.Sqrt(Math.Pow((dynamic)x1 - x3, 2) + Math.Pow((dynamic)y1 - y3, 2));

            return (side1, side2, side3);
        }

        /// <summary>
        /// Метод вывода
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            (dynamic a, dynamic b, dynamic c) = CalculateSides(X1, Y1, X2, Y2, X3, Y3);
            return $"Cторона А: {a}\nСторона В: {b}\nСторона С: {c}";
        }

        /// <summary>
        /// Площадь треугольника
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        public dynamic Area(string format)
        {
            if(format == "int" || format == "uint" || format == "double")
            {
                (dynamic a, dynamic b, dynamic c) = CalculateSides(X1, Y1, X2, Y2, X3, Y3);
                dynamic p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            else { WriteLine("Неверный формат."); return 0; }
        }

        /// <summary>
        /// Ввод с клавиатуры
        /// </summary>
        /// <returns></returns>
        public static Triangle<T, K> Input()
        {
            Write("Введите координаты точек стороны А: \nx = ");
            T x1 = (T)Convert.ChangeType(ReadLine(), typeof(T));
            Write("y = ");
            T y1 = (T)Convert.ChangeType(ReadLine(), typeof(T));
            Write("\nВведите координаты точек стороны B: \nx = ");
            K x2 = (K)Convert.ChangeType(ReadLine(), typeof(K));
            Write("y = ");
            K y2 = (K)Convert.ChangeType(ReadLine(), typeof(K));
            Write("\nВведите координаты точек стороны С: \nx = ");
            T x3 = (T)Convert.ChangeType(ReadLine(), typeof(T));
            Write("y = ");
            K y3 = (K)Convert.ChangeType(ReadLine(), typeof(K));

            return new Triangle<T, K>(x1, y1, x2, y2, x3, y3);
        }
    }
}
