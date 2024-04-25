using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask
{
    class Calculator<T, K>
    {
        public T Value1 { get; set; }
        public K Value2 { get; set; }
        public Calculator() { }
        public Calculator(T value1, K value2) {  Value1 = value1; Value2 = value2; }
        public void Add()
        {
            if (typeof(T) == typeof(int) || typeof(K) == typeof(int) || typeof(T) == typeof(double) || typeof(K) == typeof(double) || typeof(T) == typeof(string) || typeof(K) == typeof(string))
            {
                double a = Convert.ToDouble(Value1);
                double b = Convert.ToDouble(Value2);
                Console.WriteLine($"{Value1} + {Value2} = {a + b}");
            }
            else { Console.WriteLine("Неверный тип"); }
        }
        public void Substract()
        {
            if (typeof(T) == typeof(int) || typeof(K) == typeof(int) || typeof(T) == typeof(double) || typeof(K) == typeof(double) || typeof(T) == typeof(string) || typeof(K) == typeof(string))
            {
                double a = Convert.ToDouble(Value1);
                double b = Convert.ToDouble(Value2);
                Console.WriteLine($"{Value1} - {Value2} = {a - b}");
            }
            else { Console.WriteLine("Неверный тип"); }
        }

        public void Multiply()
        {
            if (typeof(T) == typeof(int) || typeof(K) == typeof(int) || typeof(T) == typeof(double) || typeof(K) == typeof(double) || typeof(T) == typeof(string) || typeof(K) == typeof(string))
            {
                double a = Convert.ToDouble(Value1);
                double b = Convert.ToDouble(Value2);
                Console.WriteLine($"{Value1} * {Value2} = {a * b}");
            }
            else { Console.WriteLine("Неверный тип"); }
        }

        public void Divide()
        {
            if (typeof(T) == typeof(int) || typeof(K) == typeof(int) || typeof(T) == typeof(double) || typeof(K) == typeof(double) || typeof(T) == typeof(string) || typeof(K) == typeof(string))
            {
                double a = Convert.ToDouble(Value1);
                double b = Convert.ToDouble(Value2);
                Console.WriteLine($"{Value1} / {Value2} = {a / b}");
            }
            else { Console.WriteLine("Неверный тип"); }
        }
    }
}
