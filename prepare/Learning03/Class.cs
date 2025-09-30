using System;

class Fraction
{
    //getting the private variables
    private int _topNumber;
    private int _bottomNumber;


    //default constructor
    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    //constructor with one parameter
    public Fraction(int topNumber)
    {
        _topNumber = topNumber;
        _bottomNumber = 1;
    }
    //the constructor with two parameters
    public Fraction(int topNumber, int bottomNumber)
    {
        _topNumber = topNumber;
        _bottomNumber = bottomNumber;
    }

    public String GetFractionString()
    {
        string StringFraction = $"{_topNumber}/{_bottomNumber}";
        return StringFraction;
    }

    public double GetDecimalValue()
    {
        return (double)_topNumber / (double)_bottomNumber;
    }
}
    