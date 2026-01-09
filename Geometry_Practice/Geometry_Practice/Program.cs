using Geometry_Practice.containers;
using Geometry_Practice.shapes;
using Geometry_Practice.util;
using System.Text;

namespace Geometry_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShapeCollection shapes = new ShapeCollection();

            shapes.addShape(new Circle(5.0));
            shapes.addShape(new Rectangle(4.0, 6.0));
            shapes.addShape(new Triangle(3.0, 4.0, 5.0));
            shapes.addShape(new Square(2.0));
            shapes.addShape(new EquilateralTriangle(3.0));
            shapes.addShape(new RegularPentagon(2.5));


            bool isRunning = true;

            while (isRunning) {
                showMenu();
                int option = int.Parse(Console.ReadLine());

                switch (option) {
                    case 1:
                        addNewShape(shapes);
                        break;
                    case 2:
                        showAllShapes(shapes);
                        break;
                    case 3:
                        showLargestShapeByPerimeter(shapes);
                        break;
                    case 4:
                        showLargestShapeByArea(shapes);
                        break;
                    case 5:
                        showFormulas();
                        break;
                    case 0:
                        isRunning = false;
                        Console.WriteLine("Exiting Program.");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again!");
                        break;
                    
                }
                
            }
        }

        private static void showMenu() {
            Console.WriteLine();
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Add new shape");
            Console.WriteLine("2. Show all shapes");
            Console.WriteLine("3. Show shape with the largest perimeter");
            Console.WriteLine("4. Show shape with the largest area");
            Console.WriteLine("5. Show formulas");
            Console.WriteLine("0. Exit");
            Console.Write("Select an option: ");
        }

        private static void addNewShape(ShapeCollection shapes) {
            Console.WriteLine("Choose a shape to add:");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Triangle");
            Console.WriteLine("4. Square");
            Console.WriteLine("5. Equilateral Triangle");
            Console.WriteLine("6. Regular Pentagon");

            int shapeChoice = int.Parse(Console.ReadLine());

            switch (shapeChoice) {
                case 1:
                    Console.Write("Enter radius: ");
                    shapes.addShape(new Circle(double.Parse(Console.ReadLine())));
                    break;

                case 2:
                    Console.Write("Enter width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Enter height: ");
                    double height = double.Parse(Console.ReadLine());
                    shapes.addShape(new Rectangle(width, height));
                    break;

                case 3:
                    Console.Write("Enter side a: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("Enter side b: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.Write("Enter side c: ");
                    double c = double.Parse(Console.ReadLine());
                    shapes.addShape(new Triangle(a, b, c));
                    break;

                case 4:
                    Console.Write("Enter side length: ");
                    shapes.addShape(new Square(double.Parse(Console.ReadLine())));
                    break;

                case 5:
                    Console.Write("Enter side length: ");
                    shapes.addShape(new EquilateralTriangle(double.Parse(Console.ReadLine())));
                    break;

                case 6:
                    Console.Write("Enter side length: ");
                    shapes.addShape(new RegularPentagon(double.Parse(Console.ReadLine())));
                    break;

                default:
                    Console.WriteLine("Invalid shape choice.");
                    break;
            }
        }

        private static void showAllShapes(ShapeCollection shapes) {
            string[,] table = shapes.getShapeTable();

            int rows = table.GetLength(0);
            int cols = table.GetLength(1);

            int[] columnWidths = new int[cols];

            for (int c = 0; c < cols; c++) {
                for (int r = 0; r < rows; r++) {
                    columnWidths[c] = Math.Max(columnWidths[c], table[r,c].Length);
                }
            }

            printSeparators(columnWidths);

            for (int r = 0; r < rows; r++) {
                for (int c = 0; c < cols; c++) {
                    Console.Write($"| {table[r, c].PadRight(columnWidths[c])} ");
                }
                Console.WriteLine("|");
                printSeparators(columnWidths);
                }

            Thread.Sleep(1500);
        }

        private static void printSeparators(int[] columnWidth) {
            Console.Write("+");

            foreach (int width in columnWidth) {
                Console.Write(new string('-', width + 2));
                Console.Write("+");
            }
            Console.WriteLine();
        }

        private static void showLargestShapeByPerimeter(ShapeCollection shapes) {
            Shape largest = shapes.getLargestShapeByPerimeter();
            Console.WriteLine(
                largest != null
                    ? $"Shape with the largest perimeter: {largest}"
                    : "No shapes in the collection."
            );
        }

        private static void showLargestShapeByArea(ShapeCollection shapes) {
            Shape largest = shapes.getLargestShapeByArea();
            Console.WriteLine(
                largest != null
                    ? $"Shape with the largest area: {largest}"
                    : "No shapes in the collection."
            );
        }

        private static void showFormulas() {
            Console.WriteLine("Choose a shape to see formulas:");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Triangle");
            Console.WriteLine("4. Square");
            Console.WriteLine("5. Equilateral Triangle");
            Console.WriteLine("6. Regular Pentagon");

            int shapeChoice = int.Parse(Console.ReadLine());
            string shapeName = getShapeNameByChoice(shapeChoice);

            if (!string.IsNullOrEmpty(shapeName))
            {
                Console.WriteLine($"{shapeName} area formula: {FormulaProvider.getAreaForShape(shapeName)}");
                Console.WriteLine($"{shapeName} perimeter formula: {FormulaProvider.getPerimeterForShape(shapeName)}");
            }
            else
            {
                Console.WriteLine("Invalid shape choice.");
            }
        }

        private static String getShapeNameByChoice(int shapeChoice) {
            return shapeChoice switch
            {
                1 => "Circle",
                2 => "Rectangle",
                3 => "Triangle",
                4 => "Square",
                5 => "EquilateralTriangle",
                6 => "RegularPentagon",
                _ => string.Empty
            };
        }

    }
}
