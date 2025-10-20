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


    protected bool CanPlayCard()
    {
        return true;
    }


    // protected *IDKYET* SpecialCardEffect()
    // {

    //     return *IDKYET *;
    // }





}