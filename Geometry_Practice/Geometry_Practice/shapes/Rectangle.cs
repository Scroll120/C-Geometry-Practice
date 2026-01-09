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

        public override double calculateAre()
        {
            throw new NotImplementedException();
        }

        public override double calculatePerimeter()
        {
            throw new NotImplementedException();
        }

        public override string ToString() {
            throw new NotImplementedException();
        }
    }
}
