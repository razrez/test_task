namespace Shapes.Entities.Interfaces
{
    public interface ITriangleCalculator
    {
        public double CalculateCos(double a, double b, double c);
        public double GetPerimeter();
        public bool IsRightTriangle();
    }
}
