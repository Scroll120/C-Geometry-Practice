using Geometry_Practice.containers;
using Geometry_Practice.shapes;
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
            throw new NotImplementedException();
        }

        private static void addNewShape(ShapeCollection shapes) {
            throw new NotImplementedException();
        }

        private static void showAllShapes(ShapeCollection shapes) {
            throw new NotImplementedException();
        }

        private static string printSeparators(int[] columnWidth) {
            throw new NotImplementedException();
        }

        private static void showLargestShapeByPerimeter(ShapeCollection shapes) {
            throw new NotImplementedException();
        }

        private static void showLargestShapeByArea(ShapeCollection shapes) {
            throw new NotImplementedException();
        }

        private static void showFormulas() {
            throw new NotImplementedException();
        }

        private static String getShapeNameByChoice(int shapeChoice) {
            throw new NotImplementedException();
        }

    }
}
