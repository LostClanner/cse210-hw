using System;
using System.Runtime.CompilerServices;


public abstract class Shape
{


        public Shape()
        {
            private string _color;

            protected string GetColor()
            {
                return _color;
            }

            protected void SetColor(string color)
            {
                _color = color;
            }
            protected abstract double GetArea();
        }   


}