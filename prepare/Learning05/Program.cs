using System;

class Program
{
    static void Main(string[] args)
    {
        SquareShape square = new SquareShape();
        RectangleShape rectangle = new RectangleShape();
        CircleShape circle = new CircleShape();

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape s in shapes)
        {
            double area = s.GetArea();

            Console.WriteLine($"The shape has an area of {area}");
        }
    }
}