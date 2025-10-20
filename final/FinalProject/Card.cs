using System;



public abstract class Card
{
    public enum CardColor { Red, Yellow, Green, Blue, Black }
    public enum CardNUmber {One, Two, Three, Four, Five, Six, Seven, Eight, Nine}
    private CardColor _color;
    private CardNUmber _number;

    public Card(CardColor color, CardNUmber number)
    {
        _color = color;
        _number = number;
    }


    public bool CanPlayCard(string currentColor, int currentNumber)
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