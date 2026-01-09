using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Practice.shapes
{
    internal class EquilateralTriangle : Triangle
    {

        public EquilateralTriangle(double side) : base(side, side, side) { }

        public override double calculateAre()
        {
            double side = getA();
            return (Math.Sqrt(3) / 4) * side * side;
        }

        public override double calculatePerimeter()
        {
            return 3 * getA();
        }

        public override string ToString()
        {
            return "EquilateralTriangle [side=" + getA() + "]";
        }
    }
}
