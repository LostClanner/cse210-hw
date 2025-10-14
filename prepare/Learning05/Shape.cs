using System;
using System.Runtime.CompilerServices;


public abstract class Shape
{

    private string _color;
        
        protected Shape(string color)
    {
        _color = color;
    }
        
        protected string GetColor()
        {
            return _color;
        }

        protected void SetColor(string color)
        {
            _color = color;
        }
        public abstract double GetArea();
        
}