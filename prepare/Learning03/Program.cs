using System;

class Program
{
    static void Main(string[] args)
    {

        Fraction TheFirstFraction = new Fraction();
        Console.WriteLine($"{TheFirstFraction.GetFractionString()}");
        Console.WriteLine($"{TheFirstFraction.GetDecimalValue()}");

        Fraction TheSecondFraction = new Fraction(6);
        Console.WriteLine($"{TheSecondFraction.GetFractionString()}");
        Console.WriteLine($"{TheSecondFraction.GetDecimalValue()}");

        Fraction TheThirdFraction = new Fraction(6, 7);
        Console.WriteLine($"{TheThirdFraction.GetFractionString()}");
        Console.WriteLine($"{TheThirdFraction.GetDecimalValue()}");

        Fraction TheFourthFraction = new Fraction(1, 3);
        Console.WriteLine($"{TheFourthFraction.GetFractionString()}");
        Console.WriteLine($"{TheFourthFraction.GetDecimalValue()}");


    }
}