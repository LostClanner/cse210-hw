using System;

class Program
{
    static void Main(string[] args)
    {

        Fraction TheFirstFraction = new Fraction();
        Console.WriteLine($"{TheFirstFraction.GetFractionString()}");
        Console.WriteLine($"{TheFirstFraction.GetDecimalValue()}");

        Fraction TheSecondFraction = new Fraction(6);

        Console.WriteLine($"{TheFirstFraction.GetFractionString()}");
        Console.WriteLine($"{TheFirstFraction.GetDecimalValue()}");

        Fraction TheThirdFraction = new Fraction(6, 7);
        Console.WriteLine($"{TheFirstFraction.GetFractionString()}");
        Console.WriteLine($"{TheFirstFraction.GetDecimalValue()}");


    }
}