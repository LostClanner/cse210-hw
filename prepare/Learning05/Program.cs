using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Blue", 5);
        shapes.Add(s1);

        Console.WriteLine(s1);
    }
}