using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
    
        // Create a Square instance
        Square square = new Square("Red", 4);
        Console.WriteLine($"Square: Color = {square.Color}, Area = {square.GetArea()}");

        // Create a Rectangle instance
        Rectangle rectangle = new Rectangle("Blue", 5, 3);
        Console.WriteLine($"Rectangle: Color = {rectangle.Color}, Area = {rectangle.GetArea()}");

        // Create a Circle instance
        Circle circle = new Circle("Green", 2.5);
        Console.WriteLine($"Circle: Color = {circle.Color}, Area = {circle.GetArea()}");

        // Create a list of shapes
        List<Shape> shapes = new List<Shape>
        {
            square,
            rectangle,
            circle
        };

        // Iterate through the list of shapes and display their color and area
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetType().Name}: Color = {shape.Color}, Area = {shape.GetArea()}");
        }
    }
}
