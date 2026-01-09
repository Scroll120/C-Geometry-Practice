using Geometry_Practice.shapes;
using Geometry_Practice.util;
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

        public string[,] getShapeTable() {
            string[] headers = { "ID", "Class", "toString", "Perimeter", "Formula", "Area", "Formula" };
            string[,] tableForm = new string[shapes.Count + 1, headers.Length];

            for (int j = 0; j < headers.Length; j++) {
                tableForm[0, j] = headers[j];
            }

            for (int i = 0; i < shapes.Count; i++) {
                Shape currentShape = shapes[i];

                tableForm[i + 1, 0] = i.ToString();
                tableForm[i + 1, 1] = currentShape.GetType().Name;
                tableForm[i + 1, 2] = currentShape.ToString();
                tableForm[i + 1, 3] = currentShape.calculatePerimeter().ToString();
                tableForm[i + 1, 4] = FormulaProvider.getPerimeterForShape(currentShape.GetType().Name);
                tableForm[i + 1, 5] = currentShape.calculateAre().ToString();
                tableForm[i + 1, 6] = FormulaProvider.getAreaForShape(currentShape.GetType().Name);
            }

            return tableForm;
        }

        public Shape getLargestShapeByPerimeter() {
            if (shapes.Count == 0) return null;

            Shape largestShape = shapes[0];
            double maxPerimeter = largestShape.calculatePerimeter();

            foreach (Shape shape in shapes) {
                double perimter = shape.calculatePerimeter();
                if (perimter > maxPerimeter) {
                    largestShape = shape;
                    maxPerimeter = perimter;
                }
            }

            return largestShape;
        }

        public Shape getLargestShapeByArea()
        {
            return shapes.Count == 0
                ? null
                : shapes.MaxBy(s => s.calculateAre());
        }
    }
}
