using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Practice.shapes
{
    internal class Circle : Shape
    {
        private double r;

        public Circle(double r)
        {
            this.r = r;
        }
        public override double calculateAre()
        {
            return Math.PI * r * r;
        }

        public override double calculatePerimeter()
        {
            return 2 * Math.PI * r;
        }

        public override string ToString()
        {
            return "Circle [radius=" + radius + "]";
        }
    }
}
