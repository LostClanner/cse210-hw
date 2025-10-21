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
            AddSpecialCard(color);
        }
        int i = 1;
        while (i < 5)
        {
            _theDeck.Add(new WildCard());
            _theDeck.Add(new DrawFourWildCard());
            i++;
        }

        // ShuffleDeck();



    }

    private void AddNumberCard(CardColor color)
    {
        int i = 0;

        while (i < 10)
        {
            _theDeck.Add(new NumberCard(color, (CardValue)i));
            _theDeck.Add(new NumberCard(color, (CardValue)i));
            i++;
        }
    }

    private void AddSpecialCard(CardColor color)
    {
        int i = 1;
        while (i < 3)
        {
            _theDeck.Add(new SkipCard(color));
            _theDeck.Add(new ReverseCard(color));
            _theDeck.Add(new DrawTwoCard(color));
            i++;
        }


    }
    private void ShuffleDeck() //https://github.com/JDSherbert/Fisher-Yates-Shuffle
    {
        Random rnd = new Random();

        int n = _theDeck.Count;
        for (int i = n - 1; i > 0; i--)
        {
            int k = rnd.Next(i + 1);

            (_theDeck[k], _theDeck[i]) = (_theDeck[i], _theDeck[k]);
        }
        
    }

    //----This is the end of the deck building logic----

    




    public void DrawCard()
    {

    }


    //temp to see
    public void DisplayDeck()
    {
        foreach (Card card in _theDeck)
        {
            Console.WriteLine(card.ToString());
        }
    }


}