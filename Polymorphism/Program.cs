using System;

abstract class Shape
{
    public string Name { get; }

    protected Shape(string name)
    {
        Name = name;
    }

    public abstract double Area();
    public abstract double Perimeter();
}

class Circle : Shape
{
    public double Radius { get; }

    public Circle(string name, double radius) : base(name)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

class Square : Shape
{
    public double Side { get; }


    public Square(string name, double side) : base(name)
    {
        Side = side;
    }

    public override double Area()
    {
        return Math.Pow(Side, 2);
    }


    public override double Perimeter()
    {
        return 4 * Side;
    }
}

class Program
{
    static void Main()
    {
        Circle circle1 = new Circle("Circle 1", 3);
        Circle circle2 = new Circle("Circle 2", 5);

        Square square1 = new Square("Square 1", 4);
        Square square2 = new Square("Square 2", 6);

        Shape[] shapes = { circle1, circle2, square1, square2 };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Name: {shape.Name}, Area: {shape.Area()}, Perimeter: {shape.Perimeter()}");
        }

        double maxCircleArea = Math.Max(circle1.Area(), circle2.Area());
        double maxSquareArea = Math.Max(square1.Area(), square2.Area());

        Console.WriteLine($"\nLargest Circle Area: {maxCircleArea}");
        Console.WriteLine($"Largest Square Area: {maxSquareArea}");
    }
}