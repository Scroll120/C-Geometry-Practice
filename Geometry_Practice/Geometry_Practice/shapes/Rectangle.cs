using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Practice.shapes
{
    internal class Rectangle : Shape{
        private double length;
        private double width;


        public Rectangle(double length, double width) {
            this.length = length;
            this.width = width;
        }

        public double getLength() { return length; }

        public override double calculateAre()
        {
            return length * width;
        }

        public override double calculatePerimeter()
        {
            return 2 * (length + width);
        }

        public override string ToString() {
            return "Rectangle [length= " + length + ", width=" + width + "]";
        }
    }
}
