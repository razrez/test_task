using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Shapes
{
    public class Circle : ShapeBase
    {
        public double Radius { get; }

        public Circle(string name, float radius) : base(name)
        {
            if (radius <= 0) throw new ArgumentException("Value must me positive");

            Radius = radius;
        }

        public override double GetArea() => Math.PI * Radius * Radius;
    }

    class test
    {
        void boo()
        {
            var c = new Circle("circle1", 2);
        }
    }
}
