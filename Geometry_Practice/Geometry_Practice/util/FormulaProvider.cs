using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Practice.util
{
    internal class FormulaProvider
    {

        public static string getAreaForShape(String shape) {
            switch (shape)
            {
                case "Circle":
                    return "π×r×r";
                case "Rectangle":
                    return "a×b";
                case "Triangle":
                    return "sqrt(s×(s-a)×(s-b)×(s-c))";
                case "Square":
                    return "a×a";
                case "EquilateralTriangle":
                    return "(a×a×sqrt(3))/4";
                case "RegularPentagon":
                    return "(a×a×sqrt(5×(5 + 2×sqrt(5))))/4";
                default:
                    return "Unknown shape";
            }
        }

        public static string getPerimeterForShape(string shape) {
            switch (shape)
            {
                case "Circle":
                    return "2×π×r";
                case "Rectangle":
                    return "2×a + 2×b";
                case "Triangle":
                    return "a + b + c";
                case "Square":
                    return "4×a";
                case "EquilateralTriangle":
                    return "3×a";
                case "RegularPentagon":
                    return "5×a";
                default:
                    return "Unknown shape";
            }
        }
    }
}
