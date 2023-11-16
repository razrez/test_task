using Shapes.Domain.Common;

namespace Shapes.Domain.Entities
{
    internal class Circle : BaseShape
    {
        public double Radius { get; }

        public Circle(string name, double radius) : base(name)
        {
            if (radius <= 0) throw new ArgumentException("Value must me positive");

            Radius = radius;
        }

        public override double GetArea() => Math.PI * Radius * Radius;
    }

}
