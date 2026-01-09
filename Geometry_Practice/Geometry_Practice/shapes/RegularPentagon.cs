using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Practice.shapes
{
    internal class RegularPentagon : Shape
    {
        private double side;

        public RegularPentagon(double side) { 
            this.side = side;
        }
        public override double calculateAre()
        {
            return (1 / 4.0) * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * side * side;
        }

        public override double calculatePerimeter()
        {
            return side * 5;
        }

        public override string ToString()
        {
            return "Pentagon [side=" + side + "]";
        }
    }
}
