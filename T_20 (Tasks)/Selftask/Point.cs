using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Selftask
{
    class Point<T, K>
    {
        public T X { get; set; }
        public K Y { get; set; }
        public Point() { }
        public Point(T x, K y) {  X = x; Y = y; }
        public int Output()
        {
            WriteLine($"X = {X}\t\tY = {Y}");
            return 1;
        }
    }
}
