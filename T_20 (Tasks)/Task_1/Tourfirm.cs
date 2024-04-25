using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace Task_1
{
    class Tourfirm : IComparable<Tourfirm>
    {
        public string Name { get; set; }
        public int YearOfCreate { get; set; }
        public string Inn { get; set; }
        public double Income { get; set; }
        public Tourfirm() { }
        public Tourfirm(string name, int yearOfCreate, string inn, double income)
        {
            Name = name;
            YearOfCreate = yearOfCreate;
            Inn = inn;
            Income = income;
        }
        public override string ToString()
        {
            return $"Название турфирмы: {Name}\nГод основания: {YearOfCreate}\nИНН: {Inn}\nПрибыль: {Income}";
        }
        public static Tourfirm Input()
        {
            Write("Введите название турфирмы: ");
            string name = ReadLine();
            Write("Введите год основания: ");
            int year = Convert.ToInt32(ReadLine());
            Write("Введите ИНН: ");
            string inn = ReadLine();
            Write("Введите прибыль: ");
            double income = Convert.ToDouble(ReadLine());

            return new Tourfirm(name, year, inn, income);
        }

        public int CompareTo(Tourfirm obj) => Income.CompareTo(obj.Income);
    }
}
