using Geometry_Practice.shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Practice.containers
{
    internal class ShapeCollection
    {
        private List<Shape> shapes;

        public ShapeCollection() { shapes = new List<Shape>(); }

        public void addShape(Shape shape) {
            shapes.Add(shape);
        }

        public string[][] getShapeTable() {
            throw new NotImplementedException();
        }

        public Shape getLargestShapeByPerimeter() {
            throw new NotImplementedException();
        }
        public Shape getLargestShapeByArea() {
            throw new NotImplementedException();
        }
    }
}
