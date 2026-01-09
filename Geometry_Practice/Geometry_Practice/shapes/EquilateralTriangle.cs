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
            throw new NotImplementedException();
        }

        public override double calculatePerimeter()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
