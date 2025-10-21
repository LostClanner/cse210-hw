using System;

public enum CardValue
{
    Zero, One, Two, Three, Four, Five, Six, Seven, Eight, Nine,
    Skip, Reverse, DrawTwo, DrawFour
}
public enum CardColor { Red, Yellow, Green, Blue, Black }



public abstract class Card
{
    public CardColor Color { get; protected set; }
    public CardValue Value { get; protected set;  }

    public Card(CardColor color, CardValue value)
    {
        Color = color;
        Value = value;
    }


    public bool CanPlayCard(CardColor currentColor, CardValue currentValue)
    {
        if (Color == currentColor)
        {
            return true;
        }
        else if (Value == currentValue)
        {
            return true;
        }
        else if (Color == CardColor.Black)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    // protected abstract *IDKYET* SpecialCardEffect()


    public override string ToString()
    {
        return $"{Color} {Value}";
    }





}