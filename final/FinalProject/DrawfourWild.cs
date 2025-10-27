using System;




public class DrawFourWildCard : Card
{
    public DrawFourWildCard() : base(CardColor.Black, CardValue.DrawFour)
    {

    }

    public override bool SpecialCardEffect(Game game)
    {
        CardColor newColor = game.ChangeColor();
        this.Color = newColor;

        Console.WriteLine($"The new color is {this.Color}");

        game.ForceToDraw(4);

        return true;
    }

}