using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Blue", 5);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Yellow", 14, 28);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 4);


        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The area of your shape is {area} and the color is {color}.");
        }
    }
}