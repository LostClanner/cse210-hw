using System;
using System.Drawing;




public class Deck
{
    private List<Card> _theDeck = new List<Card>();
    public Deck()
    {

    }

    //----This Logic is all for building the deck----
    public void MakeNewDeck()
    {
        var colors = new []{ CardColor.Blue, CardColor.Green, CardColor.Red, CardColor.Yellow };

        foreach (var color in colors)
        {
            AddNumberCard(color);
        }



    }

    private void AddNumberCard(CardColor color)
    {
        int i = 0;

        while (i < 10)
        {
            _theDeck.Add(new BasicCard(color, (CardNumber)i));
            _theDeck.Add(new BasicCard(color, (CardNumber)i));
            i++;
        }
    }



    //----This is the end of the deck building logic----

    


    public void ShuffleDeck()
    {
        
    }

    public void DrawCard()
    {

    }
    
    // public void PlaceCardFromDeck()
    // {
        
    // }

    //temp to see
    public void DisplayDeck()
    {
        foreach (Card card in _theDeck)
        {
            Console.WriteLine(card);
        }
    }


}