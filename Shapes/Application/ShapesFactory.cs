using Shapes.Domain.Common;
using Shapes.Domain.Entities;
using Shapes.Entities;
using Shapes.Entities.Interfaces;
using System;

namespace Shapes.Application
{
    public class ShapesFactory
    {
        public static BaseShape CreateShape(string shapeType, params double[] parameteres)
        {
            switch (shapeType)
            {
                case "Triangle":
                    return new Triangle(shapeType, parameteres[0], parameteres[1], parameteres[2]);
                case "Circle":
                    return new Circle(shapeType, parameteres[0]);
                case "Rectangle":
                    return new Rectangle(shapeType, parameteres[0], parameteres[1]);
                default: 
                    throw new ArgumentException($"{shapeType} not supported");
            }
        }

        public static ITriangleCalculator CreateTriangle(string shapeType, params double[] parameteres)
        {
            return new Triangle(shapeType, parameteres[0], parameteres[1], parameteres[2]);
        }
    }
}
