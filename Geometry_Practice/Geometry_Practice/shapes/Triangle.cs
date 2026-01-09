using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Practice.shapes
{
    internal class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double getA() { return a; }

        public override double calculateAre()
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public override double calculatePerimeter()
        {
            return a + b + c;
        }

        public override string ToString()
        {
            return "Triangle [a=" + a + ", b=" + b + ", c=" + c + "]";
        }
    }
}
