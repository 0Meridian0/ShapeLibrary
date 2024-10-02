namespace ShapeLibrary
{
    public interface IShape
    {
        double CalculateShapeArea();
    }

    public class Circle : IShape
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть больше ноля", nameof(radius));
            }

            Radius = radius;
        }

        public double CalculateShapeArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Triangle : IShape
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new ArgumentException("Стороны треугольника не могут быть отрицательными", nameof(a));
            }
            if ((a + b).CompareTo(c) == 0 || (a + c).CompareTo(b) == 0 || (b + c).CompareTo(a) == 0)
            {
                throw new ArgumentException("Стороны треугольника не удовлетворяют неравенству треугольника", nameof(a));
            }

            A = a;
            B = b;
            C = c;
        }

        public double CalculateShapeArea()
        {
            var halfPerimeter = (A + B + C) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
        }

        public bool IsRightTriangle()
        {
            return ((A * A + B * B).CompareTo(C * C) == 0 ||
                    (A * A + C * C).CompareTo(B * B) == 0 ||
                    (C * C + B * B).CompareTo(A * A) == 0);
        }
    }
}
