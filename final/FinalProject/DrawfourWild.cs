using System;




public class DrawFourWildCard : Card
{
    public DrawFourWildCard() : base(CardColor.Black, CardValue.DrawFour)
    {

    }

    public override bool SpecialCardEffect(Game game)
    {
        game.ChangeColor();
        game.ForceToDraw(4);
        return false;
    }

}