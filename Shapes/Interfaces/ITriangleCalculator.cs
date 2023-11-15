using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.ShapesInterfaces
{
    internal interface ITriangleCalculator
    {
        public double CalculateCos(double a, double b, double c);
        public double GetPerimeter();
        public bool IsRightTriangle();
    }
}
