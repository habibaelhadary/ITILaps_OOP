using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class _3Dpoint:point
    {
        public int Z { get; set; }
        public _3Dpoint()
        {

        }
        public _3Dpoint(int _x, int _y, int _z) : base(_x, _y)
        {

            Z = _z;
        }
        public override string ToString()
        {
            return $"Point Coordinates:   ({X},{Y},{Z})";
        }
        public static explicit operator string( _3Dpoint point )
        {
            return $"Point Coordinates:   ({point.X},{point.Y},{point.Z})";
        }
    }
}
