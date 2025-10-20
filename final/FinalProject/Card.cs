using System;



public abstract class Card
{
    private string _color;
    private int _number;

    public Card(string color, int number)
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
        else if (_color == "black")
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