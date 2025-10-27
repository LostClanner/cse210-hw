using System;




public class SkipCard : Card
{
    public SkipCard(CardColor color) : base(color, CardValue.Skip)
    {

    }
    
    public override bool SpecialCardEffect(Game game)
    {
        game.SkipNextPlayer();
        return true;
    }

}