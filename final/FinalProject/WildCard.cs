using System;




public class WildCard : Card
{
    public WildCard() : base(CardColor.Black, CardValue.Wild)
    {

    }

    public override bool SpecialCardEffect(Game game)
    {
        game.ChangeColor();
        return false;
    }

}