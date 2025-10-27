using System;




public class ReverseCard : Card
{
    public ReverseCard(CardColor color) : base(color, CardValue.Reverse)
    {

    }
    public override bool SpecialCardEffect(Game game)
    {
        game.ReverseDirection();
        return false;
    }

}