using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public point()
        {

        }
        public point(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }
        public override string ToString()
        {
            return $"({X} , {Y})";
        }
    }
}
