using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Square square = new Square(5.9,"red");
        Rectangle rectangle = new Rectangle(7.8,3.4,"green");
        Circle circle = new Circle(4.7,"blue");
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"\n\nColor:{shape.GetColor()}\nArea:{shape.GetArea()}");
        }
        
    }
}