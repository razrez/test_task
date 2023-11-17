using Shapes.Domain.Common;

namespace Shapes.Entities
{
    internal class Rectangle : BaseShape
    {
        public double A { get; }
        public double B { get; }

        public Rectangle(string name, double a, double b) : base(name) 
        {
            if (a <= 0 || b <= 0) throw new ArgumentException("Value must me positive");

            A = a;
            B = b;
        } 

        public override double GetArea() => A * B;
    }
}
