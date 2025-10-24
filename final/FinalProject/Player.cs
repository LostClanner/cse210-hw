using System;



public class Player
{
    private List<Card> _playerHand = new List<Card>();

        public Player()
    {
        
    }

    public void PlayCard(Card card)
    {
        _playerHand.Remove(card);
    }

    public void AddCardToHand(Card card)
    {

        _playerHand.Add(card);

    }



    public Card FindPlayableCard(Card topOfDiscardPile)
    {
        foreach (Card card in _playerHand)
        {
            if (card.CanPlayCard(topOfDiscardPile.Color, topOfDiscardPile.Value))
            {
                return card;
            }
        }
        return null;
    }

    //tesing purposes
    // public void DisplayHand()
    // {
    //     Console.WriteLine("--Your hand--");
    //     foreach (Card card in _playerHand)
    //     {
    //         Console.Write($"{card} ");
    //     }
    // }
    
    public List<Card> GetHand()
    {
        return _playerHand;
    }


    //This needs a lot of work, dont forget to fix it
    //Fine for now, but it should return a list.
    // public void GetHand()
    // {
    //     foreach (Card card in _playerHand)
    //     {
    //         if (card.CanPlayCard(CardColor.Yellow, CardValue.Seven)) // this well need to be changed before the final implamentaion
    //         {
    //             Console.WriteLine("Playable cards");
    //             Console.Write($"{card.ToString} ");

    //         }
    //         else
    //         {
    //             Console.WriteLine("Cards unable to be played");
    //             Console.Write($"{card.ToString} ");
    //         }

    //     }
    // }
    
}