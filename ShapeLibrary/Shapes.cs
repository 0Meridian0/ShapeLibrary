namespace ShapeLibrary
{
    public interface IShape
    {
        double CalculateShapeArea();
    }

    public class Circle : IShape
    {
        public double Radius { get; set; }

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
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new ArgumentException("Стороны треугольника не могут быть отрицательными", nameof(a));
            }
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("Стороны треугольника не удовлетворяют неравенству треугольника", nameof(a));
            }

            A = a;
            B = b;
            C = c;
        }

        public double CalculateShapeArea()
        {
            var s = (A + B + C) / 2;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }

        public bool IsRightTriangle()
        {
            return (A * A + B * B == C * C) || (A * A + C * C == B * B) || (C * C + B * B == A * A);
        }
    }
}
