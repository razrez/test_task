using Shapes.Application;

namespace Shapes.Tests
{
    public class ShapesTest
    {
        [Fact]
        public void ShapesInitialization_ThrowsArgumentException_For_Negative_Numbers()
        {
            // triangle
            Assert.Throws<ArgumentException>(() => ShapesFactory.CreateShape("Triangle", -3, 4, 5));
            Assert.Throws<ArgumentException>(() => ShapesFactory.CreateShape("Triangle", 3, -4, 5));
            Assert.Throws<ArgumentException>(() => ShapesFactory.CreateShape("Triangle", 3, 4, -5));    
            Assert.Throws<ArgumentException>(() => ShapesFactory.CreateShape("Triangle", 0, 4, -5));

            // circle
            Assert.Throws<ArgumentException>(() => ShapesFactory.CreateShape("Circle", 0));
            Assert.Throws<ArgumentException>(() => ShapesFactory.CreateShape("Circle", -231));

            // rectangle
            Assert.Throws<ArgumentException>(() => ShapesFactory.CreateShape("Rectangle", 0, 21));
            Assert.Throws<ArgumentException>(() => ShapesFactory.CreateShape("Rectangle", 123, -2));
        }

        [Fact]
        public void TriangleInitialization_ThrowsArgumentException_For_Invalid_Sides()
        {
            Assert.Throws<ArgumentException>(() => ShapesFactory.CreateShape("Triangle", 234, 2, 5));
            Assert.Throws<ArgumentException>(() => ShapesFactory.CreateShape("Triangle", 3, 3500, 1));
            Assert.Throws<ArgumentException>(() => ShapesFactory.CreateShape("Triangle", 3, 4, 500));
        }

        [Fact]
        public void GetAreaReturnsCorrectValueForArea()
        {
            var triangle = ShapesFactory.CreateShape("Triangle", 6, 8, 10);
            double triangleAreaExpected = 24;
            Assert.Equal(triangleAreaExpected, triangle.GetArea());

            var circle = ShapesFactory.CreateShape("Circle", 2);
            var circleAreaExpected = Math.PI * 2 * 2;
            Assert.Equal(circleAreaExpected, circle.GetArea());

            var rectanle = ShapesFactory.CreateShape("Rectangle", 22, 35);
            double rectangleAreaExpected = 22 * 35;
            Assert.Equal(rectangleAreaExpected, rectanle.GetArea());
        }

        [Fact]
        public void TriangleIsRightReturnsTrue()
        {
            var triangle1 = ShapesFactory.CreateTriangle("Triangle", 3, 4, 5);
            Assert.True(triangle1.IsRightTriangle());

            var triangle2 = ShapesFactory.CreateTriangle("Triangle", 9, 12, 15);
            Assert.True(triangle2.IsRightTriangle());
        }

        [Fact]
        public void TriangleIsRightReturnsFalse()
        {
            var triangle1 = ShapesFactory.CreateTriangle("Triangle", 3, 4, 6);
            Assert.False(triangle1.IsRightTriangle());

            var triangle2 = ShapesFactory.CreateTriangle("Triangle", 9, 12, 11);
            Assert.False(triangle2.IsRightTriangle());
        }

    }
}