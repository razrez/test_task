using Shapes.Domain.Common;
using Shapes.Entities.Interfaces;

namespace Shapes.Domain.Entities
{
    internal class Triangle : BaseShape, ITriangleCalculator
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
            var nintyDegree = 90;
            var angleAB = CosToAngle(CalculateCos(A, B, C));
            var angleAC = CosToAngle(CalculateCos(A, C, B));
            var angleBC = CosToAngle(CalculateCos(B, C, A));

            return angleAB == nintyDegree || angleAC == nintyDegree || angleBC == nintyDegree;
        }

        private static int CosToAngle(double cos) => (int) Math.Ceiling(Math.Acos(cos) * 180 / Math.PI);

        public double CalculateCos(double a, double b, double c) => (a * a + b * b - c * c) / (2 * a * b);

        public double GetPerimeter() => A + B + C;
    }
}
