using NUnit.Framework.Internal;
using ShapeLibrary;

namespace ShapeTests
{
    public class Tests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void Cicrle_Area_Correct()
        {
            var circle = new Circle(5);
            var area = circle.CalculateShapeArea();
            Assert.That(area, Is.EqualTo(Math.PI * 25).Within(0.001));
        }

        [Test]
        public void Triangle_Area_Correct()
        {
            var triangle = new Triangle(5, 3, 4);
            var area = triangle.CalculateShapeArea();
            Assert.That(area, Is.EqualTo(6).Within(0.001));
        }

        [Test]
        public void Triangle_IsRightTriangle_True()
        {
            var triangle = new Triangle(5, 3, 4);
            var isRightTriangle = triangle.IsRightTriangle();
            Assert.That(isRightTriangle, Is.True);
        }

        [Test]
        public void Triangle_IsRightTriangle_False()
        {
            var triangle = new Triangle(5, 3, 7);
            var isRightTriangle = triangle.IsRightTriangle();
            Assert.That(isRightTriangle, Is.False);
        }
    }
}