using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Practice.shapes
{
    internal class Square : Rectangle
    {
        public Square(double side) : base(side, side) { }

        public override string ToString()
        {
            return "Square [side=" + getLength() + "]"; 
        }
    }
}
