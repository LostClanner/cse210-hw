using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Blue", 5);
        shapes.Add(s1);

        string color = s1.GetColor();
        double area = s1.GetArea();

        Console.WriteLine($"The area of your shape is {area} and the color is {color}.");
    }
}