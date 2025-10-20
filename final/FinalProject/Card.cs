using System;

public enum CardNumber { Zero, One, Two, Three, Four, Five, Six, Seven, Eight, Nine }
public enum CardColor { Red, Yellow, Green, Blue, Black }



public abstract class Card
{
    public CardColor _color { get; protected set; }
    public CardNumber _number { get; protected set; }

    public Card(CardColor color, CardNumber number)
    {
        _color = color;
        _number = number;
    }


    public bool CanPlayCard(CardColor currentColor, CardNumber currentNumber)
    {
        if (_color == currentColor)
        {
            return true;
        }
        else if (_number == currentNumber)
        {
            return true;
        }
        else if (_color == CardColor.Black)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    // protected *IDKYET* SpecialCardEffect()
    // {

    //     return *IDKYET *;
    // }





}