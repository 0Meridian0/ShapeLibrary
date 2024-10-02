using NUnit.Framework.Internal;
using ShapeLibrary;

namespace ShapeTests
{
    public class CircleShapeTests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void Circle_Constructor_SetCorrect()
        {
            double radius = 7.0;
            var circle = new Circle(radius);

            Assert.That(circle.Radius, Is.EqualTo(radius).Within(0.001));
        }

        [Test]
        public void Circle_Constructor_ZeroRadius_ArgumentExeption()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
        }

        [Test]
        public void Circle_Constructor_NegativeRadius_ArgumentExeption()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-5));
        }

        [Test]
        public void Cicrle_Area_Correct()
        {
            var circle = new Circle(5);
            var area = circle.CalculateShapeArea();

            Assert.That(area, Is.EqualTo(Math.PI * Math.Pow(5, 2)).Within(0.001));
        }
    }

    public class TriangleShapeTests
    {
        [Test]
        public void Triangle_Constructor_SetCorrect()
        {
            double a = 5.0;
            double b = 3.0;
            double c = 4.0;

            var triangle = new Triangle(a, b, c);

            Assert.That(triangle.A, Is.EqualTo(a).Within(0.001));
            Assert.That(triangle.B, Is.EqualTo(b).Within(0.001));
            Assert.That(triangle.C, Is.EqualTo(c).Within(0.001));
        }

        [Test]
        public void Triangle_Constructor_NegativeSide_ArgumentExeption()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-5.0, 3.0, 4.0));
            Assert.Throws<ArgumentException>(() => new Triangle(5.0, -3.0, 4.0));
            Assert.Throws<ArgumentException>(() => new Triangle(5.0, 3.0, -4.0));
        }

        [Test]
        public void Triangle_Constructor_SidesNotSatisfyingTriangleInequality_ArgumentExeption()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(0.5, 3.0, 4.0));
            Assert.Throws<ArgumentException>(() => new Triangle(5.0, 0.5, 4.0));
            Assert.Throws<ArgumentException>(() => new Triangle(5.0, 3.0, 1.0));
        }

        [Test]
        public void Triangle_Area_Correct()
        {
            double a = 5.0;
            double b = 3.0;
            double c = 4.0;

            var triangle = new Triangle(a, b, c);
            var area = triangle.CalculateShapeArea();

            double halfPerimeter = (a + b + c) / 2;
            var expectedArea = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));

            Assert.That(area, Is.EqualTo(expectedArea).Within(0.001));
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