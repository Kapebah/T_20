using Microsoft.SqlServer.Server;
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
        public void Add(string format)
        {
            if (format == "int" || format == "double")
            {
                dynamic a = Value1;
                dynamic b = Value2;
                Console.WriteLine($"{Value1} + {Value2} = {a + b}");
            }
            else if (format == "string")
            {
                dynamic a = Convert.ToDouble(Value1);
                dynamic b = Convert.ToDouble(Value2);
                Console.WriteLine($"{Value1} + {Value2} = {a + b}");
            }
        }
        public void Substract(string format)
        {
            if (format == "int" || format == "double")
            {
                dynamic a = Value1;
                dynamic b = Value2;
                Console.WriteLine($"{Value1} + {Value2} = {a + b}");
            }
            else if (format == "string")
            {
                dynamic a = Convert.ToDouble(Value1);
                dynamic b = Convert.ToDouble(Value2);
                Console.WriteLine($"{Value1} - {Value2} = {a - b}");
            }
        }

        public void Multiply(string format)
        {
            if (format == "int" || format == "double")
            {
                dynamic a = Value1;
                dynamic b = Value2;
                Console.WriteLine($"{Value1} + {Value2} = {a + b}");
            }
            else if (format == "string")
            {
                dynamic a = Convert.ToDouble(Value1);
                dynamic b = Convert.ToDouble(Value2);
                Console.WriteLine($"{Value1} * {Value2} = {a * b}");
            }
        }

        public void Divide(string format)
        {
            if (format == "int" || format == "double")
            {
                dynamic a = Value1;
                dynamic b = Value2;
                Console.WriteLine($"{Value1} / {Value2} = {a / b}");
            }
            else if (format == "string")
            {
                dynamic a = Convert.ToDouble(Value1);
                dynamic b = Convert.ToDouble(Value2);
                Console.WriteLine($"{Value1} / {Value2} = {a / b}");
            }
        }
    }
}
