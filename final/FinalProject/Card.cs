using System;

public enum CardNumber { Zero, One, Two, Three, Four, Five, Six, Seven, Eight, Nine }
public enum CardColor { Red, Yellow, Green, Blue, Black }



public abstract class Card
{
    public CardColor Color { get; protected set; }
    public CardNumber Number { get; protected set; }

    public Card(CardColor color, CardNumber number)
    {
        Color = color;
        Number = number;
    }


    public bool CanPlayCard(CardColor currentColor, CardNumber currentNumber)
    {
        if (Color == currentColor)
        {
            return true;
        }
        else if (Number == currentNumber)
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
        return $"{Color} {Number}";
    }





}