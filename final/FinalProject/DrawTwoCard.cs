using System;




public class DrawTwoCard : Card
{
    public DrawTwoCard(CardColor color) : base(color, CardValue.DrawTwo)
    {

    }

    public override bool SpecialCardEffect(Game game)
    {
        game.ForceToDraw(2);
        return true;
    }    

}