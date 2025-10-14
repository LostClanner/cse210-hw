using System;



public class Rectangle : Shape
{
    private double _width;
    private double _higth;

    public Rectangle(string color, double width, double hight) : base(color)
    {
        _width = width;
        _higth = hight;
    }
    public override double GetArea()
    {
        return _width * _higth;
    }


}