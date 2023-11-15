using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.ShapesInterfaces;

namespace Shapes.Shapes
{
    public class Triangle : ShapeBase, ITriangleCalculator
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(string name, double a, double b, double c) : base(name)
        {
            if (a <= 0 || b <= 0 || c <= 0) throw new ArgumentException("Value must me positive");
            if (a + b <= c || a + c <= b || b + c <= a) throw new ArgumentException("Such a triangle doesn't exist");

            A = a;
            B = b;
            C = c;
        }

        public override double GetArea()
        {
            var p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool IsRightTriangle()
        {
            var cosAB = CalculateCos(A, B, C);
            var cosAC = CalculateCos(A, C, B);
            var cosBC = CalculateCos(B, C, A);

            return cosAB == 1 || cosAC == 1 || cosBC == 1;
        }

        public double CalculateCos(double a, double b, double c) => (a * a + b * b - c * c) / 2 * a * b;

        public double GetPerimeter() => A + B + C;
    }
}
