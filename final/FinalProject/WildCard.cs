using System;




public class WildCard : Card
{
    public WildCard() : base(CardColor.Black, CardValue.Wild)
    {

    }

    public override bool SpecialCardEffect(Game game)
    {
        CardColor newColor = game.ChangeColor();
        this.Color = newColor;

        Console.WriteLine($"The new color is {this.Color}");
        return false;
    }

}