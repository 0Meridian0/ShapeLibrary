using ShapeLibrary;

IShape shape = new Circle(7);
//IShape shape = new Cicrle(-7);
shape = new Triangle(3, 4, 6);

var area = shape.CalculateShapeArea();
Console.WriteLine(area);

var triangle = new Triangle(3, 4, 5);
Console.WriteLine($"Является ли треугольник прямоугольным: {triangle.IsRightTriangle()}");